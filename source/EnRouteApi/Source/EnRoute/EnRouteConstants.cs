//------------------------------------------------------------------------------
//
// Copyright (c) 2014 Glympse Inc.  All rights reserved.
//
//------------------------------------------------------------------------------

namespace Glympse
{
    namespace EnRoute
    {
            
        /*O*/public abstract /**/ class EnRouteConstants
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
            public const int LOGOUT_REASON_INVALID_SUBSCRIPTION = 7;
            public const int LOGOUT_REASON_APP_FLAVOR_MISMATCH = 8;
            
            /**
             * @name Task completion reasons
             */
            public const int TASK_COMPLETE_REASON_UNKNOWN = 0;
            public const int TASK_COMPLETE_REASON_MANUAL_ARRIVAL = 1;
            public const int TASK_COMPLETE_REASON_ARRIVAL_DETECTED = 2;
            public const int TASK_COMPLETE_REASON_CANCELLED = 3;
            public const int TASK_COMPLETE_REASON_TICKET_EXPIRED = 4;
            public const int TASK_COMPLETE_REASON_TASK_REMOVED = 5;
            
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
             * @name Minimum auto refresh period
             */
            public const int MINIMUM_AUTO_REFRESH_PERIOD = 10000;
            
            /**
             * @name Completed Pickup Keep Threshold
             * Pickups older than this value should be discarded
             * Value is 48 hours in ms
             */
            
            public const long PICKUP_COMPLETED_KEEP_THRESHOLD_MS = 172800000;
            
            /**
             * @name Completed Task Keep Threshold
             * Tasks older than this value should be discarded
             * Value is 48 hours in ms
             */
            
            public const long TASK_COMPLETED_KEEP_THRESHOLD_MS = 172800000;
            
            /**
             * @name Phase properties
             */
            
            public static string PHASE_PROPERTY_KEY() => 
                CoreFactory.createString("phase");

            public static string PHASE_PROPERTY_UNKNOWN() => 
                CoreFactory.createString("unknown");

            public static string PHASE_PROPERTY_PRE() => 
                CoreFactory.createString("pre");

            public static string PHASE_PROPERTY_ETA() => 
                CoreFactory.createString("eta");

            public static string PHASE_PROPERTY_NEW() => 
                CoreFactory.createString("new");

            public static string PHASE_PROPERTY_LIVE() => 
                CoreFactory.createString("live");

            public static string PHASE_PROPERTY_ARRIVED() => 
                CoreFactory.createString("arrived");

            public static string PHASE_PROPERTY_FEEDBACK() => 
                CoreFactory.createString("feedback");

            public static string PHASE_PROPERTY_COMPLETING() => 
                CoreFactory.createString("completing");

            public static string PHASE_PROPERTY_COMPLETED() => 
                CoreFactory.createString("completed");

            public static string PHASE_PROPERTY_NOT_COMPLETED() => 
                CoreFactory.createString("not_completed");

            public static string PHASE_PROPERTY_CANCELLED() => 
                CoreFactory.createString("cancelled");

            public static string PHASE_PROPERTY_READY() => 
                CoreFactory.createString("ready");

            /**
             * @name Pickup remote trigger names
             */
            public static string PICKUP_TRIGGER_GEOFENCE() => 
                CoreFactory.createString("pickup_geocircle");

            public static string PICKUP_TRIGGER_ETA() => 
                CoreFactory.createString("pickup_eta");

            /**
             * @name Session control modes
             */
            public static string SESSION_CONTROL_MODE_MANUAL() => 
                CoreFactory.createString("manual");

            public static string SESSION_CONTROL_MODE_SHUTTLE_SERVICE() => 
                CoreFactory.createString("sdk_shuttle_service");

            public static string SESSION_CONTROL_MODE_FOOD_DELIVERY() => 
                CoreFactory.createString("sdk_food_delivery");

            /**
             * @name Travel modes
             */
            public static string TRAVEL_MODE_DRIVING() => 
                CoreFactory.createString("drive");

            public static string TRAVEL_MODE_WALKING() => 
                CoreFactory.createString("walk");

            public static string TRAVEL_MODE_TRANSIT() => 
                CoreFactory.createString("transit");

            public static string TRAVEL_MODE_BICYCLE() => 
                CoreFactory.createString("cycle");

            /**
             * @name Confirmation Image modes
             */
            public static string CONFIRMATION_IMAGE_NONE() => 
                CoreFactory.createString("none");

            public static string CONFIRMATION_IMAGE_SIGNATURE() => 
                CoreFactory.createString("signature");

            public static string CONFIRMATION_IMAGE_PHOTO() => 
                CoreFactory.createString("photo");
        }
    }
}