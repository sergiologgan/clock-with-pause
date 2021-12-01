namespace Interface_Cronometro
{
    partial class Configuration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuration));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picQuandoPausar = new System.Windows.Forms.PictureBox();
            this.picQuandoParar = new System.Windows.Forms.PictureBox();
            this.chkSomQuandoParar = new System.Windows.Forms.CheckBox();
            this.chkSomQuandoPausar = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSomQuandoPausar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSomQuandoParar = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.chkNotQuandoParar = new System.Windows.Forms.CheckBox();
            this.chkNotQuandoPausar = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richCorpQuandoPausar = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNotTitQuandoPausar = new System.Windows.Forms.TextBox();
            this.richCorpQuandoParar = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNotTitQuandoParar = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.chkSegundoPlano = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQuandoPausar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuandoParar)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 316);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 34);
            this.panel1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(186, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Size = new System.Drawing.Size(264, 316);
            this.splitContainer1.SplitterDistance = 151;
            this.splitContainer1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picQuandoPausar);
            this.panel2.Controls.Add(this.picQuandoParar);
            this.panel2.Controls.Add(this.chkSomQuandoParar);
            this.panel2.Controls.Add(this.chkSomQuandoPausar);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtSomQuandoPausar);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtSomQuandoParar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 151);
            this.panel2.TabIndex = 1;
            // 
            // picQuandoPausar
            // 
            this.picQuandoPausar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picQuandoPausar.Image = global::Interface_Cronometro.Properties.Resources.Empty_Folder_icon;
            this.picQuandoPausar.Location = new System.Drawing.Point(121, 98);
            this.picQuandoPausar.Name = "picQuandoPausar";
            this.picQuandoPausar.Size = new System.Drawing.Size(34, 33);
            this.picQuandoPausar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQuandoPausar.TabIndex = 17;
            this.picQuandoPausar.TabStop = false;
            this.picQuandoPausar.Click += new System.EventHandler(this.picQuandoPausar_Click);
            // 
            // picQuandoParar
            // 
            this.picQuandoParar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picQuandoParar.Image = global::Interface_Cronometro.Properties.Resources.Empty_Folder_icon;
            this.picQuandoParar.Location = new System.Drawing.Point(121, 47);
            this.picQuandoParar.Name = "picQuandoParar";
            this.picQuandoParar.Size = new System.Drawing.Size(34, 33);
            this.picQuandoParar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQuandoParar.TabIndex = 16;
            this.picQuandoParar.TabStop = false;
            this.picQuandoParar.Click += new System.EventHandler(this.picQuandoParar_Click);
            // 
            // chkSomQuandoParar
            // 
            this.chkSomQuandoParar.AutoSize = true;
            this.chkSomQuandoParar.Location = new System.Drawing.Point(164, 56);
            this.chkSomQuandoParar.Name = "chkSomQuandoParar";
            this.chkSomQuandoParar.Size = new System.Drawing.Size(73, 17);
            this.chkSomQuandoParar.TabIndex = 13;
            this.chkSomQuandoParar.Text = "Habilitado";
            this.chkSomQuandoParar.UseVisualStyleBackColor = true;
            this.chkSomQuandoParar.Click += new System.EventHandler(this.chkSomQuandoParar_Click);
            // 
            // chkSomQuandoPausar
            // 
            this.chkSomQuandoPausar.AutoSize = true;
            this.chkSomQuandoPausar.Location = new System.Drawing.Point(164, 106);
            this.chkSomQuandoPausar.Name = "chkSomQuandoPausar";
            this.chkSomQuandoPausar.Size = new System.Drawing.Size(73, 17);
            this.chkSomQuandoPausar.TabIndex = 12;
            this.chkSomQuandoPausar.Text = "Habilitado";
            this.chkSomQuandoPausar.UseVisualStyleBackColor = true;
            this.chkSomQuandoPausar.Click += new System.EventHandler(this.chkSomQuandoPausar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(76, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Configuração de som";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quando Pausar";
            // 
            // txtSomQuandoPausar
            // 
            this.txtSomQuandoPausar.Location = new System.Drawing.Point(12, 104);
            this.txtSomQuandoPausar.Name = "txtSomQuandoPausar";
            this.txtSomQuandoPausar.Size = new System.Drawing.Size(100, 20);
            this.txtSomQuandoPausar.TabIndex = 6;
            this.txtSomQuandoPausar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtSomQuandoPausar_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quando Parar";
            // 
            // txtSomQuandoParar
            // 
            this.txtSomQuandoParar.Location = new System.Drawing.Point(12, 54);
            this.txtSomQuandoParar.Name = "txtSomQuandoParar";
            this.txtSomQuandoParar.Size = new System.Drawing.Size(100, 20);
            this.txtSomQuandoParar.TabIndex = 4;
            this.txtSomQuandoParar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtSomQuandoParar_MouseMove);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.chkSegundoPlano);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.chkNotQuandoParar);
            this.panel3.Controls.Add(this.chkNotQuandoPausar);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.richCorpQuandoPausar);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtNotTitQuandoPausar);
            this.panel3.Controls.Add(this.richCorpQuandoParar);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtNotTitQuandoParar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(264, 161);
            this.panel3.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(202, 462);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 15;
            // 
            // chkNotQuandoParar
            // 
            this.chkNotQuandoParar.AutoSize = true;
            this.chkNotQuandoParar.Location = new System.Drawing.Point(129, 169);
            this.chkNotQuandoParar.Name = "chkNotQuandoParar";
            this.chkNotQuandoParar.Size = new System.Drawing.Size(73, 17);
            this.chkNotQuandoParar.TabIndex = 14;
            this.chkNotQuandoParar.Text = "Habilitado";
            this.chkNotQuandoParar.UseVisualStyleBackColor = true;
            this.chkNotQuandoParar.Click += new System.EventHandler(this.chkNotQuandoParar_Click);
            // 
            // chkNotQuandoPausar
            // 
            this.chkNotQuandoPausar.AutoSize = true;
            this.chkNotQuandoPausar.Location = new System.Drawing.Point(119, 395);
            this.chkNotQuandoPausar.Name = "chkNotQuandoPausar";
            this.chkNotQuandoPausar.Size = new System.Drawing.Size(73, 17);
            this.chkNotQuandoPausar.TabIndex = 13;
            this.chkNotQuandoPausar.Text = "Habilitado";
            this.chkNotQuandoPausar.UseVisualStyleBackColor = true;
            this.chkNotQuandoPausar.Click += new System.EventHandler(this.chkNotQuandoPausar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(49, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Notificação Quando Pausar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(58, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Notificação Quando Parar";
            // 
            // richCorpQuandoPausar
            // 
            this.richCorpQuandoPausar.Location = new System.Drawing.Point(15, 293);
            this.richCorpQuandoPausar.Name = "richCorpQuandoPausar";
            this.richCorpQuandoPausar.Size = new System.Drawing.Size(177, 96);
            this.richCorpQuandoPausar.TabIndex = 9;
            this.richCorpQuandoPausar.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Titulo";
            // 
            // txtNotTitQuandoPausar
            // 
            this.txtNotTitQuandoPausar.Location = new System.Drawing.Point(15, 267);
            this.txtNotTitQuandoPausar.Name = "txtNotTitQuandoPausar";
            this.txtNotTitQuandoPausar.Size = new System.Drawing.Size(177, 20);
            this.txtNotTitQuandoPausar.TabIndex = 7;
            // 
            // richCorpQuandoParar
            // 
            this.richCorpQuandoParar.Location = new System.Drawing.Point(25, 73);
            this.richCorpQuandoParar.Name = "richCorpQuandoParar";
            this.richCorpQuandoParar.Size = new System.Drawing.Size(177, 96);
            this.richCorpQuandoParar.TabIndex = 6;
            this.richCorpQuandoParar.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Titulo";
            // 
            // txtNotTitQuandoParar
            // 
            this.txtNotTitQuandoParar.Location = new System.Drawing.Point(25, 47);
            this.txtNotTitQuandoParar.Name = "txtNotTitQuandoParar";
            this.txtNotTitQuandoParar.Size = new System.Drawing.Size(177, 20);
            this.txtNotTitQuandoParar.TabIndex = 4;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkSegundoPlano
            // 
            this.chkSegundoPlano.AutoSize = true;
            this.chkSegundoPlano.Checked = true;
            this.chkSegundoPlano.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSegundoPlano.Location = new System.Drawing.Point(12, 435);
            this.chkSegundoPlano.Name = "chkSegundoPlano";
            this.chkSegundoPlano.Size = new System.Drawing.Size(139, 17);
            this.chkSegundoPlano.TabIndex = 16;
            this.chkSegundoPlano.Text = "Ficar em segundo plano";
            this.chkSegundoPlano.UseVisualStyleBackColor = true;
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 350);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Configuration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQuandoPausar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuandoParar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkSomQuandoPausar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSomQuandoPausar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSomQuandoParar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox chkNotQuandoPausar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richCorpQuandoPausar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNotTitQuandoPausar;
        private System.Windows.Forms.RichTextBox richCorpQuandoParar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNotTitQuandoParar;
        private System.Windows.Forms.CheckBox chkSomQuandoParar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkNotQuandoParar;
        private System.Windows.Forms.PictureBox picQuandoParar;
        private System.Windows.Forms.PictureBox picQuandoPausar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkSegundoPlano;
    }
}