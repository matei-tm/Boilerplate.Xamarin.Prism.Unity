using XamaPrisUnit.Services;
using XamaPrisUnit.Droid.Services;
using Prism;
using Prism.Ioc;

namespace XamaPrisUnit.Droid
{
    public class AndroidInitializer : IPlatformInitializer
    {
        static BatteryService batteryService = new BatteryService();

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterInstance<IBatteryService>(batteryService);
        }
    }

}

