using Foundation;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace MauiAppReactor
{
    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}
