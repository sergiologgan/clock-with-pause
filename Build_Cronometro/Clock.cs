using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Build_Cronometro
{
    public class Clock : Time
    {
        public Clock()
        {
            timer.Tick += new EventHandler(OnTimedEvent);
            status = Situation.stopped;
        }

        public delegate void EventLoad(object sender, ArgsClock e);
        public event EventLoad Load;
        public delegate void EventStopAlone(object sender, ArgsClock e);
        public event EventStopAlone StopAlone;
        public delegate void EventPauseAlone(object sender, ArgsClock e);
        public event EventPauseAlone PauseAlone;
        public delegate void EventTimeElapse(object sender, ArgsElapse e);
        public event EventTimeElapse TimeElapse;

        private Timer timer = new Timer();       
        private TimeSpan time;
        private TimeSpan timePause;        
        private bool isRunning = false;
        private string firstTime;
        private string firstPause;
        private TimeSpan timeElapsed;
        public enum Situation { paused, initiated, stopped };

       
        public void Start()
        {
            if (isRunning == false)
            {
                timer.Interval = 1000;
                if (Hours > 0 || Minutes > 0 || Seconds > 0)
                {
                    time = new TimeSpan(Hours, Minutes, Seconds + 1);
                }                
                this.timer.Start();
                isRunning = true;
            }
            firstTime = time.ToString();
            status = Situation.initiated;
            //Load(this, new ArgsLoad(this));
        }

        public void Stop()
        {
            time = TimeSpan.Parse(FirstTime);
            timePause = TimeSpan.Parse(firstPause);
            timeElapsed = new TimeSpan();
            Hours = time.Hours;
            Minutes = time.Minutes;
            Seconds = time.Seconds;            
            this.timer.Stop();
            isRunning = false;
            status = Situation.stopped;            
        }

        public void Continue()
        {
            if (timeElapsed >= timePause)
            {
                timePause += TimeSpan.Parse(firstPause);
            }
            this.timer.Start();
            isRunning = true;
            status = Situation.initiated;
        }

        public void Pause()
        {
            if (status != Situation.stopped)
            {
                this.timer.Stop();
                isRunning = true;
                status = Situation.paused;
            }           
        }

        private void OnTimedEvent(object source, EventArgs e)
        {
            if (time > TimeSpan.Parse("00:00:00"))
            {
                if (timeElapsed <= timePause || timePause <= TimeSpan.Parse("00:00:00"))
                {
                    time -= TimeSpan.Parse("00:00:01");
                    timeElapsed += TimeSpan.Parse("00:00:01");
                    Hours = time.Hours;
                    Minutes = time.Minutes;
                    Seconds = time.Seconds;

                    this.TimeElapse(this, new ArgsElapse(this, timeElapsed));
                }
                else
                {
                    Pause();
                    this.PauseAlone(this, new ArgsClock(this));                
                }
            }
            else
            {
                Stop();
                this.StopAlone(this, new ArgsClock(this));        
            }      
        }

        public void ParsePauseTime(string time)
        {
            try
            {
                timePause = new TimeSpan();
                timePause = TimeSpan.Parse(time);
                firstPause = timePause.ToString();
            }
            catch { }
        }

        public void ParsePauseTime(int hour, int minute, int second)
        {
            timePause = new TimeSpan(hour, minute, second);
            firstPause = timePause.ToString();
        }

        public void Parse(string s)
        {
            time = TimeSpan.Parse(s);
            Hours = time.Hours;
            Minutes = time.Minutes;
            Seconds = time.Seconds + 1;
        }

        public int Interval
        {
            get { return this.timer.Interval; }
            set { this.timer.Interval = value; }
        }

        public string FirstTime
        {
            get { return firstTime; }           
        }

        private Situation status;
        public Situation Status
        {
            get { return status; }
        }

        public bool IsRunning()
        {
            return isRunning;
        }

        public override string ToString()
        {
            return string.Format("{0:00}:{1:00}:{2:00}", Hours, Minutes, Seconds);
        }
    }   
}
