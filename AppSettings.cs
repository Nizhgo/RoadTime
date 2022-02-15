using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadTime
{
    static class AppSettings
    {
        public static List<string>? address = new();
        public static List<TravelTimeData>? travelTimeData = new();
        public static List<DateTime>? timers = new();



        public static void GetRoadTimeBetweenAllAddresses()
        {
            var from = AppSettings.address.First();
            foreach (var startAddress in AppSettings.address)
            foreach (var endAddress in AppSettings.address)
            {
                if (startAddress != endAddress)
                {
                    var duration = GoogleMapsDirectionApi.GetRoadDuration(startAddress, endAddress);
                    AppSettings.travelTimeData.Add(new TravelTimeData(startAddress, endAddress, duration));
                }
            }
            IO.LocalSaveTravelTime();
        }
    }
}

