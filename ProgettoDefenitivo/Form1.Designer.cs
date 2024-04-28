namespace ProgettoDefenitivo
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbErroreData = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.btnInformazioni = new System.Windows.Forms.Button();
            this.panelPartenza = new System.Windows.Forms.Panel();
            this.rbSpecifica = new System.Windows.Forms.RadioButton();
            this.dtRitorno = new System.Windows.Forms.DateTimePicker();
            this.rbIntervallo = new System.Windows.Forms.RadioButton();
            this.dtPartenza = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtPartenza = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureVolo = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnMeteo = new System.Windows.Forms.Button();
            this.pictureBoxMeteo = new System.Windows.Forms.PictureBox();
            this.txtMeteo = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pictureBoxCartina = new System.Windows.Forms.PictureBox();
            this.pictureBoxPaesaggio = new System.Windows.Forms.PictureBox();
            this.btnCartina = new System.Windows.Forms.Button();
            this.btnPaesaggio = new System.Windows.Forms.Button();
            this.txtCitta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelPartenza.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVolo)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMeteo)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCartina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaesaggio)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1466, 809);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lbErroreData);
            this.tabPage1.Controls.Add(this.txtLink);
            this.tabPage1.Controls.Add(this.btnInformazioni);
            this.tabPage1.Controls.Add(this.panelPartenza);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.txtPartenza);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1458, 783);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "VOLO";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbErroreData
            // 
            this.lbErroreData.AutoSize = true;
            this.lbErroreData.Location = new System.Drawing.Point(585, 217);
            this.lbErroreData.Name = "lbErroreData";
            this.lbErroreData.Size = new System.Drawing.Size(0, 13);
            this.lbErroreData.TabIndex = 11;
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(17, 411);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(100, 20);
            this.txtLink.TabIndex = 10;
            this.txtLink.Visible = false;
            // 
            // btnInformazioni
            // 
            this.btnInformazioni.BackColor = System.Drawing.Color.Silver;
            this.btnInformazioni.Location = new System.Drawing.Point(1002, 41);
            this.btnInformazioni.Name = "btnInformazioni";
            this.btnInformazioni.Size = new System.Drawing.Size(230, 54);
            this.btnInformazioni.TabIndex = 9;
            this.btnInformazioni.Text = "CERCA VOLI";
            this.btnInformazioni.UseVisualStyleBackColor = false;
            this.btnInformazioni.Click += new System.EventHandler(this.btnInformazioni_Click);
            // 
            // panelPartenza
            // 
            this.panelPartenza.BackColor = System.Drawing.Color.LightGray;
            this.panelPartenza.Controls.Add(this.rbSpecifica);
            this.panelPartenza.Controls.Add(this.dtRitorno);
            this.panelPartenza.Controls.Add(this.rbIntervallo);
            this.panelPartenza.Controls.Add(this.dtPartenza);
            this.panelPartenza.Location = new System.Drawing.Point(556, 94);
            this.panelPartenza.Name = "panelPartenza";
            this.panelPartenza.Size = new System.Drawing.Size(308, 105);
            this.panelPartenza.TabIndex = 8;
            // 
            // rbSpecifica
            // 
            this.rbSpecifica.AutoSize = true;
            this.rbSpecifica.Location = new System.Drawing.Point(32, 19);
            this.rbSpecifica.Name = "rbSpecifica";
            this.rbSpecifica.Size = new System.Drawing.Size(111, 17);
            this.rbSpecifica.TabIndex = 4;
            this.rbSpecifica.TabStop = true;
            this.rbSpecifica.Text = "DATA SPECIFICA";
            this.rbSpecifica.UseVisualStyleBackColor = true;
            // 
            // dtRitorno
            // 
            this.dtRitorno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtRitorno.Location = new System.Drawing.Point(181, 56);
            this.dtRitorno.Name = "dtRitorno";
            this.dtRitorno.Size = new System.Drawing.Size(98, 20);
            this.dtRitorno.TabIndex = 7;
            // 
            // rbIntervallo
            // 
            this.rbIntervallo.AutoSize = true;
            this.rbIntervallo.Location = new System.Drawing.Point(32, 56);
            this.rbIntervallo.Name = "rbIntervallo";
            this.rbIntervallo.Size = new System.Drawing.Size(124, 17);
            this.rbIntervallo.TabIndex = 5;
            this.rbIntervallo.TabStop = true;
            this.rbIntervallo.Text = "INTERVALLO DATE";
            this.rbIntervallo.UseVisualStyleBackColor = true;
            // 
            // dtPartenza
            // 
            this.dtPartenza.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPartenza.Location = new System.Drawing.Point(181, 19);
            this.dtPartenza.Name = "dtPartenza";
            this.dtPartenza.Size = new System.Drawing.Size(98, 20);
            this.dtPartenza.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(409, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ShortcutsEnabled = false;
            this.textBox2.Size = new System.Drawing.Size(125, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "OVUNQUE";
            // 
            // txtPartenza
            // 
            this.txtPartenza.Location = new System.Drawing.Point(645, 57);
            this.txtPartenza.Name = "txtPartenza";
            this.txtPartenza.ReadOnly = true;
            this.txtPartenza.Size = new System.Drawing.Size(113, 20);
            this.txtPartenza.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(17, 83);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(342, 300);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureVolo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1458, 783);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SCREEN VOLO";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureVolo
            // 
            this.pictureVolo.Location = new System.Drawing.Point(29, 33);
            this.pictureVolo.Name = "pictureVolo";
            this.pictureVolo.Size = new System.Drawing.Size(1370, 688);
            this.pictureVolo.TabIndex = 0;
            this.pictureVolo.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnMeteo);
            this.tabPage3.Controls.Add(this.pictureBoxMeteo);
            this.tabPage3.Controls.Add(this.txtMeteo);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1458, 783);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "METEO";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnMeteo
            // 
            this.btnMeteo.Location = new System.Drawing.Point(749, 35);
            this.btnMeteo.Name = "btnMeteo";
            this.btnMeteo.Size = new System.Drawing.Size(154, 51);
            this.btnMeteo.TabIndex = 2;
            this.btnMeteo.Text = "METEO";
            this.btnMeteo.UseVisualStyleBackColor = true;
            this.btnMeteo.Click += new System.EventHandler(this.btnMeteo_Click_1);
            // 
            // pictureBoxMeteo
            // 
            this.pictureBoxMeteo.Location = new System.Drawing.Point(64, 106);
            this.pictureBoxMeteo.Name = "pictureBoxMeteo";
            this.pictureBoxMeteo.Size = new System.Drawing.Size(1243, 536);
            this.pictureBoxMeteo.TabIndex = 1;
            this.pictureBoxMeteo.TabStop = false;
            // 
            // txtMeteo
            // 
            this.txtMeteo.Location = new System.Drawing.Point(574, 51);
            this.txtMeteo.Name = "txtMeteo";
            this.txtMeteo.Size = new System.Drawing.Size(105, 20);
            this.txtMeteo.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtCitta);
            this.tabPage4.Controls.Add(this.btnPaesaggio);
            this.tabPage4.Controls.Add(this.btnCartina);
            this.tabPage4.Controls.Add(this.pictureBoxPaesaggio);
            this.tabPage4.Controls.Add(this.pictureBoxCartina);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1458, 783);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "CARTINA E PAESAGGIO";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pictureBoxCartina
            // 
            this.pictureBoxCartina.Location = new System.Drawing.Point(15, 129);
            this.pictureBoxCartina.Name = "pictureBoxCartina";
            this.pictureBoxCartina.Size = new System.Drawing.Size(639, 288);
            this.pictureBoxCartina.TabIndex = 0;
            this.pictureBoxCartina.TabStop = false;
            // 
            // pictureBoxPaesaggio
            // 
            this.pictureBoxPaesaggio.Location = new System.Drawing.Point(730, 131);
            this.pictureBoxPaesaggio.Name = "pictureBoxPaesaggio";
            this.pictureBoxPaesaggio.Size = new System.Drawing.Size(693, 273);
            this.pictureBoxPaesaggio.TabIndex = 1;
            this.pictureBoxPaesaggio.TabStop = false;
            // 
            // btnCartina
            // 
            this.btnCartina.Location = new System.Drawing.Point(295, 93);
            this.btnCartina.Name = "btnCartina";
            this.btnCartina.Size = new System.Drawing.Size(119, 30);
            this.btnCartina.TabIndex = 2;
            this.btnCartina.Text = "CARTINA";
            this.btnCartina.UseVisualStyleBackColor = true;
            this.btnCartina.Click += new System.EventHandler(this.btnCartina_Click);
            // 
            // btnPaesaggio
            // 
            this.btnPaesaggio.Location = new System.Drawing.Point(962, 93);
            this.btnPaesaggio.Name = "btnPaesaggio";
            this.btnPaesaggio.Size = new System.Drawing.Size(127, 32);
            this.btnPaesaggio.TabIndex = 3;
            this.btnPaesaggio.Text = "PAESAGGIO";
            this.btnPaesaggio.UseVisualStyleBackColor = true;
            this.btnPaesaggio.Click += new System.EventHandler(this.btnPaesaggio_Click);
            // 
            // txtCitta
            // 
            this.txtCitta.Location = new System.Drawing.Point(603, 39);
            this.txtCitta.Name = "txtCitta";
            this.txtCitta.Size = new System.Drawing.Size(187, 20);
            this.txtCitta.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "PARTENZA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "DESTINAZIONE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(658, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "PARTI IL :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 809);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panelPartenza.ResumeLayout(false);
            this.panelPartenza.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureVolo)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMeteo)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCartina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaesaggio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rbIntervallo;
        private System.Windows.Forms.RadioButton rbSpecifica;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtPartenza;
        private System.Windows.Forms.DateTimePicker dtRitorno;
        private System.Windows.Forms.DateTimePicker dtPartenza;
        private System.Windows.Forms.Panel panelPartenza;
        private System.Windows.Forms.Button btnInformazioni;
        private System.Windows.Forms.PictureBox pictureVolo;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label lbErroreData;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBoxMeteo;
        private System.Windows.Forms.TextBox txtMeteo;
        private System.Windows.Forms.Button btnMeteo;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnPaesaggio;
        private System.Windows.Forms.Button btnCartina;
        private System.Windows.Forms.PictureBox pictureBoxPaesaggio;
        private System.Windows.Forms.PictureBox pictureBoxCartina;
        private System.Windows.Forms.TextBox txtCitta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

