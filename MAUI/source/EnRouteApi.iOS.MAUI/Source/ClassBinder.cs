namespace Glympse.EnRoute.iOS
{
    public class ClassBinder
    {
        public static object bind(object raw)
        {
            if ( null == raw ) 
            {
                return null;
            }            
            else if ( raw is GlyEnRouteManager )
            {
                return new EnRouteManager((GlyEnRouteManager)raw);
            }
            else if ( raw is GlyTaskManager )
            {
                return new TaskManager((GlyTaskManager)raw);
            }
            else if ( raw is GlySessionManager )
            {
                return new SessionManager((GlySessionManager)raw);
            }
            else if ( raw is GlyOrganization )
            {
                return new Organization((GlyOrganization)raw);
            }
            else if ( raw is GlyAgent )
            {
                return new Agent((GlyAgent)raw);
            }
            else if ( raw is GlyTask )
            {
                return new Task((GlyTask)raw);
            }
            else if ( raw is GlyOperation )
            {
                return new Operation((GlyOperation)raw);
            }
            else if (raw is GlySession)
            {
                return new Session((GlySession)raw);
            }
            else if (raw is GlyTicket)
            {
                return new Ticket((GlyTicket)raw);
            }
            else if (raw is GlyInvite)
            {
                return new Invite((GlyInvite)raw);
            }
            else if (raw is GlyUser)
            {
                return new User((GlyUser)raw);
            }
            else if (raw is GlyPlace)
            {
                return new Place((GlyPlace)raw);
            }
            else if (raw is GlyTrack)
            {
                return new Track((GlyTrack)raw);
            }
            else if (raw is GlyLocation)
            {
                return new Location((GlyLocation)raw);
            }
            else if (raw is GlyGlympse)
            {
                return new Glympse((GlyGlympse)raw);
            }
            else if (raw is GlyConsentManager)
            {
                return new ConsentManager((GlyConsentManager)raw);
            }
            else if (raw is GlyChatManager)
            {
                return new ChatManager((GlyChatManager)raw);
            }
            else if (raw is GlyChatMessage)
            {
                return new ChatMessage((GlyChatMessage)raw);
            }
            else if ( raw is Foundation.NSString )
            {
                return ((Foundation.NSString) raw).ToString();
            }
            else if ( raw is Foundation.NSNumber )
            {
                return ((Foundation.NSNumber) raw).LongValue;
            }
            else if (raw is GlyUserManager)
            {
                return new UserManager((GlyUserManager)raw);
            }
            else if ( raw is GlyPrimitive )
            {
                return new Primitive((GlyPrimitive)raw);
            }
            else if (raw is GlyLong)
            {
                return ((GlyLong) raw).longValue();
            }
            else
            {
                return null;
            }
        }
    }
}

