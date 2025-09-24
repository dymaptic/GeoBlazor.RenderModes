using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using dymaptic.GeoBlazor.RenderModes.Shared.Services;
using dymaptic.GeoBlazor.RenderModes.Services;
using System.Reflection;
using dymaptic.GeoBlazor.Core;

namespace dymaptic.GeoBlazor.RenderModes.Maui;

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
            });

        // Add device-specific services used by the dymaptic.GeoBlazor.RenderModes.Shared project
        builder.Services.AddSingleton<IFormFactor, FormFactor>();

        builder.Services.AddMauiBlazorWebView();
        Assembly executingAssembly = Assembly.GetExecutingAssembly();

		using Stream stream = executingAssembly
			.GetManifestResourceStream(typeof(MauiProgram), "appsettings.json")!;
        using Stream? devStream = executingAssembly
            .GetManifestResourceStream(typeof(MauiProgram), "appsettings.Development.json");
        using Stream? prodStream = executingAssembly
            .GetManifestResourceStream(typeof(MauiProgram), "appsettings.Production.json");

		var configBuilder = new ConfigurationBuilder()
			.AddJsonStream(stream);
        if (devStream != null)
        {
            configBuilder.AddJsonStream(devStream);
        }

        if (prodStream != null)
        {
            configBuilder.AddJsonStream(prodStream);
        }

        IConfiguration config = configBuilder.Build();
		builder.Configuration.AddConfiguration(config);

		builder.Services.AddGeoBlazor(builder.Configuration);

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
