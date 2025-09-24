using dymaptic.GeoBlazor.RenderModes.Shared.Services;

namespace dymaptic.GeoBlazor.RenderModes.Web.Client.Services;

public class FormFactor : IFormFactor
{
    public string GetFormFactor()
    {
        return "WebAssembly";
    }

    public string GetPlatform()
    {
        return Environment.OSVersion.ToString();
    }
}
