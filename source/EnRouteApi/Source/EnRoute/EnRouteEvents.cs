//------------------------------------------------------------------------------
//
// Copyright (c) 2015 Glympse Inc.  All rights reserved.
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
    
/*O*/public/**/ class EnRouteEvents
{
    /**
     * Listener Constants
     */
    
    public const int LISTENER_AGENTS = 1;
    public const int LISTENER_SESSIONS = 2;
    public const int LISTENER_STAGE_MANAGER = 3;
    public const int LISTENER_ACTIVE_AGENTS = 4;
    public const int LISTENER_ENROUTE_MANAGER = 4;
    public const int LISTENER_TASKS = 5;
    public const int LISTENER_ETA_PLANNER = 6;
    
    /**
     * Event Constants
     */
    
    public const int AGENTS_AGENT_LIST_CHANGED = 0x00000001;
    public const int AGENTS_AGENT_CREATED = 0x00000002;
    public const int AGENTS_AGENT_CREATION_FAILED = 0x00000004;
    public const int AGENTS_AGENT_UPDATED = 0x00000008;
    public const int AGENTS_AGENT_UPDATE_FAILED = 0x000000010;
    
    public const int SESSIONS_SESSION_LIST_CHANGED = 0x00000001;
    public const int SESSIONS_SESSION_STARTED = 0x00000002;
    public const int SESSIONS_SESSION_START_FAILED = 0x00000004;
    public const int SESSIONS_SESSION_COMPLETED = 0x00000008;
    
    public const int STAGE_MANAGER_TASKS_CHANGED = 0x00000001;
    public const int STAGE_MANAGER_STAGE_INDEX_CHANGED = 0x00000002;
    public const int STAGE_MANAGER_TASK_INDEX_CHANGED = 0x00000004;
    public const int STAGE_MANAGER_CURRENT_SESSION_CHANGED = 0x00000008;
        
    public const int ACTIVE_AGENTS_AGENT_LIST_CHANGED = 0x00000001;
    public const int ACTIVE_AGENTS_AGENT_REGISTERED = 0x00000002;
        
    public const int ENROUTE_MANAGER_LOGIN_COMPLETED = 0x00000001;
    public const int ENROUTE_MANAGER_LOGIN_REQUIRED = 0x00000002;
    public const int ENROUTE_MANAGER_LOGGED_OUT = 0x00000004;
    public const int ENROUTE_MANAGER_STARTED = 0x00000008;
    public const int ENROUTE_MANAGER_STOPPED = 0x00000010;
    public const int ENROUTE_MANAGER_SHOW_NOTIFICATION = 0x00000020;
        
    public const int TASKS_TASK_LIST_CHANGED = 0x00000001;
    public const int TASKS_TASK_STARTED = 0x00000002;
    public const int TASKS_TASK_START_FAILED = 0x00000004;
    public const int TASKS_OPERATION_COMPLETED = 0x00000008;
    public const int TASKS_OPERATION_COMPLETION_FAILED = 0x00000010;
    
    public const int SESSIONS_COMPLETED_UNKOWN = 0x00000000;
    public const int SESSIONS_COMPLETED_GEOFENCE = 0x00000001;
    public const int SESSIONS_COMPLETED_USER_ACTION = 0x00000002;
    
    public const int ETA_PLANNER_ETAS_UPDATED = 0x00000001;
};
    
}
}

