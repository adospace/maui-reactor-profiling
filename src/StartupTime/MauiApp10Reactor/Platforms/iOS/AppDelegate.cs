using Foundation;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace MauiApp10Reactor
{
    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}
