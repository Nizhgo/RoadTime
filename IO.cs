using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace RoadTime
{
    static class IO
    {
        static string exePath = AppDomain.CurrentDomain.BaseDirectory; 

        public static void GetLocalData()
        {
            string path = Path.Combine(exePath, @"Data\travelTimeData.json");
            string input = File.ReadAllText(path);
            var duratiomResult = JsonConvert.DeserializeObject<List<TravelTimeData>>(input);
            if (duratiomResult != null)
                AppSettings.travelTimeData = duratiomResult;
            path = Path.Combine(exePath, @"Data\address.json");
            input = File.ReadAllText(path);
            var adressList = JsonConvert.DeserializeObject<List<string>>(input);
            if (adressList != null)
                AppSettings.address = adressList;
        }

        public static void LocalSaveTravelTime()
        {
            var options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            var json = System.Text.Json.JsonSerializer.Serialize<List<TravelTimeData>>(AppSettings.travelTimeData, options);
            var path = Path.Combine(exePath, @"Data\travelTimeData.json");
            System.IO.File.WriteAllText(path, json);
        }

        public static string SaveJsonDuration()
        {
            var json = System.Text.Json.JsonSerializer.Serialize<List<TravelTimeData>>(AppSettings.travelTimeData);
            return json;
        }

        public static void LocalSaveAddress()
        {
            var json = System.Text.Json.JsonSerializer.Serialize<List<string>>(AppSettings.address);
            var path = Path.Combine(exePath, @"Data\address.json");
            System.IO.File.WriteAllText(path, json);
        }

        public static bool AddAddress(string input)
        {
            if (!string.IsNullOrEmpty(input) &&
                (AppSettings.address != null) ? !AppSettings.address.Contains(input): true &&
                input.Replace(" ", "").Length > 2)
            {
                AppSettings.address.Add(input);
                IO.LocalSaveAddress();
                return true;
            }
            return false;

        }

        public static bool SetTimers(string input)
        {
            string[] separated = input.Split(",");
            List<DateTime> candidate = new();
            foreach (string s in separated)
            {
                if (s.Split(":").Length == 2 &&
                    int.Parse(s.Split(":")[0]) >= 0 &&
                    int.Parse(s.Split(":")[0]) < 24 &&
                    int.Parse(s.Split(":")[1]) >= 0 &&
                    int.Parse(s.Split(":")[1]) < 60)
                {
                    DateTime tmp = new();
                    var hours = int.Parse(s.Split(":")[0]);
                    tmp = tmp.AddHours(int.Parse(s.Split(":")[0]));
                    tmp = tmp.AddMinutes(int.Parse(s.Split(":")[1]));
                    candidate.Add(tmp);
                }
                else
                    return false;
            }
            AppSettings.timers.AddRange(candidate);
            return true;
        }

        internal static bool DeleteAdress(int index)
        {
            if (AppSettings.address.Count >= index)
            {
                AppSettings.address.RemoveAt(index);
                IO.LocalSaveAddress();
                return true;
            }
            return false;
        }
    }
}
