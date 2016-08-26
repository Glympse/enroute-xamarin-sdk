extern alias EnRouteApiDll;
extern alias GlympseApiDll;

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
            else if ( raw is GlympseApiDll::Glympse.GVector<EnRouteApiDll::Glympse.EnRoute.GOperation> )
            {
                // Convert the items in the array to the shared interface version
                GlympseApiDll.Glympse.GVector<GOperation> operations = new GlympseApiDll.Glympse.GVector<GOperation>();
                foreach (EnRouteApiDll::Glympse.EnRoute.GOperation operation in (GlympseApiDll::Glympse.GVector<EnRouteApiDll::Glympse.EnRoute.GOperation>)raw)
                {
                    operations.Add(new Operation(operation));
                }

                // Then convert the vector to the shared interface version of array
                return new Array<GOperation>(operations);
            }
            else if (raw is GlympseApiDll::Glympse.GVector<EnRouteApiDll::Glympse.EnRoute.GTask>)
            {
                // Convert the items in the array to the shared interface version
                GlympseApiDll.Glympse.GVector<GTask> tasks = new GlympseApiDll.Glympse.GVector<GTask>();
                foreach (EnRouteApiDll::Glympse.EnRoute.GTask task in (GlympseApiDll::Glympse.GVector <EnRouteApiDll::Glympse.EnRoute.GTask>) raw)
                {
                    tasks.Add(new Task(task));
                }

                // Then convert the vector to the shared interface version of array
                return new Array<GTask>(tasks);
            }
            else
            {
                throw new Exception("Unsupported type: " + raw.GetType().ToString());
            }
        }
    }
}

