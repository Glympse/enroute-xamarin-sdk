//------------------------------------------------------------------------------
//
// Copyright (c) Glympse Inc.  All rights reserved.
//
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Glympse 
{
    
/**
 * Declares the list of all constants (enumerations) utilized by various API components. 
 */
/*O*/public/**/ class GlympseConstants
{
    /**
     * @name SMS Modes
     * 
     * SMS mode defines party responsible for SMS delivery. 
     */
    
    /**
     * The default SMS send mode allows the Glympse API to query the device and determine 
     * if an SMS invite should be sent locally from the device's SMS number or remotely 
     * from the Glympse server SMS provider. 
     *
     * You can call the IGlympse::canDeviceSendSms method to determine if the Glympse API 
     * has detected that the device does support sending of SMS messages.
     */     
    public const int SMS_SEND_MODE_DEFAULT      = 1;
    
    /**
     * The device SMS send mode forces the Glympse API to always send SMS invites from the device's SMS number.
     */ 
    public const int SMS_SEND_MODE_DEVICE       = 2;
    
    /**
     * The server SMS send mode forces the Glympse API to always send SMS invites through the Glympse server SMS provider.
     */ 
    public const int SMS_SEND_MODE_SERVER       = 3;    
    
    /**
     * @name Device SMS Capabilities
     *
     * Constants for identifying device SMS capabilities.
     */
    
    /**
     * The device is capable of sending SMS messages programmatically. 
     */ 
    public const int SMS_SEND_AUTO              = 1;    
    
    /**
     * The device is capable of sending SMS messages, but user confirmation is required.
     */ 
    public const int SMS_SEND_MANUAL            = 2;        
    
    /**
     * The device is not capable of sending SMS messages. 
     */ 
    public const int SMS_SEND_NOT_SUPPORTED     = 3;
    
    /**
     * @name ETA Modes
     *
     * Supported ETA modes. 
     */
    
    /**
     * In this mode ETA information should be provided externally. 
     * Glympse API will not attempt to calclulate that. 
     */     
    public const int ETA_MODE_EXTERNAL          = 1;        

    /**
     * Glympse API will attempt to calclulate ETA in this mode.      
     */
    public const int ETA_MODE_INTERNAL          = 2; 
    
    /**
     * @name Invite Decoding Modes
     *
     * Various flags that can be applied when decoding invites.
     *
     * @see IGlympse#decodeInvite
     */
    
    /**
     * Default mode for invites decoding. 
     *
     * Platform starts viewing ticket invites automatically in this mode
     * (without any confirmations). 
     *
     * Request invite will still result in GE::PLATFORM_INVITE_REQUEST being spread.
     * Platform prevents automatic replying to ticket requests because of security
     * considerations. 
     */
    public const int INVITE_MODE_DEFAULT                  = 0x00000000;        
    
    /**
     * Enables viewing confirmation for ticket invites. GE::PLATFORM_INVITE_TICKET is spread
     * to all subscribers of IGlympse event sink. Explicit action is required to start 
     * viewing ticket invite (see IGlympse::viewTicket()), if this mode is specified.
     */
    public const int INVITE_MODE_PROMPT_BEFORE_VIEWING    = 0x00000001;
    
    /**
     * Newly added standalone user will automatically be activated, 
     * if this mode is specified. This mode only makes sense in conjunction with
     * INVITE_MODE_DEFAULT, where users are added automatically.
     */
    public const int INVITE_MODE_ACTIVATE_USER            = 0x00000002;
    
    /**
     * @name User Tracking Modes
     *
     * User tracking mode defines the way platform deals with multiple concurrent incoming 
     * tickets received from a user.
     *
     * @see IUserManager#setUserTrackingMode
     */
    
    /**
     * When running in this mode, platform tracks and provides host application with updates
     * regarding the only ticket for a given user (the most recently received one). This ticket object is
     * accessible through IUser#getActiveStandalone method. All other tickets received from 
     * the user remain on the list, but are never updated. The order of tickets changes only when
     * new ticket is received from the user or currently active ticket expires.
     *
     * User trail information is always available under track object belonging to active ticket.
     * When active ticket changes, its track is merged with to newly activated ticket.
     *
     * Platform automatically unsubscribes listeners from events spread by active ticket
     * when it changes.
     */
    public const int USER_TRACKING_MODE_ACTIVE            = 0x00000001;
    
    /**
     * Platform pulls updates for all active tickets received from a given user, when running in
     * this mode. 
     *
     * User trail is still available through active standalone ticket. Major difference
     * is that properties of all other tickets received from this user are also updated up until 
     * expiration.
     *
     * In this mode platform never unsubscribes listeners of user's tickets.
     */
    public const int USER_TRACKING_MODE_ALL               = 0x00000002;
    
    /**
     * @name Ticket States
     *
     * Supported ticket states. 
     */
    
    public const int TICKET_STATE_NONE             = 0x00000001;
    public const int TICKET_STATE_ADDING           = 0x00000002;
    public const int TICKET_STATE_INVALID          = 0x00000004;
    public const int TICKET_STATE_ACTIVE           = 0x00000010;            
    public const int TICKET_STATE_EXPIRING         = 0x00000020;            
    public const int TICKET_STATE_EXPIRED          = 0x00000040;            
    public const int TICKET_STATE_DELETING         = 0x00000080;                
    public const int TICKET_STATE_DELETED          = 0x00000100;                       
    public const int TICKET_STATE_FAILED_TO_CREATE = 0x00000200;
    public const int TICKET_STATE_CANCELLED        = 0x00000400;
    
    public const int TICKET_STATE_DECODING
        = TICKET_STATE_ADDING
        | TICKET_STATE_ACTIVE;
    public const int TICKET_STATE_ACTIVATING
        = TICKET_STATE_ADDING
        | TICKET_STATE_ACTIVE;
    
    /**
     * @name Invite Aspects
     *
     * Glympse invite code (6 or 8 character string separated by a dash)
     * always points to an object in Glympse universe (e.g. ticket or request to share location).
     * Invite aspect identifies type of that object. 
     */

    /**
     * Invite of unknown aspect. The value usually indicates that invite aspect
     * cannot be determined locally. See IGlympse#decodeInvite() for more details.
     */
    public const int INVITE_ASPECT_UNKNOWN   = 0;
    
    /**
     * Identifies invite pointing to ticket object.
     */
    public const int INVITE_ASPECT_TICKET    = 1;
    
    /**
     * Invite of this type represents a request to share location.
     */ 
    public const int INVITE_ASPECT_REQUEST   = 2;
    
    /**
     * Invite of this type represents an invite to join a card.
     */
    public const int INVITE_ASPECT_CARD      = 3;
    
    /**
     * @name Invite Types
     *
     * Supported invite delivery mechanisms.
     */    
    
    public const int INVITE_TYPE_UNKNOWN     = 0;            
    public const int INVITE_TYPE_ACCOUNT     = 1;            
    public const int INVITE_TYPE_EMAIL       = 2;            
    public const int INVITE_TYPE_SMS         = 3;            
    public const int INVITE_TYPE_TWITTER     = 4;         
    public const int INVITE_TYPE_FACEBOOK    = 5;     
    public const int INVITE_TYPE_LINK        = 6;     
    public const int INVITE_TYPE_GROUP       = 7;
    public const int INVITE_TYPE_SHARE       = 8;
    public const int INVITE_TYPE_CLIPBOARD   = 9;
    public const int INVITE_TYPE_EVERNOTE    = 10;
    public const int INVITE_TYPE_APP         = 11;
    
    /**
     * @name Invite States
     *
     * Supported invite states.
     */
    
    public const int INVITE_STATE_NONE             = 0;  
    public const int INVITE_STATE_SERVERSENDING    = 1; 
    public const int INVITE_STATE_CLIENTSENDING    = 2;  
    public const int INVITE_STATE_NEEDTOSEND       = 3;     
    public const int INVITE_STATE_SUCCEEDED        = 4;     
    public const int INVITE_STATE_DELETING         = 5;        
    public const int INVITE_STATE_DELETED          = 6;   
    public const int INVITE_STATE_FAILED_TO_CREATE = 7;      
    public const int INVITE_STATE_FAILED_TO_SEND   = 8;        
    public const int INVITE_STATE_FAILED_TO_DELETE = 9;
        
    /**
     * @name Image States
     *
     * Supported image states.
     */
    
    public const int IMAGE_STATE_NONE          = 0;    
    public const int IMAGE_STATE_LOADING       = 1;    
    public const int IMAGE_STATE_LOADED        = 2;        
    public const int IMAGE_STATE_FAILED        = 3;
    
    /**
     * @name Group States
     *
     * Supported group states.
     */
    
    public const int GROUP_STATE_NONE                 = 0;
    public const int GROUP_STATE_INVALID              = 1;    
    public const int GROUP_STATE_ADDING               = 2;     
    /**
     * Intermediate group state, in which group finds itself once being decoded
     * but not yet accepted by the user. 
     */
    public const int GROUP_STATE_PENDING              = 3;            
    public const int GROUP_STATE_ACTIVE               = 4;  
    public const int GROUP_STATE_LEAVING              = 5;     
    public const int GROUP_STATE_LEFT                 = 6;      
    public const int GROUP_STATE_FAILED_TO_CREATE     = 7;     
    public const int GROUP_STATE_FAILED_TO_JOIN       = 8;        
    public const int GROUP_STATE_FAILED_TO_LEAVE      = 9;
    
    /**
     * @name XoA (Expire on Arrival) Modes
     *
     * Supported XoA modes.
     */    
    
    /**
     * Automatic expiration logic is totally turned off in this mode. 
     */
    public const int EXPIRE_ON_ARRIVAL_NONE       = 0;
    
    /**
     * Ticket subscribers are notified with GE::TICKET_ARRIVED event upon arrival
     * to the destination. 
     */ 
    public const int EXPIRE_ON_ARRIVAL_NOTIFY     = 1;
    
    /**
     * Ticket is automatically expired upon arrival. GE::TICKET_EXPIRED is spread to 
     * ticket subscribers.
     */
    public const int EXPIRE_ON_ARRIVAL_AUTO       = 2;
    
    /**
     * @name Delete after Complete modes
     */
    
    /**
     * No ticket deletion will automatically occur after ticket completion (default)
     */
    public const int DELETE_AFTER_COMPLETE_OFF = 0;
    
    /**
     * Tickets will be deleted automatically after they complete
     */
    public const int DELETE_AFTER_COMPLETE_IMMEDIATE = 1;
    
    /**
     * Tickets will be deleted after a scheduled period of time following complete
     */
    public const int DELETE_AFTER_COMPLETE_SCHEDULED = 2;
    
    /**
     * @name Group Name Verification Options
     *
     * Values returned by IGroupManager#validateGroupName().
     */
    
    /**
     * Specified group name conforms to group name requirements. 
     */
    public const int GROUP_NAME_CORRECT               = 0;
    
    /**
     * Specified group name is too short.
     */
    public const int GROUP_NAME_TOO_SHORT             = 1;
    
    /**
     * Specified group name contains invalid character. 
     */
    public const int GROUP_NAME_INVALID_CHARACTER     = 2;

    /**
     * Group name cannot consist of just numbers.
     */
    public const int GROUP_NAME_JUST_DIGITS           = 3;
    
    /**
     * @name Miscellaneous Defaults
     *
     * Default and no change constants.
     */
    
    /**
     * This constant can be used with the ITicket::modify method to specify that the duration
     * should not be changed when modifying a ticket.
     */
    public const int DURATION_NO_CHANGE         = -1;
    
    /**
     * The value indicates that client platform falls back to default lookback interval specified on server side.
     * It can be passed to IGlympse#setHistoryLookback() and returned by IGlympse#getHistoryLookback().
     */
    public const long HISTORY_LOOKBACK_DEFAULT   = -1;
    
    /**
     * @name Context Constants
     *
     * Constants defining the range of supported context keys.
     */
    
    /**
     * Minimum value of context key. 
     */
    public const long CONTEXT_KEY_MIN         = 0x0L;
    
    /**
     * Maximum value of specific key. 
     */
    public const long CONTEXT_KEY_MAX         = 0xffffffffffffL;
    
    /**
     * @name Ticket Fields
     *
     * The list of fields generally available under ticket object.
     */
    
    /**
     * Refers to the list of invites.
     */
    public const int TICKET_FIELD_INVITES             = 0x00000001;
    
    /**
     * Refers to ticket duration.
     */
    public const int TICKET_FIELD_DURATION            = 0x00000002;
    
    /**
     * Refers to ticket message.
     */
    public const int TICKET_FIELD_MESSAGE             = 0x00000004;
    
    /**
     * Refers to ticket destination.
     */
    public const int TICKET_FIELD_DESTINATION         = 0x00000008;
    
    /**
     * @name External Handoff Actions
     * 
     * Actions commonly supported by handoff providers.
     */
    
    /**
     * Initiates sending a Glympse from a browser.
     */
    public const int HANDOFF_ACTION_SEND              = 0x00000001;
    
    /**
     * @name Travel Modes
     *
     * Supported travel modes.
     */
    
    /**
     * Default travel mode.
     */
    public const int TRAVEL_MODE_DEFAULT   = 0;
    
    /**
     * Driving mode.
     */
    public const int TRAVEL_MODE_DRIVE   = 1;
    
    /**
     * Cycling mode.
     */
    public const int TRAVEL_MODE_CYCLE = 2;
    
    /**
     * Walking mode.
     */
    public const int TRAVEL_MODE_WALK   = 3;
    
    /**
     * Flying mode.
     */
    public const int TRAVEL_MODE_AIRLINE   = 4;
    
    /**
     * Transit mode.
     */
    public const int TRAVEL_MODE_TRANSIT   = 5;
    
    /**
     * @name Eta/Route Query Modes
     *
     * Supported modes for querying eta and route.
     */
    
    /**
     * Always query eta/route (when enabled).
     */
    public const int ETA_QUERY_MODE_ALWAYS   = 0;
    
    /**
     * Only query eta/route when watched by someone, including self (i.e. when platform is active).
     */
    public const int ETA_QUERY_MODE_WATCHED   = 1;
    
    /**
     * @name Ticket visibility
     */

    /**
     * TICKET_VISIBILITY_KEY_LOCATION() value indicating visible location.
     */
    public static String TICKET_VISIBILITY_LOCATION_VISIBLE()
    {
        return CoreFactory.createString("visible");
    }

    /**
     * TICKET_VISIBILITY_KEY_LOCATION() value indicating hidden location.
     */
    public static String TICKET_VISIBILITY_LOCATION_HIDDEN()
    {
        return CoreFactory.createString("hidden");
    }

    /**
     * Key to retrieve the location visibility from ITicket::getVisibility.
     */
    public static String TICKET_VISIBILITY_KEY_LOCATION()
    {
        return CoreFactory.createString("location");
    }

    /**
     * Key to retrieve the visibility context from ITicket::getVisibility.
     */
    public static String TICKET_VISIBILITY_KEY_CONTEXT()
    {
        return CoreFactory.createString("context");
    }

    /**
     * @name Linked Accounts
     */
    
    /**
     * Facebook.
     */
    public static String LINKED_ACCOUNT_TYPE_FACEBOOK()
    {
        return CoreFactory.createString("facebook");
    }
    
    /**
     * Twitter.
     */
    public static String LINKED_ACCOUNT_TYPE_TWITTER()
    {
        return CoreFactory.createString("twitter");
    }
    
    /**
     * Evernote.
     */
    public static String LINKED_ACCOUNT_TYPE_EVERNOTE()
    {
        return CoreFactory.createString("evernote");
    }

    /**
     * Google+.
     */
    public static String LINKED_ACCOUNT_TYPE_GOOGLE()
    {
        return CoreFactory.createString("google_plus");
    }

    /**
     * Pairing Code.
     */
    public static String LINKED_ACCOUNT_TYPE_PAIRING()
    {
        return CoreFactory.createString("pairing");
    }
    
    /**
     * Phone Number.
     */
    public static String LINKED_ACCOUNT_TYPE_PHONE()
    {
        return CoreFactory.createString("phone");
    }
    
    /**
     * Email Address.
     */
    public static String LINKED_ACCOUNT_TYPE_EMAIL()
    {
        return CoreFactory.createString("email");
    }

   /**
     * @name Linked Account Properties
     */
    
    /**
     * This property controls whether invites of the associated linked account type
     * are sent by the sever, or whether the host application perfers to send them
     * itself. By default, this property is false for all linked account types, so
     * invites will be sent by the server.
     */
    public static String LINKED_ACCOUNT_PROPERTY_INVITE_CLIENT_SEND()
    {
        return CoreFactory.createString("invite_client_send");
    }

    /**
     * @name Linked Account States
     *
     * All possible states for linked account objects.
     */
    
    /**
     * Unknown.
     */
    public const int LINKED_ACCOUNT_STATE_NONE             = 0;
    
    /**
     * Linking in progress.
     */
    public const int LINKED_ACCOUNT_STATE_LINKING          = 1;
    
    /**
     * Linked.
     */
    public const int LINKED_ACCOUNT_STATE_LINKED           = 2;

    /**
     * Failed to link.
     */
    public const int LINKED_ACCOUNT_STATE_FAILED_TO_LINK   = 3;

    /**
     * Unlinking in progress.
     */
    public const int LINKED_ACCOUNT_STATE_UNLINKING        = 4;
    
    /**
     * Unlinked.
     */
    public const int LINKED_ACCOUNT_STATE_UNLINKED         = 5;
    
    /**
     * Failed to unlink.
     */
    public const int LINKED_ACCOUNT_STATE_FAILED_TO_UNLINK = 6;

    /**
     * Refreshing in progress.
     */
    public const int LINKED_ACCOUNT_STATE_REFRESHING       = 7;

    /**
     * @name Linked Account Status
     *
     * All possible status codes for linked account objects.
     */
    
    /**
     * Unknown.
     */
    public const int LINKED_ACCOUNT_STATUS_NONE           = 0;

    /**
     * Account status is good.
     */
    public const int LINKED_ACCOUNT_STATUS_OK             = 1;

    /**
     * Account metadata needs to be refreshed.
     */
    public const int LINKED_ACCOUNT_STATUS_REFRESH_NEEDED = 2;

    /**
     * @name Linked Account Login Authorization
     *
     * All possible states for linked account federated login permission.
     */
    
    /**
     * Unknown.
     */
    public const int LINKED_ACCOUNT_LOGIN_NONE     = 0;
    
    /**
     * Login enabled.
     */
    public const int LINKED_ACCOUNT_LOGIN_ENABLED  = 1;
    
    /**
     * Login disabled.
     */
    public const int LINKED_ACCOUNT_LOGIN_DISABLED = 2;

    /**
     * @name Server error types.
     *
     * Classes of errors that may be reported by the server.
     */
    
    /**
     * Generic or unknown error.
     */
    public const int SERVER_ERROR_UNKNOWN       = 1;
    
    /**
     * The format of the request is invalid.
     */
    public const int SERVER_ERROR_FORMAT        = 2;
    
    /**
     * The request was denied due to access rights.
     */
    public const int SERVER_ERROR_ACCESS_DENIED = 3;

    /**
     * The request failed because third-party account validation failed.
     */
    public const int SERVER_ERROR_LINK_FAILED   = 4;

    /**
     * The request failed because the third-party account specified is not the one linked to the user account.
     */
    public const int SERVER_ERROR_LINK_MISMATCH = 5;

    /**
     * The request failed because the third-party account is already linked with a different user account.
     */
    public const int SERVER_ERROR_EXISTING_LINK = 6;

    /**
     * The request failed because no third-party account of the specified type is linked.
     */
    public const int SERVER_ERROR_NOT_LINKED    = 7;
    
    /**
     * The request failed because a required token is invalid or expired.
     */
    public const int SERVER_ERROR_INVALID_TOKEN = 8;
    
    /**
     * The request failed because server disabled current platform installation.
     * Upon receiving this error platform will stop talking to Glympse server 
     * until it sees a change in application version.
     */
    public const int SERVER_ERROR_DISABLED      = 9;

    /**
     * @name Expiration Mode
     *
     * Ticket expiration mode defines platform behavior with regards to ticket expiration.
     * Depending on currently applied mode the platform requires server confirmation in order to
     * alter local state (switch to 'not sharing' state from 'sharing') or is capable of performing
     * the switch on its own.
     *
     * @see IHistoryManager#setExpirationMode
     */
    
    /**
     * All properties taken into account has to be synchronized with server, when running in this mode.
     */
    public const int EXPIRATION_MODE_SYNCHRONIZED     = 0;
    
    /**
     * Platform relies on local ticket state as well in order to make some decisions.
     */
    public const int EXPIRATION_MODE_DETACHED         = 1;
    
    /**
     * @name Track Sources
     *
     * Track source specifies where track information is coming from.
     */
    
    /**
     * The origin on track data is unknown.
     */
    public const int TRACK_SOURCE_UNKNOWN = 0;
    
    /**
     * Track data is provided by Google Directions API.
     */
    public const int TRACK_SOURCE_GOOGLE_DIRECTIONS = 1;
    
    /**
     * Track information is retrieved from a flight tracking service.
     */
    public const int TRACK_SOURCE_INFLIGHT = 2;
    
    /**
     * Track data is provided by HERE Directions API.
     */
    public const int TRACK_SOURCE_HERE_DIRECTIONS = 3;
    
    /**
     * Track data is provided by Glympse Directions API.
     */
    public const int TRACK_SOURCE_GLYMPSE_DIRECTIONS = 4;

    /**
     * @name Directions state.
     *
     * State of Directions object.
     */
    /**
     * The directions state is unknown. Normally prior to a directions request.
     */
    public const int DIRECTIONS_STATE_UNKNOWN = 0;

    /**
     * The directions state is fetching. Directions request has been sent to the server.
     */
    public const int DIRECTIONS_STATE_FETCHING = 1;

    /**
     * The directions state is succeeded. Directions were successfully retrieved.
     */
    public const int DIRECTIONS_STATE_SUCCESS = 2;

    /**
     * The directions state is failed. Directions were not successfully retrieved.
     */
    public const int DIRECTIONS_STATE_FAILED = 3;

    /**
     * @name Trigger Types
     *
     * Trigger types based on criteria used to fire associated action. 
     */
    
    /**
     * Trigger that is fired when user leaves specified geofence.
     */
    public const int TRIGGER_TYPE_GEO = 1;
    
    /**
     * Trigger that is fired at a specific time.
     */
    public const int TRIGGER_TYPE_CHRONO = 2;
    
    /**
     * Trigger that is fired based on a give ticket's ETA.
     */
    public const int TRIGGER_TYPE_ETA = 3;
    
    /**
     * Trigger that is fired when the configured provider detects arrival.
     */
    public const int TRIGGER_TYPE_ARRIVAL = 4;
    
    /**
     * Trigger that is fired when the configured provider detects that the user has departed a given location.
     */
    public const int TRIGGER_TYPE_DEPARTURE = 5;
    
    /**
     * Remote trigger that is fired when a user enters a circular geofence
     */
    public const int TRIGGER_TYPE_REMOTE_GEO_CIRCLE = 6;
    
    /**
     * Remote trigger that is fired when an ETA threshold is crossed.
     */
    public const int TRIGGER_TYPE_REMOTE_ETA = 7;
    
    /**
     * @name Remote trigger type strings
     */
    
    public static String TRIGGER_REMOTE_GEO_CIRCLE_KEY()
    {
        return CoreFactory.createString("geo_circle");
    }
    
    public static String TRIGGER_REMOTE_ETA_KEY()
    {
        return CoreFactory.createString("eta");
    }
    
    /**
     * @name Network Response
     *
     * Success criteria constants for netwrok response.
     */
    
    public const int NETWORK_RESPONSE_CODE_ANY            = 0x00000000;
    public const int NETWORK_RESPONSE_CODE_ANY_VALID      = 0x00000001;
    public const int NETWORK_RESPONSE_CODE_2XX            = 0x00000002;
    public const int NETWORK_RESPONSE_BODY_ANY            = 0x00000000;
    public const int NETWORK_RESPONSE_BODY_NOT_EMPTY      = 0x00000010;
    public const int NETWORK_RESPONSE_BODY_VALID_JSON     = 0x00000030;
    
    /**
     * @name CardTicket Replies
     *
     * Supported card ticket replies.
     */
    public const int CARD_TICKET_REPLY_INACTIVE           = 0x00000001;
    public const int CARD_TICKET_REPLY_NONE               = 0x00000002;
    public const int CARD_TICKET_REPLY_ACCEPT             = 0x00000004;
    public const int CARD_TICKET_REPLY_DECLINE            = 0x00000008;

    public const int CARD_TICKET_REPLY_ANY
        = CARD_TICKET_REPLY_ACCEPT
        | CARD_TICKET_REPLY_DECLINE;
    
    /**
     * @name Card Object types
     *
     * Constants defining what type of object a card object is.
     */
    public static String CARD_OBJECT_TYPE_POI()
    {
        return CoreFactory.createString("poi");
    }
    
    public static String CARD_OBJECT_TYPE_INVITE()
    {
        return CoreFactory.createString("invite");
    }
    
    public static String CARD_OBJECT_TYPE_UNKNOWN()
    {
        return CoreFactory.createString("unknown");
    }
    
    /**
     * @name Card States
     *
     * Supported card states.
     */
    
    /**
     * Initial state of card object. Card exists in none state until it is registered on the manager.
     */
    public const int CARD_STATE_NONE             = 0x00000001;
    
    /**
     * Card is in process of being created. 
     */
    public const int CARD_STATE_CREATING         = 0x00000002;
    
    /**
     * State representing the card decoded from invite.
     */
    public const int CARD_STATE_PREVIEW          = 0x00000004;
    
    /**
     * The start card is turned into while client is waiting for acceptance from server.
     */
    public const int CARD_STATE_JOINING          = 0x00000008;
    
    /**
     * Indicates completely initialized card maintained by card manager.
     */
    public const int CARD_STATE_ACTIVE           = 0x00000010;
    
    /**
     * User is in process of leaving the card.
     */
    public const int CARD_STATE_LEAVING          = 0x00000020;
    
    /**
     * Fatal state indicating failure to create a card.
     * Card with this state should not be registered on card manager's list.
     */
    public const int CARD_STATE_FAILED_TO_CREATE = 0x00000040;
    
    /**
     * Fatal state indicating failure to join a card.
     * Card with this state should not be registered on card manager's list.
     */
    public const int CARD_STATE_FAILED_TO_JOIN   = 0x00000080;
    
    /**
     * @name Card IDs
     *
     * Supported card ids, to be used when creating a card with GlympseFactory::createCard(...)
     */
    
    /**
     * Private group card ID
     */
    public static String CARD_ID_PRIVATE_GROUP()
    {
        return CoreFactory.createString("559364b74d76b03a2f46096e");
    }
    
    /**
     * @name Consent types
     *
     * Consent type indicates whether user consent is from a parent/guardian or the subject
     */
    
    /**
     * Indicates the user is agreeing for themself
     */
    public static String CONSENT_TYPE_SUBJECT()
    {
        return CoreFactory.createString("subject");
    }
    
    /**
     * Indicates the user is providing consent for a minor
     */
    public static String CONSENT_TYPE_GUARDIAN()
    {
        return CoreFactory.createString("guardian");
    }
    
    /**
     * @name Consent states
     *
     * Consent state is used to indicate whether the user has granted/denied/never been shown the consent dialog
     */
    
    /**
     * Consent has never been acted on (default state). Choice should
     * be displayed to the user as soon as possible. The user will not be able
     * to create new data while in this state.
     */
    public static String USER_CONSENT_NONE()
    {
        return CoreFactory.createString("none");
    }
    
    /**
     * Consent has been denied. The user will not be able to create new
     * data through the platform while in this state.
     */
    public static String USER_CONSENT_NO()
    {
        return CoreFactory.createString("no");
    }
    
    /**
     * Consent has been granted. The user will have normal ability to interact
     * with the platform without restrictions while in this state.
     */
    public static String USER_CONSENT_YES()
    {
        return CoreFactory.createString("yes");
    }
    
    public static String USER_CONSENT_EXEMPT()
    {
        return CoreFactory.createString("exempt");
    }
    
    /**
     * @name Glympse Privacy URLs
     */
    
    /**
     * URL for Glympse's Privacy Policy
     */
    public static String PRIVACY_POLICY_URL()
    {
        return CoreFactory.createString("https://glympse.com/privacy/");
    }
    
    /**
     * URL for Glympse's Terms & Conditions
     */
    public static String TERMS_AND_CONDITIONS_URL()
    {
        return CoreFactory.createString("https://glympse.com/terms/");
    }

};

}

