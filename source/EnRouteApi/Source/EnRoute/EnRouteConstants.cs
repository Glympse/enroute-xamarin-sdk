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
    public const int TASK_STATE_CREATED = 1;
    public const int TASK_STATE_STARTING = 2;
    public const int TASK_STATE_STARTED = 3;
    public const int TASK_STATE_FAILED_TO_START = 4;
    public const int TASK_STATE_COMPLETED = 5;
    
    public const int OPERATION_STATE_ACTIVE = 1;
    public const int OPERATION_STATE_COMPLETING = 2;
    public const int OPERATION_STATE_COMPLETE = 3;
    public const int OPERATION_STATE_FAILED_TO_COMPLETE = 4;
    
    public const int LOGOUT_REASON_UNKNOWN = 0;
    public const int LOGOUT_REASON_USER_ACTION = 1;
    public const int LOGOUT_REASON_OLD_VERSION = 2;
    public const int LOGOUT_REASON_INVALID_CREDENTIALS = 3;
    public const int LOGOUT_REASON_INVALID_TOKEN = 4;
    public const int LOGOUT_REASON_LOCATION_SERVICES_UNAVAILABLE = 5;
    public const int LOGOUT_REASON_SERVER_ERROR = 6;

    public const int TICKET_EXTEND_CHECK = 300000;
    public const int TICKET_EXTEND_CUTOFF = 3600000;
    public const int TICKET_EXTEND_LENGTH = 14400000;
    
    public const long MINIMUM_MANUAL_ETA = 300000;
    
    public const int INDEX_BEFORE = -2;
    public const int INDEX_AFTER = -1;
    
    public const int SESSION_STATE_UNKNOWN = 0;
    public const int SESSION_STATE_CREATED = 1;
    public const int SESSION_STATE_STARTING = 2;
    public const int SESSION_STATE_STARTED = 3;
    public const int SESSION_STATE_FAILED_TO_START = 4;
    public const int SESSION_STATE_FINISHED = 5;
    
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
    public static String PHASE_PROPERTY_COMPLETED()
    {
        return CoreFactory.createString("completed");
    }
    public static String PHASE_PROPERTY_NOT_COMPLETED()
    {
        return CoreFactory.createString("not_completed");
    }
};
    
}
}

