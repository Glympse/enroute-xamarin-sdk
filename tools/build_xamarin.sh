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

# Get XAMARIN_SDK_VERSION
. ../version.properties

# Clean the Andriod build
/Library/Frameworks/Mono.framework/Commands/xbuild /p:Configuration=Release /t:PackageForAndroid /target:Build ../source/EnRouteApiAndroid/EnRouteApi.Android.csproj /t:Clean

# Build the Android solution
/Library/Frameworks/Mono.framework/Commands/xbuild /p:Configuration=Release /t:PackageForAndroid /target:Build ../source/EnRouteApiAndroid/EnRouteApi.Android.csproj

# Move Android Dlls to the output folder
cp ../source/EnRouteApiAndroid/bin/Release/EnRouteApi.Android.dll ${ANDROID_LIB_DIRECTORY}/EnRouteApi.Android.dll
cp ../source/EnRouteApiAndroid/bin/Release/EnRouteApi.dll ${SHARED_LIB_DIRECTORY}/EnRouteApi.dll

# Clean the iOS build
/Library/Frameworks/Mono.framework/Commands/xbuild /p:Configuration=Release /p:BuildIpa=false /target:Build ../source/EnRouteApiiOS/EnRouteApi.iOS.csproj /t:Clean

# Build the iOS solution
/Library/Frameworks/Mono.framework/Commands/xbuild /p:Configuration=Release /p:BuildIpa=false /target:Build ../source/EnRouteApiiOS/EnRouteApi.iOS.csproj

# Move iOS Dlls to the output folder
cp ../source/EnRouteApiiOS/bin/Release/EnRouteApi.iOS.dll ${IOS_LIB_DIRECTORY}/EnRouteApi.iOS.dll

# Create a version.properties to package with the zip
echo "XAMARIN_SDK_VERSION=${XAMARIN_SDK_VERSION}" > tmp_dlls/etc/version.properties
echo "CLIENT_SDK_VERSION=${CLIENT_SDK_VERSION}" >> tmp_dlls/etc/version.properties

# Sign all of the Dlls
codesign -s Glympse ${SHARED_LIB_DIRECTORY}/EnRouteApi.dll -v
codesign -s Glympse ${IOS_LIB_DIRECTORY}/EnRouteApi.iOS.dll -v
codesign -s Glympse ${ANDROID_LIB_DIRECTORY}/EnRouteApi.Android.dll -v

# Build the archive
TARGET_ZIP=EnRoute_Api_Xamarin_$XAMARIN_SDK_VERSION.zip
pushd tmp_dlls > /dev/null
    rm -rf $TARGET_ZIP

    # Zip the Dlls
    echo "Creating archive $TARGET_ZIP" 
    zip -q -r -y $TARGET_ZIP .
    mv $TARGET_ZIP ../build/$TARGET_ZIP
popd > /dev/null

