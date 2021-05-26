using System;

namespace Glympse.EnRoute.iOS
{
    class Glympse : GGlympse
    {
        private GlyGlympse _raw;

        public Glympse(GlyGlympse raw)
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
            return new DirectionsManager((GlyDirectionsManager)_raw.getDirectionsManager());
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
            return new UserManager((GlyUserManager)_raw.getUserManager());
        }

        public GConsentManager getConsentManager()
        {
            return new ConsentManager((GlyConsentManager)_raw.getConsentManager());
        }

        public GCustomerPickupManager getCustomerPickupManager()
        {
            return new CustomerPickupManager((GlyCustomerPickupManager)_raw.getCustomerPickupManager());
        }

        public bool sendTicket(GTicket ticket)
        {
            return _raw.sendTicket((GlyTicket)ticket.raw());
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
            return new Config((GlyConfig)_raw.getConfig());
        }

        public object raw()
        {
            return _raw;
        }
    }
}
