using ObjCRuntime;

[assembly: LinkWith ( "libEnRouteApi.a", SmartLink = true, ForceLoad = true, LinkerFlags = "-ObjC -lc++ -lz",
Frameworks = "CoreMotion SystemConfiguration EventKit Security AddressBook MessageUI CFNetwork CoreLocation" )]
