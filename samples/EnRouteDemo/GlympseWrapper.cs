using System;

using Glympse;
using Glympse.Toolbox;
using Glympse.EnRoute;

namespace EnRouteDemo
{
    public class GlympseWrapper
    {
        private static string BASE_URL = "api.glympse.com";
        private static string API_KEY = "<< TODO ADD API KEY>>";
        private static GlympseWrapper instance;

        private GGlympseFactory _glympseFactory;
        private GGlympse _glympse;

        private GlympseWrapper()
        {
        }

        public static GlympseWrapper Instance
        {
            get
            {
                if (null == instance)
                {
                    instance = new GlympseWrapper();
                }
                return instance;
            }
        }

        public void Initialize(GGlympseFactory glympseFactory)
        {
            if (API_KEY.Equals("<< TODO ADD API KEY>>"))
            {
                throw new Exception("You must add an API Key to GlympseWrapper.cs");
            }

            _glympseFactory = glympseFactory;
            _glympse = glympseFactory.createGlympse(BASE_URL, API_KEY);
            _glympse.overrideLoggingLevels(1, 1); // Increases logging levels. Turn off for production deployments
            _glympse.getConsentManager().exemptFromConsent(true);
            _glympse.start();
        }

        public GGlympseFactory GlympseFactory
        {
            get
            {
                if (null == _glympseFactory)
                {
                    throw new Exception("GlympseWrapper.Initialize(...) must be called once before accessing the GlympseFactory property");
                }

                return _glympseFactory;
            }
        }

        public GGlympse Glympse
        {
            get
            {
                if (null == _glympse)
                {
                    throw new Exception("GlympseWrapper.Initialize(...) must be called once before accessing the Glympse property");
                }

                return _glympse;
            }
        }
    }
}
