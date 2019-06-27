using NUnit.Framework;
using Glympse.EnRoute;
using Glympse.EnRoute.iOS;

namespace EnRouteApi.iOS.Tests
{

    [TestFixture]
    public class EnRouteManagerTests
    {
        GEnRouteManager _enRouteManager;

        [Test]
        public void startEnRouteManager()
        {
            createEnRouteManager();
            _enRouteManager.setAuthenticationMode(EnRouteConstants.AUTH_MODE_CREDENTIALS);
            _enRouteManager.start();
            Assert.True(_enRouteManager.isStarted());
        }

        private void createEnRouteManager()
        {
            if (_enRouteManager == null)
            {
                GEnRouteFactory enRouteFactory = new EnRouteFactory();
                _enRouteManager = enRouteFactory.createEnRouteManager();
            }
        }
    }
}
