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
     * @name Listener types
     * The list of all event broadcasters on the system.
     */
    
    /**
     * EnRoute Manager events.
     * Use IEnRouteManager event sink to subscribe on these events.
     */
    public const int LISTENER_ENROUTE_MANAGER = 1;
    
    /**
     * Tasks events.
     * Use ITaskManager event sink to subscribe on these events.
     */
    public const int LISTENER_TASKS = 2;
    
    /**
     * Agent events.
     * Use IAgentManager event sink to subscribe on these events.
     */
    public const int LISTENER_AGENTS = 3;
    
    /**
     * Session events.
     * Use ISessionManager event sink to subscribe on these events.
     */
    public const int LISTENER_SESSIONS = 4;
    
    /**
     * Active Agent events.
     * Use IActiveAgentsManager event sink to subscribe on these events.
     */
    public const int LISTENER_ACTIVE_AGENTS = 6;
    
    /**
     * ETA Planner events.
     * Use IEtaPlanner event sink to subscribe on these events.
     */
    public const int LISTENER_ETA_PLANNER = 7;
    
    /**
     * Pickup events
     * Use IPickupManager event sink to subscribe on these events
     */
    public const int LISTENER_PICKUPS = 8;
    
    /**
     * @name EnRoute Manager events.
     *
     * Events broadcasted by LISTENER_ENROUTE_MANAGER.
     */
    
    /**
     * This event is broadcast when the platform gets a login response from the Glympse server.
     * If the login is successful, this event the platform will then attempt to load the organization and
     * agent profile from the server. Upon loading these, the platform will then fire ENROUTE_MANAGER_STARTED.
     *
     * If the login fails this event will pass en error code as a parameter (string).
     */
    public const int ENROUTE_MANAGER_LOGIN_COMPLETED = 0x00000001;
    
    /**
     * This event is broadcast when the platform finishes logging out the current agent.
     * After this event the platform will stop the platform and fire ENROUTE_MANAGER_STOPPED.
     *
     * The reason for the logout is passed as a parameter (long)
     */
    public const int ENROUTE_MANAGER_LOGGED_OUT = 0x00000002;
    
    /**
     * This event is broadcast when the manager has been started.
     * The platform will remain started until it is stopped.
     */
    public const int ENROUTE_MANAGER_STARTED = 0x00000004;
    
    /**
     * This event is broadcast when the platform is fully stopped. The manager cannot be re-used
     * after the platform has been stopped. To restart the platform, a new GEnRouteManager must be created
     * using EnRouteFactory.
     */
    public const int ENROUTE_MANAGER_STOPPED = 0x00000008;
    
    /**
     * This event is broadcast when the manager completed it's initial sync with the server and is ready to be used.
     * The platform will remain started until it is stopped.
     */
    public const int ENROUTE_MANAGER_SYNCED = 0x00000010;
    
    /**
     * This event is broadcast when there is a push notification to display.
     *
     * The notification to display will be passed as a parameter (GPrimitive).
     */
    public const int ENROUTE_MANAGER_SHOW_NOTIFICATION = 0x00000020;
    
    /**
     * This event is broadcast when authentication (auth token) is needed by the En Route manager
     *
     */
    public const int ENROUTE_MANAGER_AUTHENTICATION_NEEDED = 0x00000040;
    
    /**
     * This event is broadcast when the org config object has been updated and the new values are in use by the system.
     *
     */
    public const int ENROUTE_MANAGER_ORG_CONFIG_UPDATED = 0x00000080;
    
    /**
     * This event is broadcast when the self agent has been updated and the new values are in use by the system.
     *
     */
    public const int ENROUTE_MANAGER_SELF_AGENT_UPDATED = 0x00000100;
    
    /**
     * This event is broadcast when the self agent's shift starts
     *
     */
    public const int ENROUTE_MANAGER_SHIFT_STARTED = 0x00000200;
    
    /**
     * This event is broadcast when the self agent's shift completes
     *
     */
    public const int ENROUTE_MANAGER_SHIFT_COMPLETED = 0x00000400;
    
    /**
     * This event is broadcast when the self agent's shift fails to start
     *
     * param1: error (GString)
     */
    public const int ENROUTE_MANAGER_SHIFT_START_FAILED = 0x00000800;
    
    /**
     * This event is broadcast when the self agent's shift fails to complete
     *
     * param1: error (GString)
     */
    public const int ENROUTE_MANAGER_SHIFT_COMPLETE_FAILED = 0x00001000;
    
    /**
     * This event is broadcast when the location accuracy authorization is updated
     */
    public const int ENROUTE_MANAGER_LOCATION_ACCURACY_UPDATED = 0x00002000;
    
    /**
     * This event is broadcast when the predefined messages for an org have been fetched
     */
    public const int ENROUTE_MANAGER_ORG_PREDEFINED_MESSAGES_UPDATED = 0x00004000;
    
    /**
     * @name Task Manager events.
     *
     * Events broadcasted by LISTENER_TASKS.
     */
    
    /**
     * This event is broadcast when anything changes within the task list managed by
     * Task Manager. This includes added tasks, removed tasks, phase changes, refreshes, etc.
     */
    public const int TASKS_TASK_LIST_CHANGED = 0x00000001;
    
    /**
     * This event is broadcast when a task is started by the client or the server.
     *
     * The associated task is passed as a parameter (GTask).
     */
    public const int TASKS_TASK_STARTED = 0x00000002;
    
    /**
     * This event is broadcast when a task fails to start.
     *
     * The associated task is passed as a parameter (GTask).
     */
    public const int TASKS_TASK_START_FAILED = 0x00000004;
    
    /**
     * This event is broadcast when an operation is completed.
     *
     * See EnRouteConstants::TASK_COMPLETE_REASON_* for reason codes
     *
     * The associated operation and reason code are passed as parameters (GOperation, long).
     */
    public const int TASKS_OPERATION_COMPLETED = 0x00000008;
    
    /**
     * This event is broadcast when an operation fails to complete.
     *
     * The associated operation is passed as a parameter (GOperation).
     */
    public const int TASKS_OPERATION_COMPLETION_FAILED = 0x00000010;
    
    /**
     * This event is broadcast when an task's phase changed.
     *
     * The associated task and the new phase are passed as parameters (GTask, GString).
     */
    public const int TASKS_TASK_PHASE_CHANGED = 0x00000020;
    
    /**
     * This event is broadcast when an operation's ticket reference changes.
     *
     * The associated operation and the new ticket are passed as parameters (GOperation, GTicket).
     */
    public const int TASKS_OPERATION_TICKET_CHANGED = 0x00000040;
    
    /**
     * This event is broadcast following a call to Taskmanager->addOrUpdateMetadataItem that succeeds
     *
     * The associated task is passed as a parameter (GTask)
     */
    public const int TASKS_TASK_METADATA_UPDATE_SUCCEEDED = 0X00000080;
    
    /**
     * This event is broadcast following a call to Taskmanager->addOrUpdateMetadataItem that fails
     *
     * The associated task and error are passed as parameters (GTask, GString)
     */
    public const int TASKS_TASK_METADATA_UPDATE_FAILED    = 0X00000100;
    
    /**
     * This event is broadcast when the CardMessages object associated with a task is updated
     *
     * The associated task is passed as a parameter (GTask).
     */
    public const int TASKS_TASK_CARD_MESSAGE_CHANGED = 0x00000200;
    
    /**
     * This event is broadcast when the SDK receives a response from the server after sending
     * a message
     *
     * The event id and unique id of the message are passed as parameters (GString, GString)
     * If no event id is present then the message failed to create on the server
     */
    public const int TASKS_TASK_CARD_MESSAGE_STATUS = 0x00000400;
    
    /**
     * This event is broadcast when the Ticket associated with a Task has updated its travel mode
     *
     * The associated task is passed as a parameter (GTask)
     */
    public const int TASKS_TASK_TRAVEL_MODE_CHANGED = 0x00000800;
    
    public const int TASKS_TASK_DURATION_CHANGED = 0x00001000;
    
    public const int TASKS_TASK_DESTINATION_CHANGED = 0x00002000;
    
    public const int TASKS_TASK_TRANSFERRED = 0x00004000;
    
    /**
     * This event is broadcast when the Chat Messages associated with a task is updated
     *
     * The associated task is passed as a parameter (GTask).
    */
    public const int TASKS_TASK_CHAT_MESSAGES_CHANGED = 0x00008000;
    
    /**
     * @name ETA Planner events.
     *
     * Events broadcasted by LISTENER_ETA_PLANNER.
     */
    
    /**
     * This event is broadcast when the Eta planner has updated etas.
     *
     * The list of etas are passed as a parameter (GVector<GLong>).
     */
    public const int ETA_PLANNER_ETAS_UPDATED = 0x00000001;
    
    /**
     * @name Agent Manager events.
     *
     * Events broadcasted by LISTENER_AGENTS.
     */
    
    /**
     * This event is broadcast when anything changes within the agent list managed by
     * the Agent Manager.
     */
    public const int AGENTS_AGENT_LIST_CHANGED = 0x00000001;
    
    /**
     * This event is broadcast when an agent is created.
     *
     * The associated agent is passed as a parameter (GAgent)
     */
    public const int AGENTS_AGENT_CREATED = 0x00000002;
    
    /**
     * This event is broadcast when an agent fails to create.
     *
     * The reason for failusre is passed as a parameter (string).
     */
    public const int AGENTS_AGENT_CREATION_FAILED = 0x00000004;
    
    /**
     * This event is broadcast when an agent is updated.
     *
     * The associated agent is passed as a parameter (GAgent).
     */
    public const int AGENTS_AGENT_UPDATED = 0x00000008;
    
    /**
     * This event is broadcast when an agent fails to update.
     * 
     * The reason for failusre is passed as a parameter (string).
     */
    public const int AGENTS_AGENT_UPDATE_FAILED = 0x00000010;
    
    /**
     * @name Session Manager events.
     *
     * Events broadcasted by LISTENER_SESSIONS.
     */
    
    /**
     * This event is broadcast when anything changes within the session list managed by
     * the Session Manager.
     */
    public const int SESSIONS_SESSION_LIST_CHANGED = 0x00000001;
    
    /**
     * This event is broadcast when a session is started.
     *
     * The associated session is passed as a parameter (GSession).
     */
    public const int SESSIONS_SESSION_STARTED = 0x00000002;
    
    /**
     * This event is broadcast when a session fails to start.
     * 
     * The associated session is passed as a parameter (GSession), along with the error string.
     */
    public const int SESSIONS_SESSION_START_FAILED = 0x00000004;
    
    /**
     * This event is broadcast when a session is completed.
     *
     * The associated session is passed as a parameter (GSession).
     */
    public const int SESSIONS_SESSION_COMPLETED = 0x00000008;
    
    /**
     * This event is broadcast when a session fails to complete.
     *
     * The associated session is passed as a parameter (GSession), along with the error string.
     */
    public const int SESSIONS_SESSION_COMPLETION_FAILED = 0x000000010;
    
    /**
     * This event is broadcast when the active task of a session is changed
     *
     * param1: GSession session
     * param2: GTask active task
     */
    public const int SESSIONS_SESSION_ACTIVE_TASK_CHANGED = 0x00000020;
    
    /**
     * This event is broadcast when the phase of the active task changes
     *
     * param1: GSession session
     * param2: GTask active task
     */
    public const int SESSIONS_SESSION_ACTIVE_TASK_PHASE_CHANGED = 0x00000040;
    
    /**
     * @name Active Agents Manager events.
     *
     * Events broadcasted by LISTENER_ACTIVE_AGENTS.
     */
    
    /**
     * This event is broadcast when anything changes within the active agent list managed by
     * the Active Agents Manager.
     */
    public const int ACTIVE_AGENTS_AGENT_LIST_CHANGED = 0x00000001;
    
    /**
     * This event is broadcast when an agent is added to the active agents list.
     *
     * The associated active agent is passed as a parameter (GActiveAgent).
     */
    public const int ACTIVE_AGENTS_AGENT_REGISTERED = 0x00000002;
    
    /**
     * @name Pickup Manager events
     *
     * Events broadcasted by LISTENER_PICKUPS
     */
    
    /**
     * This event is broadcast when anything changes within the pickups list managed by
     * the Pickup Manager
     */
    public const int PICKUPS_PICKUP_LIST_CHANGED = 0X00000001;
    
    /**
     * This event is broadcast when a pickup is accepted
     *
     * param1: GPickup that was accepted
     */
    public const int PICKUPS_PICKUP_ACCEPTED = 0X00000002;
    
    /**
     * This event is broadcast when a pickup is completed
     * 
     * param1: GPickup that completed
     */
    public const int PICKUPS_PICKUP_COMPLETED = 0X00000004;
    
    /**
     * This event is broadcast when a pickup fails to complete
     *
     * The associated pickup is passed as a parameter (GPickup), along with the error string.
     */
    public const int PICKUPS_PICKUP_FAILED_TO_COMPLETE = 0X00000008;
    
    /**
     * This event is broadcast when a pickup's phase changes
     *
     * param1: GPickup that changed
     */
    public const int PICKUPS_PICKUP_PHASE_UPDATED = 0x00000010;
    
    /**
     * This event is broadcast when a pickup's phase failed to update
     *
     * param1: GPickup that failed to update
     * param2: GString error
     */
    public const int PICKUPS_PICKUP_PHASE_UPDATE_FAILED = 0x00000020;
    
    /**
     * This event is broadcast when a pickup is assigned to a new agent. If the pickup's
     * agent id is now -1 it means the pickup has been unassigned.
     *
     * param1: GPickup that was assigned
     */
    public const int PICKUPS_PICKUP_ASSIGNED = 0x00000040;
    
    /**
     * This event is broadcast when a pickup fails to assign to a new agent
     *
     * param1: GPickup that failed to assign
     * param2: GString error
     */
    public const int PICKUPS_PICKUP_ASSIGN_FAILED = 0x00000080;
    
    /**
     * This event is broadcast when the Ticket object associated with a Pickup becomes available
     *
     * The associated pickup is passed as a parameter (GPickup).
     */
    public const int PICKUPS_PICKUP_TICKET_AVAILABLE = 0x00000100;
    
    /**
     * This event is broadcast when the messages collection associated with a pickup is updated
     *
     * The associated pickup is passed as a parameter (GPickup).
    */
    public const int PICKUPS_PICKUP_MESSAGES_CHANGED = 0x00000800;
    
    /**
     * This event is broadcast anytime a Pickup is refreshed individually. Properties within
     * the Pickup may or may not have been updated, but it's useful to listen to if an application
     * is focused on this Pickup and may need to refresh.
     *
     * The associated pickup is passed as a parameter (GPickup).
     */
    public const int PICKUPS_PICKUP_CHANGED = 0x00001000;
    
    /**
     * This event is broadcast when the Chat Messages associated with a pickup is updated
     *
     * The associated pickup is passed as a parameter (GPickup).
    */
    public const int PICKUPS_PICKUP_CHAT_MESSAGES_CHANGED = 0x00002000;
    
};
    
}
}

