﻿using System;
using Android.Content;
using Glympse.Toolbox;
using Glympse.EnRoute;

namespace Glympse.EnRoute.Android
{
    public class EnRouteManager : GEnRouteManager
    {
        private com.glympse.enroute.android.api.GEnRouteManager _raw;

        private CommonSource _source;

        public EnRouteManager(com.glympse.enroute.android.api.GEnRouteManager raw)
        {
            _raw = raw;
            _source = new CommonSource(_raw);
        }

        /**
         * GEnRouteManager section
         */ 

        public bool isLoginNeeded()
        {
            return _raw.isLoginNeeded();
        }

        public bool loginWithCredentials(string username, string password)
        {
            return _raw.loginWithCredentials(username, password);
        }

        public bool loginWithToken(string token, long expireTime)
        {
            return _raw.loginWithToken(token, expireTime);
        }

        public void logout(int reason)
        {
            _raw.logout(reason);
        }

        public bool start()
        {
            return _raw.start();
        }

        public void stop()
        {
            _raw.stop();
        }           
            
        public bool isStarted()
        {
            return _raw.isStarted();
        }

        public void setActive(bool active)
        {
            _raw.setActive(active);
        }

        public bool isActive()
        {
            return _raw.isActive();
        }

        public void setAuthenticationMode(int mode)
        {
            _raw.setAuthenticationMode(mode);
        }

        public int getAuthenticationMode()
        {
            return _raw.getAuthenticationMode();
        }

        public void refresh()
        {
            _raw.refresh();
        }

        public GGlympse getGlympse()
        {
            return (GGlympse)ClassBinder.bind(_raw.getGlympse());
        }

        public GOrganization getOrganization()
        {
            return (GOrganization)ClassBinder.bind(_raw.getOrganization());
        }

        public GAgent getLoggedInAgent()
        {
            return (GAgent)ClassBinder.bind(_raw.getLoggedInAgent());
        }

        public string getEnRouteToken()
        {
            return _raw.getEnRouteToken();
        }

        public GTaskManager getTaskManager()
        {
            return (GTaskManager)ClassBinder.bind(_raw.getTaskManager());
        }

        public GSessionManager getSessionManager()
        {
            return (GSessionManager)ClassBinder.bind(_raw.getSessionManager());
        }
        
        public void handleRemoteNotification(string payload)
        {
            _raw.handleRemoteNotification(payload);
        }
        
        public void registerDeviceToken(string tokenType, string deviceToken)
        {
            _raw.registerDeviceToken(tokenType, deviceToken);
        }

        public void overrideLoggingLevels(int fileLevel, int debugLevel)
        {
            _raw.overrideLoggingLevels(fileLevel, debugLevel);
        }

        public void enableXoANotifications(bool enabled)
        {
            _raw.enableXoANotifications(enabled);
        }

        public void setSessionsGeofencesEnabled(bool enabled)
        {
            _raw.setSessionsGeofencesEnabled(enabled);
        }

        /**
         * GSource section
         */

        public bool addListener(GListener listener)
        {
            return _source.addListener(listener);

        }            

        public bool removeListener(GListener listener)
        {
            return _source.removeListener(listener);
        }

        /**
         * GCommon section
         */

        public object raw()
        {
            return _raw;
        }
    }
}

