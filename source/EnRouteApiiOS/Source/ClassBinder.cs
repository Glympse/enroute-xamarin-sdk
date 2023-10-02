namespace Glympse.EnRoute.iOS;

public class ClassBinder
{
    public static object bind(object raw)
    {
        if ( null == raw ) 
        {
            return null;
        }
        if ( raw is GlyEnRouteManager )
        {
            return new EnRouteManager((GlyEnRouteManager)raw);
        }
        if ( raw is GlyTaskManager )
        {
            return new TaskManager((GlyTaskManager)raw);
        }
        if ( raw is GlyOrganization )
        {
            return new Organization((GlyOrganization)raw);
        }
        if ( raw is GlyAgent )
        {
            return new Agent((GlyAgent)raw);
        }
        if ( raw is GlyTask )
        {
            return new Task((GlyTask)raw);
        }
        if ( raw is GlyOperation )
        {
            return new Operation((GlyOperation)raw);
        }
        if (raw is GlyTicket)
        {
            return new Ticket((GlyTicket)raw);
        }
        if (raw is GlyInvite)
        {
            return new Invite((GlyInvite)raw);
        }
        if (raw is GlyUser)
        {
            return new User((GlyUser)raw);
        }
        if (raw is GlyPlace)
        {
            return new Place((GlyPlace)raw);
        }
        if (raw is GlyGlympse)
        {
            return new Glympse((GlyGlympse)raw);
        }
        if (raw is GlyConsentManager)
        {
            return new ConsentManager((GlyConsentManager)raw);
        }
        if (raw is GlyChatManager)
        {
            return new ChatManager((GlyChatManager)raw);
        }
        if (raw is GlyChatMessage)
        {
            return new ChatMessage((GlyChatMessage)raw);
        }
        if ( raw is NSString nsString )
        {
            return nsString.ToString();
        }
        if ( raw is NSNumber nsNumber )
        {
            return nsNumber.ToString();
        }
        if (raw is GlyUserManager)
        {
            return new UserManager((GlyUserManager)raw);
        }
        if ( raw is GlyPrimitive )
        {
            return new Primitive((GlyPrimitive)raw);
        }
        if (raw is GlyLong)
        {
            return ((GlyLong) raw).longValue();
        }
        return null;
    }
}