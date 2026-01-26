using Microsoft.Extensions.Logging;

namespace EnRouteDemo;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		AppDomain.CurrentDomain.FirstChanceException += (sender, eventArgs) =>
		{
			System.Diagnostics.Debug.WriteLine($"First chance exception: {eventArgs.Exception}");
		};

		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

