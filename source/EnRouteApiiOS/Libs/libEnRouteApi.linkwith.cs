using ObjCRuntime;

[assembly: LinkWith ( SmartLink = true, ForceLoad = true, LinkerFlags = "-ObjC -lc++ -lz",
Frameworks = "CoreMotion SystemConfiguration EventKit Security AddressBook MessageUI CFNetwork CoreLocation" )]
