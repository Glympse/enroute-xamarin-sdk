#!/usr/bin/python
#
# Downloads the latest Native En Route SDKs
#
# Usage:
# python fetch_native_sdks.py s3_bucket
#

import json
import sys
import urllib2
from pprint import pprint

def downloadFile(url):
	r = urllib2.urlopen(url)
	CHUNK_SIZE = 1 << 20
	with open(sdkFile, 'wb') as f:
	    while True:
	        chunk = r.read(CHUNK_SIZE)
	        if not chunk:
	            break
	        f.write(chunk)

def fetchPackageData(url):
	response = urllib2.urlopen(url)
	data = json.load(response)

	build = data["resource"]["build"]
	sdkFile = data["resource"]["package_file"]
	return build, sdkFile

bucketName = sys.argv[1]

baseUrl = "https://" + bucketName + ".s3.amazonaws.com/enroute/client-sdk/downloads/"
platforms = ["android", "ios"]

for platform in platforms:
	print "Downloading " + platform + " package information"
	packageUrl = baseUrl + platform + "/package.json"
	build, sdkFile = fetchPackageData(packageUrl)
	sdkUrl = baseUrl + platform + "/" + build + "/" + sdkFile
	print "Downloading " + sdkFile
	downloadFile(sdkUrl)
print "Done"