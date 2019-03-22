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

        private Entry _addressEntry;
        private Button _buttonSendTicket;

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

        public App(GGlympseFactory glympseFactory)
        {
            GlympseWrapper.Instance.Initialize(glympseFactory);

            Label recipientLabel = new Label();
            recipientLabel.Text = "Recipient e-mail";

            _addressEntry = new Entry();
            _addressEntry.Placeholder = "email";

            _buttonSendTicket = new Button();
            _buttonSendTicket.Text = "Send Ticket";
            _buttonSendTicket.Clicked += ButtonSendTicket_Clicked;

            MainPage = new ContentPage();
            _layout = new StackLayout();
            _layout.VerticalOptions = LayoutOptions.Center;
            _layout.Children.Add(recipientLabel);
            _layout.Children.Add(_addressEntry);
            _layout.Children.Add(_buttonSendTicket);
            ((ContentPage)MainPage).Content = _layout;
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

        private void ButtonSendTicket_Clicked(object sender, EventArgs e)
        {
            if (null != _addressEntry.Text)
            {
                // Send Ticket
                GInvite invite = GlympseWrapper.Instance.GlympseFactory.createInvite(GlympseConstants.INVITE_TYPE_EMAIL, "", _addressEntry.Text);
                GPlace destination = GlympseWrapper.Instance.GlympseFactory.createPlace(47.6205099, -122.3514714, "Space Needle");
                GTicket ticket = GlympseWrapper.Instance.GlympseFactory.createTicket(60000, "Xamarin Test", destination);
                GlympseWrapper.Instance.Glympse.sendTicket(ticket);
            }
        }
    }
}

