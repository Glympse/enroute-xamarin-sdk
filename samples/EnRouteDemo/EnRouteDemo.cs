using System;

using Xamarin.Forms;

using Glympse;
using Glympse.Toolbox;
using Glympse.EnRoute;

namespace EnRouteDemo
{
    public class App : Application
    {
        private StackLayout _layout;
        private Button _buttonLogout;
        private Button _buttonLogin;

        public App (GEnRouteFactory enRouteFactory)
        {
            EnRouteManagerWrapper.Instance.Initialize(enRouteFactory);

            _buttonLogout = new Button();
            _buttonLogout.Text = "Logout";
            _buttonLogout.Clicked += ButtonLogout_Clicked;

            _buttonLogin = new Button();
            _buttonLogin.Text = "Login";
            _buttonLogin.Clicked += ButtonLogin_Clicked;

            MainPage = new ContentPage();
            _layout = new StackLayout();
            _layout.VerticalOptions = LayoutOptions.Center;
            _layout.Children.Add(_buttonLogin);
            _layout.Children.Add(_buttonLogout);
            ((ContentPage)MainPage).Content = _layout;
            
            Auth.onAppStart(EnRouteManagerWrapper.Instance.Manager);
        }

        protected override void OnStart ()
        {
            
            // Handle when your app starts
        }

        protected override void OnSleep ()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume ()
        {
            // Handle when your app resumes
        }

        private void ButtonLogout_Clicked(object sender, EventArgs e)
        {
            //Logout
            EnRouteManagerWrapper.Instance.Manager.logout(EnRouteConstants.LOGOUT_REASON_USER_ACTION);
        }

        private void ButtonLogin_Clicked(object sender, EventArgs e)
        {
            // Login
            Auth.start(EnRouteManagerWrapper.Instance.Manager);
        }
    }
}

