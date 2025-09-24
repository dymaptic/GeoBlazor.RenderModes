# 🎉 BlazorDay 2025 - GeoBlazor Render Modes Demo

Welcome to the **BlazorDay 2025** GeoBlazor Render Modes demonstration! This sample application showcases the incredible power and flexibility of Blazor's different render modes with interactive GeoBlazor mapping components.

## 🚀 What You'll Discover

Explore how Blazor's render modes (Static, Server, WebAssembly, and Auto) work seamlessly with rich mapping components. Experience the future of modern web development where you can:

- **🖥️ Interactive Server** - Real-time updates with server-side processing
- **⚡ WebAssembly** - Client-side execution with full .NET runtime in the browser  
- **🔄 Interactive Auto** - Automatically switches between Server and WebAssembly for optimal performance

### Features You'll Experience
- Interactive maps with real-time weather data
- Bookmarking and spatial analysis tools
- Click-to-add functionality with 3D scenes
- Layer management and visualization controls

## 🛠️ Getting Started

Follow these steps to get your BlazorDay 2025 demo up and running:

### 1. Get Your ArcGIS API Key
Get an API Key from the [ArcGIS Location Platform](https://location.arcgis.com/).

### 2. Configure Your API Key
Place your API key in the `appsetting.json` and `appsetting.Development.json` files for each rendering version of the application.

If you chose render-mode `Auto`, you should have it in the `.Web` and `.Web.Client.wwwroot` folders, as well as the `.Maui` folder. There should be a file with placeholders in all the expected locations.

```json
{
    "ArcGISApiKey": "YourArcGISApiKey"
}
```

### 3. Get Your GeoBlazor License
Register at [licensing.dymaptic.com](https://licensing.dymaptic.com) for a free GeoBlazor Core Registration key, or to purchase a GeoBlazor Pro license key with additional features and support.

Add the key to all the `appsettings.json`/`appsettings.Development.json`/`secrets.json` files:

```json
{
    "ArcGISApiKey": "YourArcGISApiKey",
    "GeoBlazor": {
        // GeoBlazor Core
        "RegistrationKey": "YourGeoBlazorRegistrationKey"
        // GeoBlazor Pro
        "LicenseKey": "YourGeoBlazorProLicenseKey"
    }
}
```

### 4. Run and Explore! 🎯
Run the MAUI or Web project and explore the different render modes. You'll see interactive maps demonstrating the power of Blazor across multiple pages.

## 🌟 About BlazorDay 2025

This demonstration celebrates the amazing capabilities of Blazor and its ecosystem. Built with:

- **.NET 9** - The latest and greatest from Microsoft
- **Blazor** - Full-stack web development with C#
- **GeoBlazor** - Rich mapping components for Blazor
- **ArcGIS** - World-class mapping and spatial analysis

## 🔗 Learn More

- Visit [BlazorDay.net](https://blazorday.net/) for more Blazor content and community
- Explore [GeoBlazor](https://geoblazor.com) for advanced mapping scenarios
- Check out the [ArcGIS Platform](https://www.arcgis.com/index.html) for spatial data and services

---

*Happy coding and welcome to BlazorDay 2025! 🎊*
