using Workout.Service;
using Workout.ViewModel;

namespace Workout;

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

		builder.Services.AddSingleton<ExerciceService>();

		builder.Services.AddSingleton<ExerciceListViewModel>();

		builder.Services.AddSingleton<MainPage>();

		return builder.Build();
	}
}
