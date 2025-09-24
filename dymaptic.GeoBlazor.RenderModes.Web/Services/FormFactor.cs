using dymaptic.GeoBlazor.RenderModes.Shared.Services;

namespace dymaptic.GeoBlazor.RenderModes.Web.Services;

public class FormFactor : IFormFactor
{
    public string GetFormFactor()
    {
        return "Web";
    }

    public string GetPlatform()
    {
        return Environment.OSVersion.ToString();
    }
}
