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

        [Export ("getDouble")]
        double getDouble();

        [Export ("getLong")]
        long getLong();

        [Export ("getBool")]
        bool getBool();

        [Export ("getString")]
        string getString();

        [Export ("get:")]
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

        [Export ("getArray:")]
        GlyCommon getArray();

        [Export ("get:")]
        GlyCommon get(int index);

        [Export ("getDouble")]
        double getDouble(int index);

        [Export ("getLong")]
        long getLong(int index);

        [Export ("getBool")]
        bool getBool(int index);

        [Export ("getString")]
        string getString(int index);

        [Export ("set")]
        void set(double value);

        [Export ("set")]
        void set(long value);

        [Export ("set")]
        void set(bool value);

        [Export ("set")]
        void set(string value);

        [Export ("setNull")]
        void setNull();

        [Export ("setArray")]
        void setArray();

        [Export ("setObject")]
        void setObject();

        [Export ("put")]
        void put(string key, double value);

        [Export ("put")]
        void put(string key, long value);

        [Export ("put")]
        void put(string key, bool value);

        [Export ("put")]
        void put(string key, string value);

        [Export ("putNull")]
        void putNull(string key);

        [Export ("remove")]
        void remove(string key);

        [Export ("put")]
        void put(double value);

        [Export ("put")]
        void put(long value);

        [Export ("put")]
        void put(bool value);

        [Export ("put")]
        void put(string value);

        [Export ("put")]
        void put(int index, double value);

        [Export ("put")]
        void put(int index, long value);

        [Export ("put")]
        void put(int index, bool value);

        [Export ("put")]
        void put(int index, string value);

        [Export ("putNull")]
        void putNull(int index);

        [Export ("remove")]
        void remove(int index);
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

        [Export ("getTicketPhase")]
        string getTicketPhase();

        [Export ("getPhase")]
        string getPhase();        
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

        [Export ("setOperationPhase:phase:")]
        bool setOperationPhase(GlyOperation operation, string phase);

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

        [Export ("login:password:")]
        bool login(string username, string password);

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

