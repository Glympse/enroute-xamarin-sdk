using Glympse.Toolbox;

namespace Glympse.EnRoute.iOS;

public class EnRouteManager : GEnRouteManager, CommonSource.GGlySource
{
    GlyEnRouteManager _raw;

    CommonSource _source;

    public EnRouteManager(GlyEnRouteManager raw)
    {
        _raw = raw;
        _source = new CommonSource(this);
    }

    /**
     * GEnRouteManager section
     */

    public bool isLoginNeeded() =>
        _raw.isLoginNeeded();

    public bool loginWithCredentials(string username, string password) =>
        _raw.loginWithCredentials(username, password);

    public bool loginWithToken(string token, long expireTime) =>
        _raw.loginWithToken(token, expireTime);

    public void logout(int reason)
    {
        _raw.logout(reason);
    }

    public bool start() =>
        _raw.start();

    public void stop()
    {
        _raw.stop();
    }           

    public bool isStarted() =>
        _raw.isStarted();

    public void setActive(bool active)
    {
        _raw.setActive(active);
    }

    public bool isActive() =>
        _raw.isActive();

    public void setAuthenticationMode(int mode)
    {
        _raw.setAuthenticationMode(mode);
    }

    public int getAuthenticationMode() =>
        _raw.getAuthenticationMode();

    public void refresh()
    {
        _raw.refresh();
    }

    public GGlympse getGlympse() =>
        (GGlympse)ClassBinder.bind(_raw.getGlympse());

    public GOrganization getOrganization() =>
        (GOrganization)ClassBinder.bind(_raw.getOrganization());

    public GAgent getLoggedInAgent() =>
        (GAgent)ClassBinder.bind(_raw.getLoggedInAgent());

    public string getEnRouteToken() =>
        _raw.getEnRouteToken();

    public GTaskManager getTaskManager() =>
        (GTaskManager)ClassBinder.bind(_raw.getTaskManager());

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

    /**
     * GSource section
     */

    public bool addListener(GListener listener) =>
        _source.addListener(listener);

    public bool removeListener(GListener listener) =>
        _source.removeListener(listener);

    public bool addListener(GlyListener listener) =>
        _raw.addListener(listener);

    public bool removeListener(GlyListener listener) =>
        _raw.removeListener(listener);

    /**
     * GCommon section
     */

    public object raw() =>
        _raw;
}

