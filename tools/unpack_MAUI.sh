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
cp -r $TMP_ANDROID/lib/GlympseApi/ ../MAUI/source/EnRouteApi.Android.MAUI/Libs/
cp -r $TMP_ANDROID/lib/GlympseApiPush/ ../MAUI/source/EnRouteApi.Android.MAUI/Libs/
cp -r $TMP_ANDROID/lib/GlympseApiToolbox/ ../MAUI/source/EnRouteApi.Android.MAUI/Libs/
cp -r $TMP_ANDROID/lib/EnRouteApi/ ../MAUI/source/EnRouteApi.Android.MAUI/Libs/

# Copy iOS dependencies
unzip $PACKAGE_IOS -d $TMP_IOS
cp -r $TMP_IOS/framework/ ../MAUI/source/EnRouteApi.iOS.MAUI/Libs/
