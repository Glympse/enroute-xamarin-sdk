#!/bin/bash
set -e

#
# This script creates a zip file containing Dlls from the Enroute Android and iOS Xamarin libraries.
#

# Clean up previous builds
rm -rf tmp_dlls
mkdir tmp_dlls
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
cp ../source/EnRouteApiAndroid/bin/Release/EnRouteApi.Android.dll tmp_dlls/EnRouteApi.Android.dll
cp ../source/EnRouteApiAndroid/bin/Release/EnRouteApi.dll tmp_dlls/EnRouteApi.dll

# Clean the iOS build
/Library/Frameworks/Mono.framework/Commands/xbuild /p:Configuration=Release /p:BuildIpa=false /target:Build ../source/EnRouteApiiOS/EnRouteApi.iOS.csproj /t:Clean

# Build the iOS solution
/Library/Frameworks/Mono.framework/Commands/xbuild /p:Configuration=Release /p:BuildIpa=false /target:Build ../source/EnRouteApiiOS/EnRouteApi.iOS.csproj

# Move iOS Dlls to the output folder
cp ../source/EnRouteApiiOS/bin/Release/EnRouteApi.iOS.dll tmp_dlls/EnRouteApi.iOS.dll

# Create a version.properties to package with the zip
echo "XAMARIN_SDK_VERSION=${XAMARIN_SDK_VERSION}" > tmp_dlls/version.properties
echo "CLIENT_SDK_VERSION=${CLIENT_SDK_VERSION}" >> tmp_dlls/version.properties

# Zip the Dlls
TARGET_ZIP=EnRoute_Api_Xamarin_$XAMARIN_SDK_VERSION.zip
echo "Creating archive $TARGET_ZIP" 
pushd tmp_dlls > /dev/null
    rm -rf $TARGET_ZIP
    zip -q -r -y $TARGET_ZIP .
    mv $TARGET_ZIP ../build/$TARGET_ZIP
popd > /dev/null

