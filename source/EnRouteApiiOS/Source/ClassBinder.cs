using System;

using Glympse.EnRoute;

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
            else
            {
                throw new Exception("Unsupported type: " + raw.GetType().ToString());
            }
        }
    }
}

