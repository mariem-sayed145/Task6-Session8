using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_Session8
{
    class Duration
    {
        public int Hours;
        public int Minutes;
        public int Seconds;

        public override string ToString()
        {
            return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
        }

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

        public override int GetHashCode()
        {
            return Hours + Minutes + Seconds;
        } 
    }
}
