using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build_Cronometro
{
    public class ArgsElapse
    {
        public ArgsElapse(Clock c, TimeSpan time)
        {
            this.c = c;
            this.time = time;
        }

        private Clock c;
        private TimeSpan time;

        public override string ToString()
        {
            return string.Format("{0:00}:{1:00}:{2:00}", c.Hours, c.Minutes, c.Seconds);
        }

        public string TimeElapsed()
        {
            return Convert.ToString(time - TimeSpan.Parse("00:00:01"));
        }

    }
}
