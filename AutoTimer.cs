using Timer = System.Threading.Timer;

namespace RoadTime
{
    static class AutoTimer
    {
        private static Timer timer;
        
        private const long interval = 54321; // интервал таймера 54 секунды

        public static void Initialize() //Инициализация таймера
        {
            timer = new Timer(new TimerCallback(CheckTimers), null, 0, interval);  //коллбек при достижении интервала
        }

        static void CheckTimers(object? obj)  
        {
            foreach (DateTime timer in AppSettings.timers)
            {
                if (timer.Hour == DateTime.Now.Hour && timer.Minute == DateTime.Now.Minute)
                {
                    AppSettings.GetRoadTimeBetweenAllAddresses();
                }
            }
        }
    }
}
