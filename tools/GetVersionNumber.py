#!/usr/bin/python
#
# Gets version number from config file
#
# Usage:
# ./GeneratePackageFile.py version_header
#

import sys, time, re, subprocess, datetime

# Check arguments
if ( len(sys.argv) < 2 ):
    print("usage: ./GeneratePackageFile.py version_header")
    exit(1)

# Extract argumensts
version_header = sys.argv[1]
params = {}

# Extract version from header file
file = open(version_header, "r")
header = file.read()
file.close()

# Extract version
ver_major = re.compile(r'_MAJOR\s=\s( [0-9]* );', re.VERBOSE).findall(header)[0]
ver_minor = re.compile(r'_MINOR\s=\s( [0-9]* );', re.VERBOSE).findall(header)[0]
ver_build = re.compile(r'_BUILD\s=\s( [0-9]* );', re.VERBOSE).findall(header)[0]
params["BUILD_VERSION_SHORT"] = ver_major + "." + ver_minor + "." + ver_build

# Return short SDK version
print(params["BUILD_VERSION_SHORT"])
