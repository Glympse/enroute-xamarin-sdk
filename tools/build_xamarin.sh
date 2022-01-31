#!/bin/bash
set -e

#
# This script creates a zip file containing Dlls from the Enroute Android and iOS Xamarin libraries.
#

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

# NuGet Restore
/Library/Frameworks/Mono.framework/Commands/nuget restore ../samples/EnRouteDemo/EnRouteDemo.sln -msbuildversion 15

# Clean the Andriod build
/Library/Frameworks/Mono.framework/Commands/msbuild /p:Configuration=Release /p:AndroidClassParser=class-parse /target:Clean ../source/EnRouteApiAndroid/EnRouteApi.Android.csproj

# Build the Android solution
/Library/Frameworks/Mono.framework/Commands/msbuild /p:Configuration=Release /p:AndroidClassParser=class-parse /target:Build ../source/EnRouteApiAndroid/EnRouteApi.Android.csproj

# Move Android Dlls to the output folder
cp ../source/EnRouteApiAndroid/bin/Release/EnRouteApi.Android.dll ${ANDROID_LIB_DIRECTORY}/EnRouteApi.Android.dll
cp ../source/EnRouteApiAndroid/bin/Release/EnRouteApi.dll ${SHARED_LIB_DIRECTORY}/EnRouteApi.dll

# Clean the iOS build
/Library/Frameworks/Mono.framework/Commands/msbuild /p:Configuration=Release /p:BuildIpa=false /target:Clean ../source/EnRouteApiiOS/EnRouteApi.iOS.csproj

# Build the iOS solution
/Library/Frameworks/Mono.framework/Commands/msbuild /p:Configuration=Release /p:BuildIpa=false /target:Build ../source/EnRouteApiiOS/EnRouteApi.iOS.csproj

# Move iOS Dlls to the output folder
cp ../source/EnRouteApiiOS/bin/Release/EnRouteApi.iOS.dll ${IOS_LIB_DIRECTORY}/EnRouteApi.iOS.dll

# Create a version.properties to package with the zip
CONFIG_SOURCE_FILE="../source/EnRouteApi/Source/Core/Config.cs"
XAMARIN_SDK_VERSION=$(./GetVersionNumber.py $CONFIG_SOURCE_FILE)
echo "XAMARIN_SDK_VERSION=${XAMARIN_SDK_VERSION}" > tmp_dlls/etc/version.properties
echo "CLIENT_SDK_VERSION=${CLIENT_SDK_VERSION}" >> tmp_dlls/etc/version.properties

# Sign all of the Dlls
codesign -s Glympse_Xamarin ${SHARED_LIB_DIRECTORY}/EnRouteApi.dll -v
codesign -s Glympse_Xamarin ${IOS_LIB_DIRECTORY}/EnRouteApi.iOS.dll -v
codesign -s Glympse_Xamarin ${ANDROID_LIB_DIRECTORY}/EnRouteApi.Android.dll -v

# Build the archive
TARGET_ZIP=EnRoute_Api_Xamarin_$XAMARIN_SDK_VERSION.zip
pushd tmp_dlls > /dev/null
    rm -rf $TARGET_ZIP

    # Zip the Dlls
    echo "Creating archive $TARGET_ZIP" 
    zip -q -r -y $TARGET_ZIP .
    mv $TARGET_ZIP ../build/$TARGET_ZIP
popd > /dev/null

