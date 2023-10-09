using System;

namespace Glympse.EnRoute.Android
{
    class Glympse : GGlympse
    {
        private com.glympse.android.api.GGlympse _raw;

        public Glympse(com.glympse.android.api.GGlympse raw)
        {
            _raw = raw;
        }

        public void start()
        {
            _raw.start();
        }

        public void stop()
        {
            _raw.stop();
        }

        public bool isStarted()
        {
            return _raw.isStarted();
        }

        public int canDeviceSendSms()
        {
            return _raw.canDeviceSendSms();
        }

        public string getApiVersion()
        {
            return _raw.getApiVersion();
        }

        public GDirectionsManager getDirectionsManager()
        {
            return new DirectionsManager((com.glympse.android.api.GDirectionsManager)_raw.getDirectionsManager());
        }

        public int getEtaMode()
        {
            return _raw.getEtaMode();
        }

        public int getSmsSendMode()
        {
            return _raw.getSmsSendMode();
        }

        public GUserManager getUserManager()
        {
            return new UserManager((com.glympse.android.api.GUserManager)_raw.getUserManager());
        }

        public GConsentManager getConsentManager()
        {
            return new ConsentManager((com.glympse.android.api.GConsentManager)_raw.getConsentManager());
        }

        public GCustomerPickupManager getCustomerPickupManager()
        {
            return new CustomerPickupManager((com.glympse.android.api.GCustomerPickupManager)_raw.getCustomerPickupManager());
        }

        public GChatManager getChatManager()
        {
            return new ChatManager((com.glympse.android.api.GChatManager)_raw.getChatManager());
        }

        public bool sendTicket(GTicket ticket)
        {
            return _raw.sendTicket((com.glympse.android.api.GTicket)ticket.raw());
        }

        public void setEtaMode(int mode)
        {
            _raw.setEtaMode(mode);
        }

        public void setSmsSendMode(int mode)
        {
            _raw.setSmsSendMode(mode);
        }

        public void overrideLoggingLevels(int fileLevel, int debugLevel)
        {
            _raw.overrideLoggingLevels(fileLevel, debugLevel);
        }

        public GConfig getConfig()
        {
            return new Config((com.glympse.android.api.GConfig)_raw.getConfig());
        }

        public object raw()
        {
            return _raw;
        }
    }
}
