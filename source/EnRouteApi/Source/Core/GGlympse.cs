namespace Glympse;

public interface GGlympse : GCommon
{
    void start();

    void stop();

    bool isStarted();

    GUserManager getUserManager();

    GDirectionsManager getDirectionsManager();

    GConsentManager getConsentManager();

    GCustomerPickupManager getCustomerPickupManager();

    GChatManager getChatManager();

    bool sendTicket(GTicket ticket);

    int getSmsSendMode();

    void setSmsSendMode(int mode);

    int canDeviceSendSms();

    int getEtaMode();

    void setEtaMode(int mode);

    string getApiVersion();

    void overrideLoggingLevels(int fileLevel, int debugLevel);

    GConfig getConfig();
}