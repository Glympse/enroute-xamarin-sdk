#!/bin/bash
set -e

#
# The script unpacks native SDKs and places dependencies where appropriately.
#

PACKAGE_ANDROID=$(ls -t *Android* | head -1)
PACKAGE_IOS=$(ls -t *iOS* | head -1)

TMP_ANDROID=./tmp_android
TMP_IOS=./tmp_ios

# Cleanup
rm -rf tmp_*

# Copy Android dependencies
unzip $PACKAGE_ANDROID -d $TMP_ANDROID
cp $TMP_ANDROID/lib/EnRouteApi/libs/* ../source/EnRouteApiAndroid/Jars
cp $TMP_ANDROID/lib/GlympseApi/libs/* ../source/EnRouteApiAndroid/Jars
pushd $TMP_ANDROID/lib/GlympseApi > /dev/null
    zip -r GlympseApi.zip ./res
    mkdir bin
    cp ./AndroidManifest.xml bin/AndroidManifest.xml
    zip -r GlympseApi.zip ./bin
    rm -rf bin
popd > /dev/null
mv $TMP_ANDROID/lib/GlympseApi/GlympseApi.zip ../source/EnRouteApiAndroid/Res

# Copy iOS dependencies
unzip $PACKAGE_IOS -d $TMP_IOS
cp $TMP_IOS/lib/EnRouteApi/lib/libc++/* ../source/EnRouteApiiOS/Libs
