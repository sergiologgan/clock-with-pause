using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build_Cronometro
{
    public class Time
    {   
        private int seconds;

        public int Seconds
        {
            get { return seconds; }
            set { seconds = value; }
        }

        private int minutes;

        public int Minutes
        {
            get { return minutes; }
            set { minutes = value; }
        }

        private int hours;

        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }
    }
}
