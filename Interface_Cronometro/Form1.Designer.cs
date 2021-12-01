namespace Interface_Cronometro
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblPausa = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSec = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.Temporizador = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiStart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStop = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPause = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiContinue = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConfiguration = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiContribution = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lklConfig = new System.Windows.Forms.LinkLabel();
            this.btnPararSom = new System.Windows.Forms.Button();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(260, 205);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(72, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Iniciar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(17, 205);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "Pausar";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(98, 205);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(75, 23);
            this.btnContinue.TabIndex = 3;
            this.btnContinue.Text = "Continuar";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(179, 205);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Parar";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblPausa
            // 
            this.lblPausa.AutoSize = true;
            this.lblPausa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPausa.Location = new System.Drawing.Point(121, 112);
            this.lblPausa.Name = "lblPausa";
            this.lblPausa.Size = new System.Drawing.Size(0, 17);
            this.lblPausa.TabIndex = 23;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(17, 145);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 29);
            this.lblTimer.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Pausa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Segundos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Minutos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Hora";
            // 
            // txtSec
            // 
            this.txtSec.Location = new System.Drawing.Point(230, 63);
            this.txtSec.Name = "txtSec";
            this.txtSec.Size = new System.Drawing.Size(100, 20);
            this.txtSec.TabIndex = 16;
            this.txtSec.TextChanged += new System.EventHandler(this.txtSec_TextChanged);
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(122, 63);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(100, 20);
            this.txtMin.TabIndex = 15;
            this.txtMin.TextChanged += new System.EventHandler(this.txtMin_TextChanged);
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(15, 63);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(100, 20);
            this.txtHora.TabIndex = 14;
            this.txtHora.TextChanged += new System.EventHandler(this.txtHora_TextChanged);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(14, 109);
            this.maskedTextBox1.Mask = "00:00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 24;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // Temporizador
            // 
            this.Temporizador.ContextMenuStrip = this.contextMenuStrip2;
            this.Temporizador.Icon = ((System.Drawing.Icon)(resources.GetObject("Temporizador.Icon")));
            this.Temporizador.Text = "Temporizador";
            this.Temporizador.Visible = true;
            this.Temporizador.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Temporizador_MouseDoubleClick);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStart,
            this.tsmiStop,
            this.tsmiPause,
            this.tsmiContinue,
            this.tsmiConfiguration,
            this.tsmiContribution,
            this.tsmiHelp});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(147, 158);
            // 
            // tsmiStart
            // 
            this.tsmiStart.Name = "tsmiStart";
            this.tsmiStart.Size = new System.Drawing.Size(146, 22);
            this.tsmiStart.Text = "Iniciar";
            this.tsmiStart.Click += new System.EventHandler(this.tsmiStart_Click);
            // 
            // tsmiStop
            // 
            this.tsmiStop.Name = "tsmiStop";
            this.tsmiStop.Size = new System.Drawing.Size(146, 22);
            this.tsmiStop.Text = "Parar";
            this.tsmiStop.Click += new System.EventHandler(this.tsmiStop_Click);
            // 
            // tsmiPause
            // 
            this.tsmiPause.Name = "tsmiPause";
            this.tsmiPause.Size = new System.Drawing.Size(146, 22);
            this.tsmiPause.Text = "Pausar";
            this.tsmiPause.Click += new System.EventHandler(this.tsmiPause_Click);
            // 
            // tsmiContinue
            // 
            this.tsmiContinue.Name = "tsmiContinue";
            this.tsmiContinue.Size = new System.Drawing.Size(146, 22);
            this.tsmiContinue.Text = "Continuar";
            this.tsmiContinue.Click += new System.EventHandler(this.tsmiContinue_Click);
            // 
            // tsmiConfiguration
            // 
            this.tsmiConfiguration.Name = "tsmiConfiguration";
            this.tsmiConfiguration.Size = new System.Drawing.Size(146, 22);
            this.tsmiConfiguration.Text = "Configuração";
            this.tsmiConfiguration.Click += new System.EventHandler(this.tsmiConfiguration_Click);
            // 
            // tsmiContribution
            // 
            this.tsmiContribution.Name = "tsmiContribution";
            this.tsmiContribution.Size = new System.Drawing.Size(146, 22);
            this.tsmiContribution.Text = "Doação";
            this.tsmiContribution.Click += new System.EventHandler(this.tsmiContribution_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(146, 22);
            this.tsmiHelp.Text = "Ajuda";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.aboutToolStripMenuItem.Text = "Sobre";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lklConfig
            // 
            this.lklConfig.AutoSize = true;
            this.lklConfig.Location = new System.Drawing.Point(272, 5);
            this.lklConfig.Name = "lklConfig";
            this.lklConfig.Size = new System.Drawing.Size(70, 13);
            this.lklConfig.TabIndex = 25;
            this.lklConfig.TabStop = true;
            this.lklConfig.Text = "Configuração";
            this.lklConfig.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklConfig_LinkClicked);
            // 
            // btnPararSom
            // 
            this.btnPararSom.BackColor = System.Drawing.Color.Violet;
            this.btnPararSom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPararSom.Location = new System.Drawing.Point(260, 176);
            this.btnPararSom.Name = "btnPararSom";
            this.btnPararSom.Size = new System.Drawing.Size(72, 23);
            this.btnPararSom.TabIndex = 26;
            this.btnPararSom.Text = "Parar som";
            this.btnPararSom.UseVisualStyleBackColor = false;
            this.btnPararSom.Visible = false;
            this.btnPararSom.Click += new System.EventHandler(this.btnPararSom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 240);
            this.Controls.Add(this.btnPararSom);
            this.Controls.Add(this.lklConfig);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.lblPausa);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSec);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temporizador de Intervalos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblPausa;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSec;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.NotifyIcon Temporizador;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem tsmiStart;
        private System.Windows.Forms.ToolStripMenuItem tsmiStop;
        private System.Windows.Forms.ToolStripMenuItem tsmiPause;
        private System.Windows.Forms.ToolStripMenuItem tsmiContinue;
        private System.Windows.Forms.ToolStripMenuItem tsmiConfiguration;
        private System.Windows.Forms.ToolStripMenuItem tsmiContribution;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.LinkLabel lklConfig;
        private System.Windows.Forms.Button btnPararSom;
    }
}

