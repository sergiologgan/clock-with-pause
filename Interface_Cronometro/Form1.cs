using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Build_Cronometro;
using Newtonsoft.Json;

namespace Interface_Cronometro
{
    public partial class Form1 : Form
    {
        private Clock cronometro = new Clock();
        private Config config;
        private SoundPlayer sound;

        public Form1()
        {
            InitializeComponent();

            this.txtHora.Focus();
            this.txtHora.Select();
            sound = new SoundPlayer();           
            this.btnContinue.Enabled = false;
            this.btnPause.Enabled = false;
            this.btnStart.Enabled = true;
            this.btnStop.Enabled = false;
            this.maskedTextBox1.Text = "00:00:00";
            UpdateConfig();
            cronometro.TimeElapse += new Clock.EventTimeElapse(Clock_Elapse);
            cronometro.Load += new Clock.EventLoad(Clock_Load);
            cronometro.StopAlone += new Clock.EventStopAlone(Clock_StopAlone);
            cronometro.PauseAlone += new Clock.EventPauseAlone(Clock_PauseAlone);
        }

        private void Clock_Elapse(object sender, ArgsElapse e)
        {
            this.lblTimer.Text = e.ToString();
            this.Temporizador.Text = e.ToString();
            this.lblPausa.Text = e.TimeElapsed();
        }

        private void Clock_Load(object sender, ArgsClock e)
        {
            
        }

