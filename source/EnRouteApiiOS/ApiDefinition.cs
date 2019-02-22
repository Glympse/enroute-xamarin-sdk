using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace Glympse.EnRoute.iOS
{
    /**
     * Core SDK Bindings
     */

    [BaseType (typeof(NSObject))]
    [DisableDefaultCtor]
    interface GlyCommon
    {       
        [Export ("hashCode")]
        int hashCode();       

        [Export ("equals:")]
        bool equals(GlyCommon common);

        [Export ("toString")]
        string toString();
    }

    [BaseType (typeof(GlyCommon))]
    [DisableDefaultCtor]
    interface GlyArray
    {        
        [Export ("count")]
        int count();

        [Export ("objectAtIndex:")]
        GlyCommon objectAtIndex(int index);
    }

    [BaseType (typeof(GlyCommon))]
    [DisableDefaultCtor]
    interface GlyPrimitive
    {        
        [Export ("type")]
        int type();   

        [Export ("isArray")]
        bool isArray();

        [Export ("isObject")]
        bool isObject();

        [Export ("isDouble")]
        bool isDouble();

        [Export ("isLong")]
        bool isLong();

        [Export ("isBool")]
        bool isBool();

        [Export ("isString")]
        bool isString();

        [Export ("isNull")]
        bool isNull();

        [Export ("size")]
        int size();

        [Export ("clone")]
        GlyCommon clone();

        [Export ("merge:overrideTarget:")]
        bool merge(GlyPrimitive from, bool overrideTarget);

        [Export ("getDouble")]
        double getDouble();

        [Export ("getLong")]
        long getLong();

        [Export ("getBool")]
        bool getBool();

        [Export ("getString")]
        string getString();

        [Export ("getWithNSString:")]
        GlyCommon get(string key);

        [Export ("getDoubleWithNSString:")]
        double getDouble(string key);

        [Export ("getLongWithNSString:")]
        long getLong(string key);

        [Export ("getBoolWithNSString:")]
        bool getBool(string key);

        [Export ("getStringWithNSString:")]
        string getString(string key);

        [Export ("hasKey:")]
        bool hasKey(string key);    

        [Export ("getArray")]
        GlyCommon getArray();

        [Export ("getWithInt:")]
        GlyCommon get(int index);

        [Export ("getDoubleWithInt:")]
        double getDouble(int index);

        [Export ("getLongWithInt:")]
        long getLong(int index);

        [Export ("getBoolWithInt:")]
        bool getBool(int index);

        [Export ("getStringWithInt:")]
        string getString(int index);

        [Export ("setWithDouble:")]
        void set(double value);

        [Export ("setWithLong:")]
        void set(long value);

        [Export ("setWithBool:")]
        void set(bool value);

        [Export ("setWithNSString:")]
        void set(string value);

        [Export ("setNull")]
        void setNull();

        [Export ("setArray")]
        void setArray();

        [Export ("setObject")]
        void setObject();

        [Export ("putWithNSString:withGlyPrimitive:")]
        void put(string key, GlyPrimitive value);

        [Export ("putWithNSString:withDouble:")]
        void put(string key, double value);

        [Export ("putWithNSString:withLongLongInt:")]
        void put(string key, long value);

        [Export ("putWithNSString:withBool:")]
        void put(string key, bool value);

        [Export ("putWithNSString:withNSString:")]
        void put(string key, string value);

        [Export ("putNullWithNSString:")]
        void putNull(string key);

        [Export ("removeWithNSString:")]
        void remove(string key);

        [Export ("putWithGlyPrimitive:")]
        void put(GlyPrimitive value);

        [Export ("putWithDouble:")]
        void put(double value);

        [Export ("putWithLongLongInt:")]
        void put(long value);

        [Export ("putWithBool:")]
        void put(bool value);

        [Export ("putWithNSString:")]
        void put(string value);

        [Export ("insert:value:")]
        void insert(int index, GlyPrimitive value);

        [Export ("putWithInt:withGlyPrimitive:")]
        void putWithInt(int index, GlyPrimitive value);

        [Export ("putWithInt:withDouble:")]
        void put(int index, double value);

        [Export ("putWithInt:withLongLongInt:")]
        void put(int index, long value);

        [Export ("putWithInt:withBool:")]
        void put(int index, bool value);

        [Export ("putWithInt:withNSString:")]
        void put(int index, string value);

        [Export ("putNullWithInt:")]
        void putNull(int index);

        [Export ("removeWithInt:")]
        void remove(int index);

        [Export ("removeWithGlyPrimitive:")]
        void remove(GlyPrimitive value);
    }

    [BaseType(typeof(GlyCommon))]
    [DisableDefaultCtor]
    interface GlyLong
    {
        [Export("longValue")]
        long longValue();
    }

    [BaseType (typeof(NSObject))]
    [Model]
    interface GlyListener
    {
        [Export ("eventsOccurred:listener:events:param1:param2:")]
        void eventsOccurred(GlySource source, int listener, int events, GlyCommon param1, GlyCommon param2);
    }       

    [BaseType (typeof(NSObject))]
    [Model]
    interface GlySource
    {               
        [Export ("addListener:")]
        bool addListener(GlyListener listener);

        [Export ("removeListener:")]
        bool removeListener(GlyListener listener);
    } 
        
    /**
     * EnRoute SDK Bindings
     */

    [BaseType (typeof(GlyCommon))]
    [DisableDefaultCtor]
    interface GlyOrganization
    {        
        [Export ("getId")]
        long getId();

        [Export ("getName")]
        string getName();

        [Export ("getAdminEmail")]
        string getAdminEmail();        
    }

    [BaseType (typeof(GlyCommon))]
    [DisableDefaultCtor]
    interface GlyAgent
    {        
        [Export ("getId")]
        long getId();

        [Export ("getName")]
        string getName();

        [Export ("getEmail")]
        string getEmail();        
    }
        
    [BaseType (typeof(GlyCommon))]
    [DisableDefaultCtor]
    interface GlyTask
    {        
        [Export ("getState")]
        int getState();

        [Export ("getId")]
        long getId();

        [Export ("getOperation")]
        GlyOperation getOperation();

        [Export ("getDescription")]
        string getDescription();

        [Export ("getDueTime")]
        long getDueTime();

        [Export("getPhase")]
        string getPhase();

        [Export ("getForeignId")]
        string getForeignId();   
    }

    [BaseType (typeof(GlyCommon))]
    [DisableDefaultCtor]
    interface GlyOperation
    {        
        [Export ("getState")]
        int getState();   

        [Export ("getId")]
        long getId();

        [Export ("getStartTime")]
        long getStartTime();

        [Export ("getTicketId")]
        string getTicketId();

        [Export ("getInviteUrl")]
        string getInviteUrl();

        [Export ("getInviteCode")]
        string getInviteCode();

        [Export ("getTaskId")]
        long getTaskId();

        [Export ("setTicketEta:")]
        void setTicketEta(long eta);   
    }

    [BaseType (typeof(GlySource))]
    [DisableDefaultCtor]
    interface GlyTaskManager
    {     
        [Export ("getTasks")]
        GlyArray getTasks();

        [Export ("getPendingTasks")]
        GlyArray getPendingTasks();

        [Export ("getActiveOperations")]
        GlyArray getActiveOperations();

        [Export ("findTaskById:")]
        GlyTask findTaskById(long id);

        [Export ("startTaskWithGlyTask:")]
        bool startTask(GlyTask task);

        [Export ("setTaskPhase:phase:")]
        bool setTaskPhase(GlyTask task, string phase);

        [Export ("completeOperation:")]
        bool completeOperation(GlyOperation operation);        

        [Export ("addListener:")]
        bool addListener(GlyListener listener);

        [Export ("removeListener:")]
        bool removeListener(GlyListener listener);
    }
        
    [BaseType (typeof(GlySource))]
    [DisableDefaultCtor]
    interface GlyEnRouteManager
    {
        [Export ("isLoginNeeded")]
        bool isLoginNeeded();

        [Export ("loginWithCredentials:password:")]
        bool loginWithCredentials(string username, string password);

        [Export("loginWithToken:expireTime:")]
        bool loginWithToken(string token, long expireTime);

        [Export ("logout:")]
        void logout(int reason);

        [Export ("start")]
        bool start();

        [Export ("stop")]
        void stop();

        [Export ("isStarted")]
        bool isStarted();

        [Export ("setActive:")]
        void setActive(bool active);

        [Export ("isActive")]
        bool isActive();

        [Export("setAuthenticationMode:")]
        void setAuthenticationMode(int authMode);

        [Export("getAuthenticationMode")]
        int getAuthenticationMode();

        [Export ("refresh")]
        void refresh();

        [Export ("getOrganization")]
        GlyOrganization getOrganization();

        [Export ("getLoggedInAgent")]
        GlyAgent getLoggedInAgent();

        [Export ("getEnRouteToken")]
        string getEnRouteToken();

        [Export ("getTaskManager")]
        GlyTaskManager getTaskManager();

        [Export ("addListener:")]
        bool addListener(GlyListener listener);

        [Export ("removeListener:")]
        bool removeListener(GlyListener listener);
        
        [Export ("handleRemoteNotification:")]
        void handleRemoteNotification(string payload);
        
        [Export ("registerDeviceToken:deviceToken:")]
        void registerDeviceToken(string tokenType, string deviceToken);

        [Export("overrideLoggingLevels:debugLogLevel:")]
        void overrideLoggingLevels(int fileLevel, int debugLevel);
    }
        
    [BaseType (typeof(NSObject))]
    [DisableDefaultCtor]
    interface GlyEnRouteFactory
    {        
        [Static]
        [Export ("createEnRouteManager")]
        GlyEnRouteManager createEnRouteManager();       
    }
}

