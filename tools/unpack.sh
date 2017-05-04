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

pushd $TMP_ANDROID/lib/EnRouteApi > /dev/null
    unzip EnRouteApi-release.aar
popd > /dev/null

pushd $TMP_ANDROID/lib/GlympseApi > /dev/null
    unzip GlympseApi-release.aar
popd > /dev/null

pushd $TMP_ANDROID/lib/GlympseApiToolbox > /dev/null
    unzip GlympseApiToolbox-release.aar
popd > /dev/null

cp $TMP_ANDROID/lib/EnRouteApi/classes.jar ../source/EnRouteApiAndroid/Jars/EnRouteApi.jar
cp $TMP_ANDROID/lib/GlympseApiToolbox/classes.jar ../source/EnRouteApiAndroid/Jars/GlympseApiToolbox.jar
cp $TMP_ANDROID/lib/GlympseApi/classes.jar ../source/EnRouteApiAndroid/Jars/GlympseApi.jar

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
