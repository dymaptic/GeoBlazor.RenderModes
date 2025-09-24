namespace dymaptic.GeoBlazor.RenderModes.Maui;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new MainPage()) { Title = "dymaptic.GeoBlazor.RenderModes.Maui" };
    }
}
