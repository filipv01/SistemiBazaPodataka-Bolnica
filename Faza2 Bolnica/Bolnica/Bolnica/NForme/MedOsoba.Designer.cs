namespace Bolnica.Entiteti
{
    partial class MedOsoba
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedOsoba));
            this.cmdStomatolog = new System.Windows.Forms.Button();
            this.cmdBack = new System.Windows.Forms.Button();
            this.cmdLekarOP = new System.Windows.Forms.Button();
            this.cmdSpecijalista = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdStomatolog
            // 
            this.cmdStomatolog.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdStomatolog.Location = new System.Drawing.Point(38, 140);
            this.cmdStomatolog.Name = "cmdStomatolog";
            this.cmdStomatolog.Size = new System.Drawing.Size(120, 43);
            this.cmdStomatolog.TabIndex = 12;
            this.cmdStomatolog.Text = "Stomatolog";
            this.cmdStomatolog.UseVisualStyleBackColor = false;
            this.cmdStomatolog.Click += new System.EventHandler(this.cmdStomatolog_Click);
            // 
            // cmdBack
            // 
            this.cmdBack.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdBack.Location = new System.Drawing.Point(38, 337);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(88, 30);
            this.cmdBack.TabIndex = 13;
            this.cmdBack.Text = "Nazad";
            this.cmdBack.UseVisualStyleBackColor = false;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // cmdLekarOP
            // 
            this.cmdLekarOP.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdLekarOP.Location = new System.Drawing.Point(38, 70);
            this.cmdLekarOP.Name = "cmdLekarOP";
            this.cmdLekarOP.Size = new System.Drawing.Size(120, 43);
            this.cmdLekarOP.TabIndex = 14;
            this.cmdLekarOP.Text = "Lekar opšte prakse";
            this.cmdLekarOP.UseVisualStyleBackColor = false;
            this.cmdLekarOP.Click += new System.EventHandler(this.cmdLekarOP_Click);
            // 
            // cmdSpecijalista
            // 
            this.cmdSpecijalista.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdSpecijalista.Location = new System.Drawing.Point(38, 210);
            this.cmdSpecijalista.Name = "cmdSpecijalista";
            this.cmdSpecijalista.Size = new System.Drawing.Size(120, 43);
            this.cmdSpecijalista.TabIndex = 15;
            this.cmdSpecijalista.Text = "Specijalista";
            this.cmdSpecijalista.UseVisualStyleBackColor = false;
            this.cmdSpecijalista.Click += new System.EventHandler(this.cmdSpecijalista_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(185, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 340);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MedOsoba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(550, 412);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdSpecijalista);
            this.Controls.Add(this.cmdLekarOP);
            this.Controls.Add(this.cmdBack);
            this.Controls.Add(this.cmdStomatolog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MedOsoba";
            this.Text = "Medicinsko osoblje";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdStomatolog;
        private System.Windows.Forms.Button cmdBack;
        private System.Windows.Forms.Button cmdLekarOP;
        private System.Windows.Forms.Button cmdSpecijalista;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}