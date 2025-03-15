using Straad.Course.HUP.NetMauiUiChallengesAi.Views;

namespace Straad.Course.HUP.NetMauiUiChallengesAi;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new DashboardView());
    }
}