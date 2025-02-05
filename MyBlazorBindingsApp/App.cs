using BlazorBindings.Maui;

namespace MyBlazorBindingsApp
{
    public class App : BlazorBindingsApplication<AppShell>
    {
        public App(IServiceProvider services) : base(services)
        {
        }
    }
}
