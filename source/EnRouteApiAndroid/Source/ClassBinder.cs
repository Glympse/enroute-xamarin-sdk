using System;
using Android.Runtime;
using Glympse.EnRoute;

namespace Glympse.EnRoute.Android
{
    public class ClassBinder
    {
        public static object bind(object raw)
        {
            if ( null == raw ) 
            {
                return null;
            }                
            if ( raw is com.glympse.enroute.android.api.GEnRouteManager )
            {
                return new EnRouteManager((com.glympse.enroute.android.api.GEnRouteManager)raw);
            }
            else if ( raw is com.glympse.enroute.android.api.GTaskManager )
            {
                return new TaskManager((com.glympse.enroute.android.api.GTaskManager)raw);
            }
            else if ( raw is com.glympse.enroute.android.api.GOrganization )
            {
                return new Organization((com.glympse.enroute.android.api.GOrganization)raw);
            }
            else if ( raw is com.glympse.enroute.android.api.GAgent )
            {
                return new Agent((com.glympse.enroute.android.api.GAgent)raw);
            }
            else if ( raw is com.glympse.enroute.android.api.GTask )
            {
                return new Task((com.glympse.enroute.android.api.GTask)raw);
            }
            else if ( raw is com.glympse.enroute.android.api.GOperation )
            {
                return new Operation((com.glympse.enroute.android.api.GOperation)raw);
            }
            else if ( raw is Java.Lang.Object )
            {
                Java.Lang.Object obj = (Java.Lang.Object)raw;
                if ( "com.glympse.enroute.android.lib.TrackingManager" == obj.Class.Name ) 
                {
                    return new EnRouteManager(Extensions.JavaCast<com.glympse.enroute.android.api.GEnRouteManager>(obj));
                }
                else if ( "com.glympse.enroute.android.lib.TaskManager" == obj.Class.Name ) 
                {
                    return new TaskManager(Extensions.JavaCast<com.glympse.enroute.android.api.GTaskManager>(obj));
                }
                else if ( "com.glympse.enroute.android.lib.Organization" == obj.Class.Name ) 
                {
                    return new Organization(Extensions.JavaCast<com.glympse.enroute.android.api.GOrganization>(obj));
                }
                else if ( "com.glympse.enroute.android.lib.Agent" == obj.Class.Name ) 
                {
                    return new Agent(Extensions.JavaCast<com.glympse.enroute.android.api.GAgent>(obj));
                }
                else if ( "com.glympse.enroute.android.lib.Task" == obj.Class.Name ) 
                {
                    return new Task(Extensions.JavaCast<com.glympse.enroute.android.api.GTask>(obj));
                }
                else if ( "com.glympse.enroute.android.lib.Operation" == obj.Class.Name ) 
                {
                    return new Operation(Extensions.JavaCast<com.glympse.enroute.android.api.GOperation>(obj));
                }
                else if ( "java.lang.String" == obj.Class.Name )
                {
                    return Extensions.JavaCast<Java.Lang.String>(obj).ToString();
                }
                else if ( "java.lang.Long" == obj.Class.Name )
                {
                    return Extensions.JavaCast<Java.Lang.Long>(obj).LongValue();
                }
                else if ( "com.glympse.android.lib.Primitive" == obj.Class.Name )
                {
                    return new Primitive(Extensions.JavaCast<com.glympse.android.core.GPrimitive>(obj));
                }
                else
                {
                    return null;
                }
            }    
            else
            {
                return null;
            }
        }
    }
}

