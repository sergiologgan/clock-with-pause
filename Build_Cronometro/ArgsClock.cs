using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Build_Cronometro;

namespace Build_Cronometro
{
    public class ArgsClock
    {

        public ArgsClock(Clock c)
        {
            this.c = c;
        }

        private Clock c;

        public override string ToString()
        {
            return string.Format("{0:00}:{1:00}:{2:00}", c.Hours, c.Minutes, c.Seconds);
        }
    }
}
