namespace WhatsappNoContact;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
    }

    protected override Window CreateWindow(IActivationState activationState)
    {

        var window = base.CreateWindow(activationState);
#if WINDOWS
        const int newWidth = 400;
        const int newHeight = 400;

        window.Width = newWidth;
        window.Height = newHeight;
        window.MaximumHeight = newHeight;
        window.MaximumWidth = newWidth;
        window.MinimumHeight = newHeight;
        window.MinimumWidth = newWidth;
#endif
        return window;

    }
}
