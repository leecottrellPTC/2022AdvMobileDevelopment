using Microsoft.Extensions.Configuration;
using MVVMBaseballPitchCounter.ViewModels;
using System.Reflection;

namespace MVVMBaseballPitchCounter;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		//add this
		//builds the file within the data storage for the app
		string dbPath = System.IO.Path.Combine(FileSystem.AppDataDirectory, "pitcher.db3");
		builder.Services.AddSingleton<PitcherDatabase>(s => ActivatorUtilities.CreateInstance<PitcherDatabase>(s, dbPath));


        return builder.Build();
	}
}
