using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using dymaptic.GeoBlazor.RenderModes.Shared.Services;
using dymaptic.GeoBlazor.RenderModes.Web.Client.Services;
using dymaptic.GeoBlazor.Core;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Add device-specific services used by the dymaptic.GeoBlazor.RenderModes.Shared project
builder.Services.AddSingleton<IFormFactor, FormFactor>();

builder.Services.AddGeoBlazor(builder.Configuration);

await builder.Build().RunAsync();
