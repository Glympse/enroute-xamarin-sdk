using System;
using Android.OS;
using Android.App;
using NUnit.Framework;
using Glympse.EnRoute;
using Glympse.EnRoute.Android;

namespace EnRouteApi.Android.Tests
{
    [TestFixture]
    public class EnRouteManagerTests
    {
        GEnRouteManager _enRouteManager;

        [SetUp]
        public void Setup() 
        {

        }

        [TearDown]
        public void Tear() { }

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
                prepareLooperIfNeeded();
                GEnRouteFactory enRouteFactory = new EnRouteFactory(Application.Context);
                _enRouteManager = enRouteFactory.createEnRouteManager();
            }
        }

        private void prepareLooperIfNeeded()
        {
            if ( Looper.MyLooper() == null )
            {
                Looper.Prepare();
            }
        }
    }
}
