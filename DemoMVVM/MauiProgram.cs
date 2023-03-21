using DemoMVVM.ViewModels;
using DemoMVVM.Views;

namespace DemoMVVM;

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

		builder.Services.AddTransient<ProductSimpleViewModel>();
		builder.Services.AddTransient<ProductView>();

		return builder.Build();
	}
}
