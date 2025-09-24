using Microsoft.AspNetCore.StaticFiles;
using dymaptic.GeoBlazor.RenderModes.Web.Components;
using dymaptic.GeoBlazor.RenderModes.Shared.Services;
using dymaptic.GeoBlazor.RenderModes.Web.Services;
using dymaptic.GeoBlazor.Core;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

// Add device-specific services used by the dymaptic.GeoBlazor.RenderModes.Shared project
builder.Services.AddSingleton<IFormFactor, FormFactor>();

builder.Services.AddGeoBlazor(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.MapStaticAssets();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(
        typeof(dymaptic.GeoBlazor.RenderModes.Shared._Imports).Assembly,
        typeof(dymaptic.GeoBlazor.RenderModes.Web.Client._Imports).Assembly);
app.Run();
