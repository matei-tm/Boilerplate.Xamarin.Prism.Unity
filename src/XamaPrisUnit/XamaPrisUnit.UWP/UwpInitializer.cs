using XamaPrisUnit.Services;
using XamaPrisUnit.UWP.Services;
using Prism;
using Prism.Ioc;

namespace XamaPrisUnit.UWP
{
    public class UwpInitializer : IPlatformInitializer
    {
        static BatteryService batteryService = new BatteryService();

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterInstance<IBatteryService>(batteryService);
        }
    }
}
