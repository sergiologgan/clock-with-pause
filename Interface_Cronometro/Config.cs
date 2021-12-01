using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Cronometro
{
    public class Config
    {
        // sound
        public string SoundStop { get; set; }
        public string SoundPause { get; set; }
        public bool SoundStopEnabled { get; set; }
        public bool SoundPauseEnabled { get; set; }
        public string SoundStopEnabledText { get; set; }
        public string SoundPauseEnabledText { get; set; }

        // notification
        public string TitleStop { get; set; }
        public string TitlePause { get; set; }
        public string ContentStop { get; set; }
        public string ContentPause { get; set; }
        public bool EnabledNotificationStop { get; set; }
        public bool EnabledNotificationPause { get; set; }
        public string EnabledNotificationStopText { get; set; }
        public string EnabledNotificationPauseText { get; set; }
        public bool FicarEmSegundoPlano { get; set; }


    }
}
