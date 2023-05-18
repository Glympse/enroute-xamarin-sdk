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

    [BaseType(typeof(GlyCommon))]
    [Model]
    interface GlyEventListener
    {
        [Export("eventsOccurred:listener:events:object:")]
        void eventsOccurred(GlyGlympse glympse, int listener, int events, GlyCommon param);
    }

    [BaseType(typeof(GlyCommon))]
    [Model]
    interface GlyEventSink
    {
        [Export("addListener:")]
        bool addListener(GlyEventListener listener);

        [Export("removeListener:")]
        bool removeListener(GlyEventListener listener);
    }

    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface GlyCoreFactory
    {
        [Static]
        [Export("createPrimitiveWithNSString:")]
        GlyPrimitive createPrimitive(string str);
    }

    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface GlyGlympse
    {
        [Export("start")]
        void start();

        [Export("stop")]
        void stop();

        [Export("isStarted")]
        bool isStarted();

        [Export("getUserManager")]
        GlyUserManager getUserManager();

        [Export("getDirectionsManager")]
        GlyDirectionsManager getDirectionsManager();

        [Export("getConsentManager")]
        GlyConsentManager getConsentManager();

        [Export("getCustomerPickupManager")]
        GlyCustomerPickupManager getCustomerPickupManager();

        [Export("sendTicket:")]
        bool sendTicket(GlyTicket ticket);

        [Export("getSmsSendMode")]
        int getSmsSendMode();

        [Export("setSmsSendMode:")]
        void setSmsSendMode(int mode);

        [Export("canDeviceSendSms")]
        int canDeviceSendSms();

        [Export("getEtaMode")]
        int getEtaMode();

        [Export("setEtaMode:")]
        void setEtaMode(int mode);

        [Export("getApiVersion")]
        string getApiVersion();

        [Export("overrideLoggingLevels:debugLevel:")]
        void overrideLoggingLevels(int fileLevel, int debugLevel);

        [Export("getConfig")]
        GlyConfig getConfig();
    }

    [BaseType(typeof(GlyCommon))]
    [DisableDefaultCtor]
    interface GlyPlace
    {

    }

    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface GlyInvite
    {
        [Export("getAddress")]
        string getAddress();

        [Export("getType")]
        int getType();
    }

    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface GlyTicket
    {
        [Export("appendData:name:value:")]
        bool appendData(long partnerId, string name, GlyPrimitive value);

        [Export("addInvite:")]
        bool addInvite(GlyInvite invite);

        [Export("expire")]
        bool expire();

        [Export("extend:")]
        bool extend(long interval);

        [Export("getDuration")]
        long getDuration();

        [Export("getEta")]
        long getEta();

        [Export("getId")]
        string getId();

        [Export("getInvites")]
        GlyArray getInvites();

        [Export("modify:message:destination:")]
        bool modify(long remaining, string message, GlyPlace destination);

        [Export("updateEta:")]
        void updateEta(long eta);
    }

    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface GlyConfig
    {
        [Export("setActiveSharingNotificationMessage:")]
        void setActiveSharingNotificationMessage(string message);

        [Export("setExpireOnArrival:")]
        void setExpireOnArrival(int mode);
    }

    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface GlyGlympseFactory
    {
        [Static]
        [Export("createGlympseWithNSString:withNSString:")]
        GlyGlympse createGlympse(string server, string apiKey);

        [Static]
        [Export("createInviteWithInt:withNSString:withNSString:")]
        GlyInvite createInvite(int type, string name, string address);

        [Static]
        [Export("createPlace:longitude:name:")]
        GlyPlace createPlace(double latitude, double longitude, string name);

        [Static]
        [Export("createTicket:message:destination:")]
        GlyTicket createTicket(long duration, string message, GlyPlace destination);

        [Static]
        [Export("createPickupArrivalDataBuilder")]
        GlyPickupArrivalDataBuilder createPickupArrivalDataBuilder();
    }

    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface GlyConsentManager
    {
        [Export("exemptFromConsent:")]
        void exemptFromConsent(bool isExempt);
    }

    [BaseType(typeof(GlyEventSink))]
    [DisableDefaultCtor]
    interface GlyChatManager
    {
        [Export("getChatRoom:")]
        GlyChatRoom getChatRoom(string roomId);

        [Export("setRoomAsRead:")]
        void setRoomAsRead(string roomId);

        [Export("addListener:")]
        bool addListener(GlyEventListener listener);

        [Export("removeListener:")]
        bool removeListener(GlyEventListener listener);
    }

    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface GlyChatRoom
    {
        [Export("getName")]
        string getName();

        [Export("getChatMessages")]
        GlyArray getChatMessages();

        [Export("getSequenceNumber")]
        long getSequenceNumber();

        [Export("getLastReadSequenceNumber")]
        long getLastReadSequenceNumber();
    }

    [BaseType(typeof(GlyEventSink))]
    [DisableDefaultCtor]
    interface GlyCustomerPickupManager
    {
        [Export("setInviteCode:")]
        void setInviteCode(string inviteCode);

        [Export("setForeignId:")]
        void setForeignId(string foreignId);

        [Export("setManualETA:")]
        bool setManualETA(long eta);

        [Export("arrived")]
        bool arrived();

        [Export("holdPickup")]
        bool holdPickup();

        [Export("sendArrivalData:")]
        bool sendArrivalData(GlyPickupArrivalData arrivalData);

        [Export("sendFeedback:customerComment:canContactCustomer:")]
        bool sendFeedback(int customerRating, string customerComment, bool canContactCustomer);

        [Export("getCurrentPickup")]
        GlyCustomerPickup getCurrentPickup();

        [Export("sendChatMessage:")]
        bool sendChatMessage(string message);

        [Export("getChatMessages")]
        GlyArray getChatMessages();

        [Export("addListener:")]
        bool addListener(GlyEventListener listener);

        [Export("removeListener:")]
        bool removeListener(GlyEventListener listener);
    }

    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface GlyCustomerPickup
    {
        [Export("getId")]
        string getId();

        [Export("getInviteCode")]
        string getInviteCode();

        [Export("getCreatedTime")]
        long getCreatedTime();

        [Export("getDueTime")]
        long getDueTime();

        [Export("getCompletedTime")]
        long getCompletedTime();

        [Export("getArrivedTime")]
        long getArrivedTime();

        [Export("getPhase")]
        string getPhase();

        [Export("getForeignId")]
        string getForeignId();

        [Export("getMetadata")]
        GlyArray getMetadata();

        [Export("getCustomerArrivalData")]
        GlyPickupArrivalData getCustomerArrivalData();

        [Export("getManualEta")]
        long getManualEta();

        [Export("getChatRoomId")]
        string getChatRoomId();

        [Export("getNotes")]
        string getNotes();

        [Export("getChatEnabledPhases")]
        GlyArray getChatEnabledPhases();
    }

    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface GlyPickupArrivalData
    {
        [Export("getStallLabel")]
        string getStallLabel();

        [Export("getLicensePlate")]
        string getLicensePlate();

        [Export("getCarMake")]
        string getCarMake();

        [Export("getCarModel")]
        string getCarModel();

        [Export("getCarColor")]
        string getCarColor();

        [Export("isPickupInStore")]
        bool isPickupInStore();
    }

    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface GlyPickupArrivalDataBuilder
    {
        [Export("setStallLabel:")]
        void setStallLabel(string stallLabel);

        [Export("setLicensePlate:")]
        void setLicensePlate(string licensePlate);

        [Export("setCarMake:")]
        void setCarMake(string carMake);

        [Export("setCarModel:")]
        void setCarModel(string carModel);

        [Export("setCarColor:")]
        void setCarColor(string carColor);

        [Export("setPickupInStore:")]
        void setPickupInStore(bool isPickupInStore);

        [Export("getPickupArrivalData")]
        GlyPickupArrivalData getPickupArrivalData();
    }

    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface GlyChatMessage
    {
        [Export("getId")]
        long getId();

        [Export("getCreatedTime")]
        long getCreatedTime();

        [Export("getContents")]
        string getContents();

        [Export("getAuthor")]
        string getAuthor();

        [Export("getSequenceId")]
        long getSequenceId();
    }

        [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface GlyDirectionsManager
    {
        [Export("setTravelMode:")]
        void setTravelMode(int mode);
    }

    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface GlyUserManager
    {
        [Export("getSelf")]
        GlyUser getSelf();
    }

    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface GlyUser
    {
        [Export("setNickname:")]
        bool setNickname(string nickname);

        [Export("getNickname")]
        string getNickname();
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

        [Export("getChatRoomId")]
        string getChatRoomId();
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

        [Export("setTicketVisible:")]
        void setTicketVisible(string visible);
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

        [Export ("completeOperationWithGlyOperation:")]
        bool completeOperation(GlyOperation operation);

        [Export ("completeOperationWithGlyOperation:withInt:")]
        bool completeOperation(GlyOperation operation, int reasonCode);

        [Export("setTravelModeForTask:travelMode:")]
        void setTravelModeForTask(GlyTask task, string travelMode);

        [Export("getTravelModeForTask:")]
        string getTravelModeForTask(GlyTask task);

        [Export("sendMessage:message:")]
        bool sendMessage(GlyTask task, string message);

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

        [Export("enableXoANotifications:")]
        void enableXoANotifications(bool enabled);
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