        private void Clock_StopAlone(object sender, ArgsClock e)
        {                     
            this.lblTimer.Text = "FIM";
            this.lblPausa.Text = "";
            EnableAllTxts();
            EnableBtns(false, false, false, true);

            if (File.Exists(config.SoundStop) && config.SoundStopEnabled == true)
            {
                try
                {
                    sound = new SoundPlayer(config.SoundStop);
                    sound.Play();
                    this.btnPararSom.Visible = true;
                }
                catch (Exception) { MessageBox.Show(string.Format("Erro ao executar o toque{0}verifique se está no formato .wave", Environment.NewLine), "Configuração de Som", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            if (config.EnabledNotificationStop == true && config.TitleStop.Length > 0 && config.ContentStop.Length > 0)
            {
                Notification(config.TitleStop, config.ContentStop, ToolTipIcon.Info);
            }
        }

        private void Clock_PauseAlone(object sender, ArgsClock e)
        {
            EnableBtns(false, true, true, false);
            if (File.Exists(config.SoundPause) && config.SoundPauseEnabled == true)
            {
                try
                {
                    sound = new SoundPlayer(config.SoundPause);
                    sound.Play();
                    this.btnPararSom.Visible = true;
                }
                catch (Exception) { MessageBox.Show(string.Format("Erro ao executar o toque{0}verifique se está no formato .wave", Environment.NewLine), "Configuração de Som", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            if (config.EnabledNotificationPause == true && config.TitlePause.Length > 0 && config.ContentPause.Length > 0)
            {
                Notification(config.TitlePause, config.ContentPause, ToolTipIcon.Info);
            }
        }

        public void UpdateConfig()
        {
            string file = File.ReadAllText("file.json");
            config = JsonConvert.DeserializeObject<Config>(file);
            if (config == null)
            {
                config = new Config();
            }
        }       

        private void btnPause_Click(object sender, EventArgs e)
        {
            this.cronometro.Pause();
            EnableBtns(false, true, true, false);
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.btnPararSom.PerformClick();
            EnableBtns(true, false, true, false);
            cronometro.Continue();           
            try
            {
                sound.Stop();
            }
            catch{ }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (this.txtHora.Text.Length <= 0 && this.txtMin.Text.Length <= 0 && this.txtSec.Text.Length > 0)
            {
                this.txtHora.Text = "0";
                this.txtMin.Text = "0";
            }
            else if (this.txtHora.Text.Length <= 0 && this.txtMin.Text.Length > 0 && this.txtSec.Text.Length <= 0)
            {
                this.txtHora.Text = "0";
                this.txtSec.Text = "0";
            }
            else if (this.txtHora.Text.Length > 0 && this.txtMin.Text.Length <= 0 && this.txtSec.Text.Length <= 0)
            {
                this.txtMin.Text = "0";
                this.txtSec.Text = "0";
            }
            else if (this.txtHora.Text.Length > 0 && this.txtMin.Text.Length <= 0 && this.txtSec.Text.Length > 0)
            {
                this.txtMin.Text = "0";
            }
            else if (this.txtHora.Text.Length <= 0 && this.txtMin.Text.Length > 0 && this.txtSec.Text.Length > 0)
            {
                this.txtHora.Text = "0";
            }
            else if (this.txtHora.Text.Length > 0 && this.txtMin.Text.Length > 0 && this.txtSec.Text.Length <= 0)
            {
                this.txtSec.Text = "0";
            }

            if (Regex.IsMatch(this.txtHora.Text.Trim(), @"^[0-9]+$") &&
                Regex.IsMatch(this.txtMin.Text.Trim(), @"^[0-9]+$") &&
                Regex.IsMatch(this.txtSec.Text.Trim(), @"^[0-9]+$") &&
                Regex.IsMatch(this.maskedTextBox1.Text.Trim(), @"^[0-9:]+$"))
            {
                int hour = int.Parse(this.txtHora.Text);
                int min = int.Parse(this.txtMin.Text);
                int sec = int.Parse(this.txtSec.Text);
                TimeSpan timeCache = new TimeSpan(hour, min, sec);

                if (timeCache.Days > 1)
                {
                    MessageBox.Show("Caracteres incorretos!");
                }
                else
                {
                    cronometro.Hours = hour;
                    cronometro.Minutes = min;
                    cronometro.Seconds = sec;
                    EnableBtns(true, false, true, false);
                    DisableAllTxts();
                    this.btnPause.Focus();
                    this.btnPause.Select();
                    cronometro.ParsePauseTime(this.maskedTextBox1.Text);
                    cronometro.Start();
                }
            }
            else
            {
                MessageBox.Show("Caracteres incorretos!");
                this.txtHora.Focus();
                this.txtHora.SelectAll();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {         
            this.btnPararSom.PerformClick();
            this.lblTimer.Text = "FIM";
            this.lblPausa.Text = "00:00:00";
            cronometro.Stop();            
            this.btnContinue.Enabled = false;
            this.btnPause.Enabled = false;
            this.btnStart.Enabled = true;
            this.btnStop.Enabled = false;
            this.txtHora.Enabled = true;
            this.txtMin.Enabled = true;
            this.txtSec.Enabled = true;
            this.maskedTextBox1.Enabled = true;
        }

        private void txtSec_TextChanged(object sender, EventArgs e)
        {
            if (cronometro.Status != Clock.Situation.stopped)
            {
                cronometro.Stop();
            }            
        }

        private void txtMin_TextChanged(object sender, EventArgs e)
        {
            if (cronometro.Status != Clock.Situation.stopped)
            {
                cronometro.Stop();
            }
        }

        private void txtHora_TextChanged(object sender, EventArgs e)
        {
            if (cronometro.Status != Clock.Situation.stopped)
            {
                cronometro.Stop();
            }
        }

        private void tsmiStart_Click(object sender, EventArgs e)
        {
            #region
            this.btnStart.PerformClick();
            this.tsmiStart.Enabled = false;
            this.tsmiStop.Enabled = true;
            this.tsmiPause.Enabled = true;
            this.tsmiContinue.Enabled = false;
            #endregion
        }

        private void tsmiStop_Click(object sender, EventArgs e)
        {
            #region
            this.btnStop.PerformClick();
            this.tsmiStart.Enabled = true;
            this.tsmiStop.Enabled = false;
            this.tsmiPause.Enabled = false;
            this.tsmiContinue.Enabled = false;
            #endregion
        }

        private void tsmiPause_Click(object sender, EventArgs e)
        {
            #region
            this.btnPause.PerformClick();
            this.tsmiStart.Enabled = false;
            this.tsmiStop.Enabled = true;
            this.tsmiPause.Enabled = false;
            this.tsmiContinue.Enabled = true;
            #endregion
        }

        private void tsmiContinue_Click(object sender, EventArgs e)
        {
            #region
            this.btnContinue.PerformClick();
            this.tsmiStart.Enabled = false;
            this.tsmiStop.Enabled = true;
            this.tsmiPause.Enabled = true;
            this.tsmiContinue.Enabled = false;
            #endregion
        }

        private void lklConfig_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenConfiguration();
        }

        private void OpenConfiguration()
        {
            #region
            Configuration configuration = new Configuration();
            configuration.form1 = this;
            configuration.ShowDialog();
            #endregion
        }

        private void Notification(string title, string body, ToolTipIcon icon)
        {
            this.Temporizador.Visible = true;
            this.Temporizador.BalloonTipText = body;
            this.Temporizador.BalloonTipTitle = title;
            this.Temporizador.ShowBalloonTip(3);
            this.Temporizador.BalloonTipIcon = icon;            
        }

        private void btnPararSom_Click(object sender, EventArgs e)
        {
            this.btnPararSom.Visible = false;
            sound.Stop();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cronometro.Status == Clock.Situation.stopped)
            {
                e.Cancel = false;                
            }
            else
            {
                e.Cancel = config.FicarEmSegundoPlano;
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void Temporizador_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.ShowDialog();
        }

        private void tsmiConfiguration_Click(object sender, EventArgs e)
        {
            OpenConfiguration();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.ShowDialog();
        }

        private void tsmiContribution_Click(object sender, EventArgs e)
        {
            Doacao doacao = new Doacao();
            doacao.ShowDialog();
        }

        private void EnableBtns(bool pause , bool cont, bool stop, bool start)
        {
            this.btnContinue.Enabled = cont;
            this.btnPause.Enabled = pause;
            this.btnStart.Enabled = start;
            this.btnStop.Enabled = stop;
        }

        private void EnableAllBtns()
        {
            this.btnContinue.Enabled = true;
            this.btnPause.Enabled = true;
            this.btnStart.Enabled = true;
            this.btnStop.Enabled = true;
        }

        private void DisableAllBtns()
        {
            this.btnContinue.Enabled = false;
            this.btnPause.Enabled = false;
            this.btnStart.Enabled = false;
            this.btnStop.Enabled = false;
        }

        private void EnableTxts(bool hour, bool min, bool sec, bool alarm)
        {
            txtHora.Enabled = hour;
            txtMin.Enabled = min;
            txtSec.Enabled = sec;
            maskedTextBox1.Enabled = alarm;
        }

        private void DisableAllTxts()
        {
            txtHora.Enabled = false;
            txtMin.Enabled = false;
            txtSec.Enabled = false;
            maskedTextBox1.Enabled = false;
        }

        private void EnableAllTxts()
        {
            txtHora.Enabled = true;
            txtMin.Enabled = true;
            txtSec.Enabled = true;
            maskedTextBox1.Enabled = true;
        }
    }
}
