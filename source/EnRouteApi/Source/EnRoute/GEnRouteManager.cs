using System;
using Glympse.Toolbox;

namespace Glympse
{
    namespace EnRoute
    {
        public interface GEnRouteManager : GSource
        {
            bool isLoginNeeded();

            void setAuthenticationMode(int mode);

            int getAuthenticationMode();

            bool loginWithCredentials(string username, string password);

            bool loginWithToken(string token, long expireTime);

            void logout(int reason);

            bool start();

            void stop();        

            bool isStarted();

            void setActive(bool active);

            bool isActive();

            void refresh();

            GOrganization getOrganization();

            GAgent getLoggedInAgent();

            string getEnRouteToken();

            GTaskManager getTaskManager();
            
            void handleRemoteNotification(string payload);
            
            void registerDeviceToken(string tokenType, string deviceToken);

            void overrideLoggingLevels(int fileLevel, int debugLevel);

            void enableXoANotifications(bool enabled);
        }
    }
}
