using System;
using Windows.ApplicationModel.ExtendedExecution;

namespace EnRouteDemo
{
    class ExtendedExecutionManager
    {
        private static ExtendedExecutionManager _instance;
        private ExtendedExecutionSession _extendedExecutionSession;

        public static ExtendedExecutionManager Instance
        {
            get
            {
                if ( null == _instance )
                {
                    _instance = new ExtendedExecutionManager();
                }
                return _instance;
            }
        }

        public async void BeginExtendedExecutionIfNeeded()
        {
            try
            {
                if ( null == _extendedExecutionSession )
                {
                    // Start the extended execution session.
                    ExtendedExecutionSession extendedExecutionSession = new ExtendedExecutionSession();
                    extendedExecutionSession.Reason = ExtendedExecutionReason.LocationTracking;
                    extendedExecutionSession.Description = "Tracking your location";
                    extendedExecutionSession.Revoked += ExtendedExecutionSession_Revoked;
                    ExtendedExecutionResult extendedExecutionResult = await extendedExecutionSession.RequestExtensionAsync();

                    switch (extendedExecutionResult)
                    {
                        case ExtendedExecutionResult.Allowed:
                            _extendedExecutionSession = extendedExecutionSession;
                            break;

                        case ExtendedExecutionResult.Denied:
                        default:
                            extendedExecutionSession.Dispose();
                            break;
                    }
                }
            }
            catch (Exception e)
            {
            }
        }

        public void EndExtendedExecution()
        {
            if ( null != _extendedExecutionSession )
            {
                _extendedExecutionSession.Revoked -= ExtendedExecutionSession_Revoked;
                _extendedExecutionSession.Dispose();
                _extendedExecutionSession = null;
            }
        }

        private void ExtendedExecutionSession_Revoked(object sender, ExtendedExecutionRevokedEventArgs args)
        {
            EndExtendedExecution();
        }
    }
}
