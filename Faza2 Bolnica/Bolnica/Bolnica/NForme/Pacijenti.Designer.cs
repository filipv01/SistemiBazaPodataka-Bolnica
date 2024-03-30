namespace Bolnica
{
    partial class Pacijenti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pacijenti));
            this.btnStacionar = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.brnAmbulanta = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStacionar
            // 
            this.btnStacionar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnStacionar.Location = new System.Drawing.Point(285, 131);
            this.btnStacionar.Margin = new System.Windows.Forms.Padding(2);
            this.btnStacionar.Name = "btnStacionar";
            this.btnStacionar.Size = new System.Drawing.Size(96, 41);
            this.btnStacionar.TabIndex = 0;
            this.btnStacionar.Text = "Stacionar";
            this.btnStacionar.UseVisualStyleBackColor = false;
            this.btnStacionar.Click += new System.EventHandler(this.btnStacionar_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBack.Location = new System.Drawing.Point(20, 241);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(88, 30);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Nazad";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // brnAmbulanta
            // 
            this.brnAmbulanta.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.brnAmbulanta.Location = new System.Drawing.Point(285, 76);
            this.brnAmbulanta.Margin = new System.Windows.Forms.Padding(2);
            this.brnAmbulanta.Name = "brnAmbulanta";
            this.brnAmbulanta.Size = new System.Drawing.Size(96, 41);
            this.brnAmbulanta.TabIndex = 3;
            this.brnAmbulanta.Text = "Ambulanta";
            this.brnAmbulanta.UseVisualStyleBackColor = false;
            this.brnAmbulanta.Click += new System.EventHandler(this.brnAmbulanta_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 201);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Pacijenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(398, 296);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.brnAmbulanta);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnStacionar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Pacijenti";
            this.Text = "Pacijenti";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStacionar;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button brnAmbulanta;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}