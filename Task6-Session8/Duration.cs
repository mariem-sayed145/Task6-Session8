using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_Session8
{
    class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        // Constructor: Hours, Minutes, Seconds
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        // Constructor: Total Seconds
        public Duration(int totalSeconds)
        {
            if (totalSeconds < 0)
                totalSeconds = 0;

            Hours = totalSeconds / 3600;

            totalSeconds %= 3600;

            Minutes = totalSeconds / 60;
            Seconds = totalSeconds % 60;
        }

        // Convert Duration to total seconds
        private int ToTotalSeconds()
        {
            return Hours * 3600 +
                   Minutes * 60 +
                   Seconds;
        }

        // ToString
        public override string ToString()
        {
            if (Hours > 0)
                return $"Hours: {Hours}, Minutes :{Minutes}, Seconds :{Seconds}";

            if (Minutes > 0)
                return $"Minutes :{Minutes}, Seconds :{Seconds}";

            return $"Seconds :{Seconds}";
        }

        // Equals
        public override bool Equals(object obj)
        {
            if (obj is Duration other)
            {
                return Hours == other.Hours &&
                       Minutes == other.Minutes &&
                       Seconds == other.Seconds;
            }

            return false;
        }

        // GetHashCode
        public override int GetHashCode()
        {
            return Hours+ Minutes+ Seconds ;
        }

        // Duration + Duration
        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(
                d1.ToTotalSeconds() +
                d2.ToTotalSeconds()
            );
        }

        // Duration + int
        public static Duration operator +(Duration d, int seconds)
        {
            return new Duration(
                d.ToTotalSeconds() + seconds
            );
        }

        // int + Duration
        public static Duration operator +(int seconds, Duration d)
        {
            return new Duration(
                seconds + d.ToTotalSeconds()
            );
        }

        // ++ : Increase one minute
        public static Duration operator ++(Duration d)
        {
            return new Duration(
                d.ToTotalSeconds() + 60
            );
        }

        // -- : Decrease one minute
        public static Duration operator --(Duration d)
        {
            int totalSeconds = d.ToTotalSeconds() - 60;

            if (totalSeconds < 0)
                totalSeconds = 0;

            return new Duration(totalSeconds);
        }

        // Duration - Duration
        public static Duration operator -(Duration d1, Duration d2)
        {
            int totalSeconds =
                d1.ToTotalSeconds() -
                d2.ToTotalSeconds();

            if (totalSeconds < 0)
                totalSeconds = 0;

            return new Duration(totalSeconds);
        }

        // >
        public static bool operator >(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() >
                   d2.ToTotalSeconds();
        }

        // <
        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() <
                   d2.ToTotalSeconds();
        }

        // >=
        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() >=
                   d2.ToTotalSeconds();
        }

        // <=
        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() <=
                   d2.ToTotalSeconds();
        }

        // Duration -> bool
        public static implicit operator bool(Duration d)
        {
            return d != null &&
                   d.ToTotalSeconds() > 0;
        }

        // Duration -> DateTime
        public static explicit operator DateTime(Duration d)
        {
            return DateTime.Today
                .AddHours(d.Hours)
                .AddMinutes(d.Minutes)
                .AddSeconds(d.Seconds);
        }
    }
}
