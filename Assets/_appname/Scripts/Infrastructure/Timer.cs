using System;

namespace Appname.Infrastructure
{
    public static class Timer
    {
        public static readonly DateTime Epoch = new DateTime(1970, 1, 1);

        public static DateTime GetCurrentDateTime()
        {
            return DateTime.UtcNow;
        }

        public static int GetCurrentUnixTimeStamp()
        {
            return ToUnixTimeStamp(GetCurrentDateTime());
        }

        public static int ToUnixTimeStamp(DateTime dateTime)
        {
            return (int)(dateTime - Epoch).TotalSeconds;
        }

        public static DateTime ToDateTime(int unixTimeStamp)
        {
            return Epoch.AddSeconds(unixTimeStamp);
        }

        public static long ConvertToMilliseconds(float seconds)
        {
            return (long)(seconds * 1000f);
        }
    }
}
