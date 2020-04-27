//------------------------------------------------------------------------------
//
// Copyright (c) 2014 Glympse Inc.  All rights reserved.
//
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Glympse
{
namespace EnRoute
{
        
/*O*/public/**/ class EnRouteConstants
{
    /**
     * @name Authentication modes
     */
    
    public const int AUTH_MODE_NONE = 0;
    public const int AUTH_MODE_CREDENTIALS = 1;
    public const int AUTH_MODE_TOKEN = 2;
    
    /**
     * @name Task states
     */
    
    public const int TASK_STATE_CREATED = 1;
    public const int TASK_STATE_STARTING = 2;
    public const int TASK_STATE_STARTED = 3;
    public const int TASK_STATE_FAILED_TO_START = 4;
    public const int TASK_STATE_COMPLETED = 5;
    
    /**
     * @name Operation states
     */
    
    public const int OPERATION_STATE_ACTIVE = 1;
    public const int OPERATION_STATE_COMPLETING = 2;
    public const int OPERATION_STATE_COMPLETE = 3;
    public const int OPERATION_STATE_FAILED_TO_COMPLETE = 4;
    
    /**
     * @name Logout reasons
     */
    
    public const int LOGOUT_REASON_UNKNOWN = 0;
    public const int LOGOUT_REASON_USER_ACTION = 1;
    public const int LOGOUT_REASON_OLD_VERSION = 2;
    public const int LOGOUT_REASON_INVALID_CREDENTIALS = 3;
    public const int LOGOUT_REASON_INVALID_TOKEN = 4;
    public const int LOGOUT_REASON_LOCATION_SERVICES_UNAVAILABLE = 5;
    public const int LOGOUT_REASON_SERVER_ERROR = 6;
    
    /**
     * @name Session completion reasons
     */
    
    /**
     * Completion reason for when a session is completed for an unknown reason.
     */
    public const int SESSION_COMPLETION_REASON_UNKNOWN = 0x00000000;
    
    /**
     * Completion reason for when a session is completed due to a geofence trigger.
     */
    public const int SESSION_COMPLETION_REASON_GEOFENCE = 0x00000001;
    
    /**
     * Completion reason for when a session is completed due to manual user action.
     */
    public const int SESSION_COMPLETION_REASON_USER_ACTION = 0x00000002;
    
    /**
     * @name Ticket extension constants
     */

    public const int TICKET_EXTEND_CHECK = 300000;
    public const int TICKET_EXTEND_CUTOFF = 3600000;
    public const int TICKET_EXTEND_LENGTH = 14400000;
    
    /**
     * @name ETA constants
     */
    
    public const long MINIMUM_MANUAL_ETA = 300000;
    
    /**
     * @name Diagnostics constants
     */
    
    public const int DIAGNOSTICS_COLLECTOR_MAX_CAPACITY = 200;
    public const int DIAGNOSTICS_COLLECTOR_UPLOAD_DELAY_MS = 5000;
    
    /**
     * @name Index constants
     *
     * Used to keep track of indices of stages when the active stage index is outside the normal range.
     */
    
    public const int INDEX_BEFORE = -2;
    public const int INDEX_AFTER = -1;
    
    /**
     * @name Session states
     */
    
    public const int SESSION_STATE_UNKNOWN = 0;
    public const int SESSION_STATE_CREATED = 1;
    public const int SESSION_STATE_STARTING = 2;
    public const int SESSION_STATE_STARTED = 3;
    public const int SESSION_STATE_COMPLETING = 4;
    public const int SESSION_STATE_COMPLETED = 5;
    
    /**
     * @name Batch constants
     */
    
    public const int BATCH_MAXIMUM_ENDPOINTS = 16;
    
    /**
     * @name Completed Pickup Keep Threshold
     * Pickups older than this value should be discarded
     * Value is 48 hours in ms
     */
    
    public const long PICKUP_COMPLETED_KEEP_THRESHOLD_MS = 172800000;
    
    /**
     * @name Phase properties
     */
    
    public static String PHASE_PROPERTY_KEY()
    {
        return CoreFactory.createString("phase");
    }
    public static String PHASE_PROPERTY_UNKNOWN()
    {
        return CoreFactory.createString("unknown");
    }
    public static String PHASE_PROPERTY_PRE()
    {
        return CoreFactory.createString("pre");
    }
    public static String PHASE_PROPERTY_ETA()
    {
        return CoreFactory.createString("eta");
    }
    public static String PHASE_PROPERTY_NEW()
    {
        return CoreFactory.createString("new");
    }
    public static String PHASE_PROPERTY_LIVE()
    {
        return CoreFactory.createString("live");
    }
    public static String PHASE_PROPERTY_ARRIVED()
    {
        return CoreFactory.createString("arrived");
    }
    public static String PHASE_PROPERTY_FEEDBACK()
    {
        return CoreFactory.createString("feedback");
    }
    public static String PHASE_PROPERTY_COMPLETING()
    {
        return CoreFactory.createString("completing");
    }
    public static String PHASE_PROPERTY_COMPLETED()
    {
        return CoreFactory.createString("completed");
    }
    public static String PHASE_PROPERTY_NOT_COMPLETED()
    {
        return CoreFactory.createString("not_completed");
    }
    public static String PHASE_PROPERTY_CANCELLED()
    {
        return CoreFactory.createString("cancelled");
    }
    public static String PHASE_PROPERTY_READY()
    {
        return CoreFactory.createString("ready");
    }
    
    /**
     * @name Pickup remote trigger names
     */
    public static String PICKUP_TRIGGER_GEOFENCE()
    {
        return CoreFactory.createString("pickup_geocircle");
    }
    public static String PICKUP_TRIGGER_ETA()
    {
        return CoreFactory.createString("pickup_eta");
    }
    
    /**
     * @name Session control modes
     */
    public static String SESSION_CONTROL_MODE_MANUAL()
    {
        return CoreFactory.createString("manual");
    }
    
    public static String SESSION_CONTROL_MODE_SHUTTLE_SERVICE()
    {
        return CoreFactory.createString("sdk_shuttle_service");
    }
    
    public static String SESSION_CONTROL_MODE_FOOD_DELIVERY()
    {
        return CoreFactory.createString("sdk_food_delivery");
    }
    
    /**
     * @name Travel modes
     */
    public static String TRAVEL_MODE_DRIVING()
    {
        return CoreFactory.createString("drive");
    }
    
    public static String TRAVEL_MODE_WALKING()
    {
        return CoreFactory.createString("walk");
    }
    
    public static String TRAVEL_MODE_TRANSIT()
    {
        return CoreFactory.createString("transit");
    }
    
    public static String TRAVEL_MODE_BICYCLE()
    {
        return CoreFactory.createString("cycle");
    }
    
};
    
}
}

