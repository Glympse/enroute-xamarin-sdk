using System;
using Glympse.Toolbox;

namespace Glympse
{
    namespace EnRoute
    {
        public interface GEnRouteManager : GSource
        {
            bool login(string username, string password);

            bool login(string token, long expiresIn);

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
        }
    }
}
