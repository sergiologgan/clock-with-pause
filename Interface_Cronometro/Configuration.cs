using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Interface_Cronometro
{
    public partial class Configuration : Form
    {
        public Configuration()
        {
            InitializeComponent();
            file = File.ReadAllText("file.json");            
            config = JsonConvert.DeserializeObject<Config>(file);
            if (config == null)
            {
                config = new Config();
            }

            this.txtSomQuandoParar.Text = config.SoundStop;
            this.txtSomQuandoPausar.Text = config.SoundPause;
            this.chkSomQuandoParar.Checked = config.SoundStopEnabled;
            this.chkSomQuandoPausar.Checked = config.SoundPauseEnabled;
            this.txtNotTitQuandoParar.Text = config.TitleStop;
            this.txtNotTitQuandoPausar.Text = config.TitlePause;
            this.richCorpQuandoParar.Text = config.ContentStop;
            this.richCorpQuandoPausar.Text = config.ContentPause;
            this.chkNotQuandoParar.Checked = config.EnabledNotificationStop;
            this.chkNotQuandoPausar.Checked = config.EnabledNotificationPause;
            this.chkSomQuandoParar.Text = config.SoundStopEnabledText;
            this.chkSomQuandoPausar.Text = config.SoundPauseEnabledText;
            this.chkNotQuandoParar.Text = config.EnabledNotificationStopText;
            this.chkNotQuandoPausar.Text = config.EnabledNotificationPauseText;
            this.txtSomQuandoParar.Enabled = this.chkSomQuandoParar.Checked;
            this.txtSomQuandoPausar.Enabled = this.chkSomQuandoPausar.Checked;
            this.txtNotTitQuandoParar.Enabled = this.chkNotQuandoParar.Checked;
            this.richCorpQuandoParar.Enabled = this.chkNotQuandoParar.Checked;
            this.txtNotTitQuandoPausar.Enabled = this.chkNotQuandoPausar.Checked;
            this.richCorpQuandoPausar.Enabled = this.chkNotQuandoPausar.Checked;
            this.chkSegundoPlano.Checked = config.FicarEmSegundoPlano;
        }

        private Config config;
        private string file;
        public Form1 form1 { get; set; }

        private void picQuandoParar_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.txtSomQuandoParar.Text = this.openFileDialog.FileName;
            }
        }

        private void picQuandoPausar_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.txtSomQuandoPausar.Text = this.openFileDialog.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            config.SoundStop = this.txtSomQuandoParar.Text;
            config.SoundPause = this.txtSomQuandoPausar.Text;
            config.SoundStopEnabled = this.chkSomQuandoParar.Checked;
            config.SoundPauseEnabled = this.chkSomQuandoPausar.Checked;
            config.TitleStop = this.txtNotTitQuandoParar.Text;
            config.TitlePause = this.txtNotTitQuandoPausar.Text;
            config.ContentStop = this.richCorpQuandoParar.Text;
            config.ContentPause = this.richCorpQuandoPausar.Text;
            config.EnabledNotificationStop = this.chkNotQuandoParar.Checked;
            config.EnabledNotificationPause = this.chkNotQuandoPausar.Checked;
            config.SoundStopEnabledText = this.chkSomQuandoParar.Text;
            config.SoundPauseEnabledText = this.chkSomQuandoPausar.Text;
            config.EnabledNotificationStopText = this.chkNotQuandoParar.Text;
            config.EnabledNotificationPauseText = this.chkNotQuandoPausar.Text;
            config.FicarEmSegundoPlano = this.chkSegundoPlano.Checked;
            
            string outputJSON = JsonConvert.SerializeObject(config);
            File.WriteAllText("file.json", outputJSON);
            form1.UpdateConfig();
            this.Close();
        }

        private void txtSomQuandoParar_MouseMove(object sender, MouseEventArgs e)
        {
            this.toolTip1.ShowAlways = true;
            this.toolTip1.SetToolTip(this.txtSomQuandoParar, this.txtSomQuandoParar.Text);
        }

        private void txtSomQuandoPausar_MouseMove(object sender, MouseEventArgs e)
        {
            this.toolTip1.ShowAlways = true;            
            this.toolTip1.SetToolTip(this.txtSomQuandoPausar, this.txtSomQuandoPausar.Text);
        }

        private void chkSomQuandoParar_Click(object sender, EventArgs e)
        {
            if (chkSomQuandoParar.Checked)
            {
                chkSomQuandoParar.Checked = true;
                chkSomQuandoParar.Text = "Habilitado";
            }
            else
            {
                chkSomQuandoParar.Checked = false;
                chkSomQuandoParar.Text = "Desabilitado";
            }
            this.txtSomQuandoParar.Enabled = this.chkSomQuandoParar.Checked;
        }

        private void chkSomQuandoPausar_Click(object sender, EventArgs e)
        {
            if (chkSomQuandoPausar.Checked)
            {
                chkSomQuandoPausar.Checked = true;
                chkSomQuandoPausar.Text = "Habilitado";
            }
            else
            {
                chkSomQuandoPausar.Checked = false;
                chkSomQuandoPausar.Text = "Desabilitado";
            }
            this.txtSomQuandoPausar.Enabled = this.chkSomQuandoPausar.Checked;
        }

        private void chkNotQuandoParar_Click(object sender, EventArgs e)
        {
            if (chkNotQuandoParar.Checked)
            {
                chkNotQuandoParar.Checked = true;
                chkNotQuandoParar.Text = "Habilitado";
            }
            else
            {
                chkNotQuandoParar.Checked = false;
                chkNotQuandoParar.Text = "Desabilitado";
            }
            this.txtNotTitQuandoParar.Enabled = this.chkNotQuandoParar.Checked;
            this.richCorpQuandoParar.Enabled = this.chkNotQuandoParar.Checked;
        }

        private void chkNotQuandoPausar_Click(object sender, EventArgs e)
        {
            if (chkNotQuandoPausar.Checked)
            {
                chkNotQuandoPausar.Checked = true;
                chkNotQuandoPausar.Text = "Habilitado";
            }
            else
            {
                chkNotQuandoPausar.Checked = false;
                chkNotQuandoPausar.Text = "Desabilitado";
            }
            this.txtNotTitQuandoPausar.Enabled = this.chkNotQuandoPausar.Checked;
            this.richCorpQuandoPausar.Enabled = this.chkNotQuandoPausar.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    
}
