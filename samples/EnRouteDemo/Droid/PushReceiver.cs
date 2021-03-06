﻿
using System;

using Android.App;
using Android.Content;
using Android.Util;

using Glympse.EnRoute;
using Glympse.EnRoute.Android;

namespace EnRouteDemo.Droid
{
    [BroadcastReceiver (Name="com.glympse.android.PushReceiver")]
    [IntentFilter(new[] { "com.glympse.android.hal.service.STARTED", "com.glympse.android.hal.push.REFRESH", "com.glympse.android.hal.push.DATA" })]
    public class PushReceiver : BroadcastReceiver
    {
        private const String INTENT_STARTED = "com.glympse.android.hal.service.STARTED";
        private const String INTENT_REFRESH = "com.glympse.android.hal.push.REFRESH";
        private const String INTENT_DATA = "com.glympse.android.hal.push.DATA";

        public override void OnReceive (Context context, Intent intent)
        {
            String action = intent.Action;
            Log.Info("PushReceiver", action);

            if ( INTENT_STARTED == action ) 
            {
                startManager(context);
            } 
            else if ( INTENT_REFRESH == action ) 
            {
                startManager(context);
            } 
            else if ( INTENT_DATA == action ) 
            {
                startManager(context);
            }
        }

        private void startManager(Context context)
        {
            if (MainActivity.IS_ENROUTE_MODE)
            {
                GEnRouteFactory enRouteFactory = new EnRouteFactory(context);
                EnRouteManagerWrapper.Instance.Initialize(enRouteFactory);

                GEnRouteManager enRouteManager = EnRouteManagerWrapper.Instance.Manager;
                if (enRouteManager.isLoginNeeded() || !enRouteManager.isStarted())
                {
                    Auth.onAppStart(enRouteManager);
                }
            }
        }
    }
}
    