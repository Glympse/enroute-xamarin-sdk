#!/bin/bash
set -e

#
# The script unpacks native SDKs and places dependencies where appropriate.
#

PACKAGE_ANDROID=$(ls -t *Android* | head -1)
PACKAGE_IOS=$(ls -t *iOS* | head -1)

TMP_ANDROID=./tmp_android
TMP_IOS=./tmp_ios

# Cleanup
rm -rf tmp_*

# Copy Android dependencies
unzip $PACKAGE_ANDROID -d $TMP_ANDROID
cp $TMP_ANDROID/lib/GlympseApi/GlympseApi-release.aar ../MAUI/source/EnRouteApi.Android.MAUI/Libs/GlympseApi-release.aar
cp $TMP_ANDROID/lib/GlympseApiPush/GlympseApiPush-release.aar ../MAUI/source/EnRouteApi.Android.MAUI/Libs/GlympseApiPush-release.aar
cp $TMP_ANDROID/lib/GlympseApiToolbox/GlympseApiToolbox-release.aar ../MAUI/source/EnRouteApi.Android.MAUI/Libs/GlympseApiToolbox-release.aar
cp $TMP_ANDROID/lib/EnRouteApi/EnRouteApi-release.aar ../MAUI/source/EnRouteApi.Android.MAUI/Libs/EnRouteApi-release.aar

# Copy iOS dependencies
unzip $PACKAGE_IOS -d $TMP_IOS
cp -r $TMP_IOS/framework/* ../MAUI/source/EnRouteApi.iOS.MAUI/Libs
