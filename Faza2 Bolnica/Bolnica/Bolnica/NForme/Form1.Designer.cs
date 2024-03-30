namespace Bolnica
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmdMedicinskoOsoblje = new System.Windows.Forms.Button();
            this.cmdPacijent = new System.Windows.Forms.Button();
            this.cmdStomatoloskaStolica = new System.Windows.Forms.Button();
            this.cmdOdeljenje = new System.Windows.Forms.Button();
            this.cmdOdrzavaHigijenu = new System.Windows.Forms.Button();
            this.cmdNemed = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdOdustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdMedicinskoOsoblje
            // 
            this.cmdMedicinskoOsoblje.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdMedicinskoOsoblje.Location = new System.Drawing.Point(540, 47);
            this.cmdMedicinskoOsoblje.Margin = new System.Windows.Forms.Padding(2);
            this.cmdMedicinskoOsoblje.Name = "cmdMedicinskoOsoblje";
            this.cmdMedicinskoOsoblje.Size = new System.Drawing.Size(136, 38);
            this.cmdMedicinskoOsoblje.TabIndex = 0;
            this.cmdMedicinskoOsoblje.Text = "Medicinsko osoblje";
            this.cmdMedicinskoOsoblje.UseVisualStyleBackColor = false;
            this.cmdMedicinskoOsoblje.Click += new System.EventHandler(this.cmdMedicinskoOsoblje_Click);
            // 
            // cmdPacijent
            // 
            this.cmdPacijent.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdPacijent.Location = new System.Drawing.Point(540, 133);
            this.cmdPacijent.Margin = new System.Windows.Forms.Padding(2);
            this.cmdPacijent.Name = "cmdPacijent";
            this.cmdPacijent.Size = new System.Drawing.Size(136, 38);
            this.cmdPacijent.TabIndex = 5;
            this.cmdPacijent.Text = "Pacijent";
            this.cmdPacijent.UseVisualStyleBackColor = false;
            this.cmdPacijent.Click += new System.EventHandler(this.cmdPacijent_Click);
            // 
            // cmdStomatoloskaStolica
            // 
            this.cmdStomatoloskaStolica.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdStomatoloskaStolica.Location = new System.Drawing.Point(540, 175);
            this.cmdStomatoloskaStolica.Margin = new System.Windows.Forms.Padding(2);
            this.cmdStomatoloskaStolica.Name = "cmdStomatoloskaStolica";
            this.cmdStomatoloskaStolica.Size = new System.Drawing.Size(136, 38);
            this.cmdStomatoloskaStolica.TabIndex = 6;
            this.cmdStomatoloskaStolica.Text = "Stomatološka stolica";
            this.cmdStomatoloskaStolica.UseVisualStyleBackColor = false;
            this.cmdStomatoloskaStolica.Click += new System.EventHandler(this.cmdStomatoloskaStolica_Click);
            // 
            // cmdOdeljenje
            // 
            this.cmdOdeljenje.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdOdeljenje.Location = new System.Drawing.Point(540, 217);
            this.cmdOdeljenje.Margin = new System.Windows.Forms.Padding(2);
            this.cmdOdeljenje.Name = "cmdOdeljenje";
            this.cmdOdeljenje.Size = new System.Drawing.Size(136, 38);
            this.cmdOdeljenje.TabIndex = 7;
            this.cmdOdeljenje.Text = "Odeljenje";
            this.cmdOdeljenje.UseVisualStyleBackColor = false;
            this.cmdOdeljenje.Click += new System.EventHandler(this.cmdOdeljenje_Click);
            // 
            // cmdOdrzavaHigijenu
            // 
            this.cmdOdrzavaHigijenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdOdrzavaHigijenu.Location = new System.Drawing.Point(540, 259);
            this.cmdOdrzavaHigijenu.Margin = new System.Windows.Forms.Padding(2);
            this.cmdOdrzavaHigijenu.Name = "cmdOdrzavaHigijenu";
            this.cmdOdrzavaHigijenu.Size = new System.Drawing.Size(136, 38);
            this.cmdOdrzavaHigijenu.TabIndex = 8;
            this.cmdOdrzavaHigijenu.Text = "Održava higijenu";
            this.cmdOdrzavaHigijenu.UseVisualStyleBackColor = false;
            this.cmdOdrzavaHigijenu.Click += new System.EventHandler(this.cmdOdrzavaHigijenu_Click);
            // 
            // cmdNemed
            // 
            this.cmdNemed.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdNemed.Location = new System.Drawing.Point(540, 90);
            this.cmdNemed.Name = "cmdNemed";
            this.cmdNemed.Size = new System.Drawing.Size(136, 38);
            this.cmdNemed.TabIndex = 9;
            this.cmdNemed.Text = "Nemedicinsko osoblje";
            this.cmdNemed.UseVisualStyleBackColor = false;
            this.cmdNemed.Click += new System.EventHandler(this.cmdNemed_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(63, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cmdOdustani
            // 
            this.cmdOdustani.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdOdustani.Location = new System.Drawing.Point(588, 346);
            this.cmdOdustani.Margin = new System.Windows.Forms.Padding(2);
            this.cmdOdustani.Name = "cmdOdustani";
            this.cmdOdustani.Size = new System.Drawing.Size(88, 30);
            this.cmdOdustani.TabIndex = 11;
            this.cmdOdustani.Text = "Izadji";
            this.cmdOdustani.UseVisualStyleBackColor = false;
            this.cmdOdustani.Click += new System.EventHandler(this.cmdOdustani_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(708, 397);
            this.Controls.Add(this.cmdOdustani);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdNemed);
            this.Controls.Add(this.cmdOdrzavaHigijenu);
            this.Controls.Add(this.cmdOdeljenje);
            this.Controls.Add(this.cmdStomatoloskaStolica);
            this.Controls.Add(this.cmdPacijent);
            this.Controls.Add(this.cmdMedicinskoOsoblje);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Početna strana";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdMedicinskoOsoblje;
        private System.Windows.Forms.Button cmdPacijent;
        private System.Windows.Forms.Button cmdStomatoloskaStolica;
        private System.Windows.Forms.Button cmdOdeljenje;
        private System.Windows.Forms.Button cmdOdrzavaHigijenu;
        private System.Windows.Forms.Button cmdNemed;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdOdustani;
    }
}

