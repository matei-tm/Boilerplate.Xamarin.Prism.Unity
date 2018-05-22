using XamaPrisUnit.iOS.Services;
using XamaPrisUnit.Services;
using Prism;
using Prism.Ioc;
using Prism.Unity;

namespace XamaPrisUnit.iOS
{
    public class iOSInitializer : IPlatformInitializer
    {
        static BatteryService batteryService = new BatteryService();

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterInstance<IBatteryService>(batteryService);
        }
    }
}
