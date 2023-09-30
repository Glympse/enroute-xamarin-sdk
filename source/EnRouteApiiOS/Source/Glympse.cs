namespace Glympse.EnRoute.iOS;

internal class Glympse : GGlympse
{
    GlyGlympse _raw;

    public Glympse(GlyGlympse raw) =>
        _raw = raw;

    public void start()
    {
        _raw.start();
    }

    public void stop()
    {
        _raw.stop();
    }

    public bool isStarted() =>
        _raw.isStarted();

    public int canDeviceSendSms() =>
        _raw.canDeviceSendSms();

    public string getApiVersion() =>
        _raw.getApiVersion();

    public GDirectionsManager getDirectionsManager() =>
        new DirectionsManager((GlyDirectionsManager)_raw.getDirectionsManager());

    public int getEtaMode() =>
        _raw.getEtaMode();

    public int getSmsSendMode() =>
        _raw.getSmsSendMode();

    public GUserManager getUserManager() =>
        new UserManager((GlyUserManager)_raw.getUserManager());

    public GConsentManager getConsentManager() =>
        new ConsentManager((GlyConsentManager)_raw.getConsentManager());

    public GCustomerPickupManager getCustomerPickupManager() =>
        new CustomerPickupManager((GlyCustomerPickupManager)_raw.getCustomerPickupManager());

    public GChatManager getChatManager() =>
        new ChatManager((GlyChatManager)_raw.getChatManager());

    public bool sendTicket(GTicket ticket) =>
        _raw.sendTicket((GlyTicket)ticket.raw());

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

    public GConfig getConfig() =>
        new Config((GlyConfig)_raw.getConfig());

    public object raw() =>
        _raw;
}