extern alias EnRouteApiDll;

using System;

namespace Glympse.EnRoute.UWP
{
    public class ClassBinder
    {
        public static object bind(object raw)
        {
            if ( null == raw ) 
            {
                return null;
            }                
            if ( raw is EnRouteApiDll::Glympse.EnRoute.GEnRouteManager )
            {
                return new EnRouteManager((EnRouteApiDll::Glympse.EnRoute.GEnRouteManager)raw);
            }
            else if ( raw is EnRouteApiDll::Glympse.EnRoute.GTaskManager )
            {
                return new TaskManager((EnRouteApiDll::Glympse.EnRoute.GTaskManager)raw);
            }
            else if ( raw is EnRouteApiDll::Glympse.EnRoute.GOrganization )
            {
                return new Organization((EnRouteApiDll::Glympse.EnRoute.GOrganization)raw);
            }
            else if ( raw is EnRouteApiDll::Glympse.EnRoute.GAgent )
            {
                return new Agent((EnRouteApiDll::Glympse.EnRoute.GAgent)raw);
            }
            else if ( raw is EnRouteApiDll::Glympse.EnRoute.GTask )
            {
                return new Task((EnRouteApiDll::Glympse.EnRoute.GTask)raw);
            }
            else if ( raw is EnRouteApiDll::Glympse.EnRoute.GOperation )
            {
                return new Operation((EnRouteApiDll::Glympse.EnRoute.GOperation)raw);
            }   
            else
            {
                throw new Exception("Unsupported type: " + raw.GetType().ToString());
            }
        }
    }
}

