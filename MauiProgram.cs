﻿using Work0ut.Service;
using Work0ut.ViewModel;

namespace Work0ut;

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
		builder.Services.AddSingleton<WorkoutService>();

		builder.Services.AddSingleton<MainViewModel>();
		builder.Services.AddSingleton<ExerciceListViewModel>();
		builder.Services.AddSingleton<WorkoutViewModel>();

		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<ExerciceListPage>();
		builder.Services.AddSingleton<WorkoutPage>();
		builder.Services.AddSingleton<SetPage>();

		return builder.Build();
	}
}
