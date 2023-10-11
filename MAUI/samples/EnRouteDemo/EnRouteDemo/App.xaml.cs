namespace EnRouteDemo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}

    protected override Window CreateWindow(IActivationState activationState)
    {
        Window window = base.CreateWindow(activationState);

        window.Activated += (s, e) =>
        {
            EnRouteManagerWrapper.Instance.Manager.setActive(true);
        };

        window.Deactivated += (s, e) =>
        {
            EnRouteManagerWrapper.Instance.Manager.setActive(false);
        };

        return window;
    }
}

