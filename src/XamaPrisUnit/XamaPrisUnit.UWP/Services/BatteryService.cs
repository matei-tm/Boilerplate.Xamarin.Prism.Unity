using XamaPrisUnit.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Power;
using Windows.System.Power;

namespace XamaPrisUnit.UWP.Services
{
    public class BatteryService : IBatteryService
    {
        public string GetBatteryStatus()
        {
            // Create aggregate battery object
            var aggBattery = Battery.AggregateBattery;

            // Get report
            var report = aggBattery.GetReport();

            switch (report.Status)
            {
                case BatteryStatus.Charging:
                    return "Charging";
                case BatteryStatus.Idle:
                    return "Idle";
                case BatteryStatus.Discharging:
                    return "Discharging";
                case BatteryStatus.NotPresent:
                    return "NotPresent";
                default:
                    return "Unknown";
            }
        }
    }
}
