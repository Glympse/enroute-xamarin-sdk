#!/bin/bash
set -e

#
# This script creates a zip file containing Dlls from the Enroute Android and iOS MAUI libraries.
#
# Use -publish to push this build to NuGet
# The environment variable NUGET_API_KEY must be declared to perform this action

PUBLISH=false

while [ $# -gt 0 ]; do
    case "$1" in
        -publish) PUBLISH=true;;
    esac
    shift
done

SHARED_LIB_DIRECTORY=tmp_dlls/lib/EnRouteApi
ANDROID_LIB_DIRECTORY=tmp_dlls/lib/EnRouteApiAndroid
IOS_LIB_DIRECTORY=tmp_dlls/lib/EnRouteApiiOS
ETC_DIRECTORY=tmp_dlls/etc

# Clean up previous builds
rm -rf tmp_dlls
mkdir -p ${SHARED_LIB_DIRECTORY} ${ANDROID_LIB_DIRECTORY} ${IOS_LIB_DIRECTORY} ${ETC_DIRECTORY}
rm -rf build
mkdir build

# Figure out the client sdk version based on the zips we have
CLIENT_SDK_ZIP=$(find . -name "EnRoute_Api_Android_*.zip" | cut -d '_' -f 4)
CLIENT_SDK_VERSION=${CLIENT_SDK_ZIP%.zip}

# Solution Restore
pushd ../MAUI/samples/EnRouteDemo/ > /dev/null
    dotnet restore EnRouteDemo.sln 
popd > /dev/null

# Clean and build the Android project
pushd ../MAUI/source/EnRouteApi.Android.MAUI/ > /dev/null
    dotnet clean EnRouteApi.Android.MAUI.csproj
    dotnet build EnRouteApi.Android.MAUI.csproj --configuration Release
popd > /dev/null

# Move Android Dlls and native AARs to the output folder
cp ../MAUI/source/EnRouteApi.Android.MAUI/bin/Release/net9.0-android/EnRouteApi.Android.MAUI.dll ${ANDROID_LIB_DIRECTORY}/EnRouteApi.Android.MAUI.dll
cp ../MAUI/source/EnRouteApi.Android.MAUI/bin/Release/net9.0-android/EnRouteApi.MAUI.dll ${ANDROID_LIB_DIRECTORY}/EnRouteApi.MAUI.dll
cp ../MAUI/source/EnRouteApi.Android.MAUI/bin/Release/net9.0-android/EnRouteApi.MAUI.dll ${SHARED_LIB_DIRECTORY}/EnRouteApi.MAUI.dll
find ../MAUI/source/EnRouteApi.Android.MAUI/bin/Release/net9.0-android/ -name "*.aar" -exec cp {} ${ANDROID_LIB_DIRECTORY} \;

# Clean and build the iOS project
pushd ../MAUI/source/EnRouteApi.iOS.MAUI/ > /dev/null
    dotnet clean EnRouteApi.iOS.MAUI.csproj
    dotnet build EnRouteApi.iOS.MAUI.csproj --configuration Release
popd > /dev/null

# Move iOS Dll and native framework to the output folder
cp ../MAUI/source/EnRouteApi.iOS.MAUI/bin/Release/net9.0-ios/EnRouteApi.iOS.MAUI.dll ${IOS_LIB_DIRECTORY}/EnRouteApi.iOS.MAUI.dll
cp ../MAUI/source/EnRouteApi.iOS.MAUI/bin/Release/net9.0-ios/EnRouteApi.MAUI.dll ${IOS_LIB_DIRECTORY}/EnRouteApi.MAUI.dll
cp -R ../MAUI/source/EnRouteApi.iOS.MAUI/bin/Release/net9.0-ios/EnRouteApi.iOS.MAUI.resources ${IOS_LIB_DIRECTORY}/EnRouteApi.iOS.MAUI.resources

# Create a version.properties to package with the zip
CONFIG_SOURCE_FILE="../MAUI/source/EnRouteApi.MAUI/Source/Core/Config.cs"
MAUI_SDK_VERSION=$(python ./GetVersionNumber.py $CONFIG_SOURCE_FILE)
echo "MAUI_SDK_VERSION=${MAUI_SDK_VERSION}" > tmp_dlls/etc/version.properties
echo "CLIENT_SDK_VERSION=${CLIENT_SDK_VERSION}" >> tmp_dlls/etc/version.properties

# Sign all of the Dlls
codesign -s Glympse_Xamarin ${SHARED_LIB_DIRECTORY}/EnRouteApi.MAUI.dll -v
codesign -s Glympse_Xamarin ${IOS_LIB_DIRECTORY}/EnRouteApi.iOS.MAUI.dll -v
codesign -s Glympse_Xamarin ${ANDROID_LIB_DIRECTORY}/EnRouteApi.Android.MAUI.dll -v

# Build the archive
TARGET_ZIP=EnRoute_Api_MAUI_$MAUI_SDK_VERSION.zip
pushd tmp_dlls > /dev/null
    rm -rf $TARGET_ZIP

    # Zip the Dlls
    echo "Creating archive $TARGET_ZIP" 
    zip -q -r -y $TARGET_ZIP .
    mv $TARGET_ZIP ../build/$TARGET_ZIP

    if [ "$PUBLISH" != false ]; then 
        # Update nuspec template with the version number.
        NUSPEC_FILE="EnRouteApi.MAUI.nuspec"
        sed "s#{VERSION}#$MAUI_SDK_VERSION#" "../${NUSPEC_FILE}.template" > ${NUSPEC_FILE}

        # Rename directories
        pushd lib > /dev/null
            mv "EnRouteApi" "net9.0"
            mv "EnRouteApiAndroid" "net9.0-android35"
            mv "EnRouteApiiOS" "net9.0-ios18.0"
        popd > /dev/null

        nuget pack ${NUSPEC_FILE}
        dotnet nuget push "EnRouteApi.MAUI.${MAUI_SDK_VERSION}.nupkg" --api-key ${NUGET_API_KEY} --source "https://api.nuget.org/v3/index.json"
    fi
popd > /dev/null

