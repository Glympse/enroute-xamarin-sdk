import sys, time, re, subprocess, datetime, os

# Check arguments
if ( len(sys.argv) < 5 ):
    print("usage: ./generate_package_file.py version file_dst package_file product_name")
    exit(1)

# Extract argumensts
version_str = sys.argv[1]
file_dst = sys.argv[2]
package_file = sys.argv[3]
product_name = sys.argv[4]
params = {}

version = version_str.split('.', 3)

# Extract version
ver_major = version[0]
ver_minor = version[1]
ver_build = version[2]
ver_bugfix = 0
ver_status = 'release'
ver_iter = 0
params["BUILD_VERSION_SHORT"] = ver_major + "." + ver_minor + "." + ver_build
params["BUILD_VERSION_FULL"] = params["BUILD_VERSION_SHORT"]
if 0 != int(ver_bugfix):
    params["BUILD_VERSION_FULL"] = params["BUILD_VERSION_FULL"] + "." + ver_bugfix 
if "none" != ver_status and "release" != ver_status:
    params["BUILD_VERSION_FULL"] = params["BUILD_VERSION_FULL"] + "." + ver_status 
    if 0 != int(ver_iter):
        params["BUILD_VERSION_FULL"] = params["BUILD_VERSION_FULL"] + "." + ver_iter 

params["BUILD_VERSION_RESOURCE"] = params["BUILD_VERSION_FULL"]

# Extract commit hash
params["TAG_LONG"] = subprocess.Popen(["git", "rev-parse", "HEAD"], stdout=subprocess.PIPE).communicate()[0].decode('utf-8').rstrip("\n")

# Extract year
params["YEAR_FULL"] = str(datetime.date.today().year)

# Extract time
params["BUILD_TIME"] = str(int(time.time() * 1000))

#Extract build package
params["PACKAGE_FILE"] = package_file

params["PRODUCT_NAME"] = product_name

# Read template 
file = open("./templates/package.json", "r")
template = file.read()
file.close()

# Paste params
for param in params:
    template = template.replace(param, params[param])

# Save prepared file
file = open(os.path.join(file_dst, "package.json"), "w")
file.write(template) 
file.close()

# Return short SDK version
print(params["BUILD_VERSION_SHORT"])