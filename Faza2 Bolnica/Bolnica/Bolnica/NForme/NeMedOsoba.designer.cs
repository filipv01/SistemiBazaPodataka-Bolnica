namespace Bolnica
{
    partial class NeMedOsoba
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NeMedOsoba));
            this.cmdTehnickoOsoblje = new System.Windows.Forms.Button();
            this.cmdHigijenicar = new System.Windows.Forms.Button();
            this.cmdBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdTehnickoOsoblje
            // 
            this.cmdTehnickoOsoblje.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdTehnickoOsoblje.Image = ((System.Drawing.Image)(resources.GetObject("cmdTehnickoOsoblje.Image")));
            this.cmdTehnickoOsoblje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdTehnickoOsoblje.Location = new System.Drawing.Point(100, 143);
            this.cmdTehnickoOsoblje.Margin = new System.Windows.Forms.Padding(2);
            this.cmdTehnickoOsoblje.Name = "cmdTehnickoOsoblje";
            this.cmdTehnickoOsoblje.Size = new System.Drawing.Size(124, 53);
            this.cmdTehnickoOsoblje.TabIndex = 0;
            this.cmdTehnickoOsoblje.Text = "Tehničko osoblje";
            this.cmdTehnickoOsoblje.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdTehnickoOsoblje.UseVisualStyleBackColor = false;
            this.cmdTehnickoOsoblje.Click += new System.EventHandler(this.cmdTehnickoOsoblje_Click);
            // 
            // cmdHigijenicar
            // 
            this.cmdHigijenicar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdHigijenicar.Image = ((System.Drawing.Image)(resources.GetObject("cmdHigijenicar.Image")));
            this.cmdHigijenicar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdHigijenicar.Location = new System.Drawing.Point(100, 67);
            this.cmdHigijenicar.Margin = new System.Windows.Forms.Padding(2);
            this.cmdHigijenicar.Name = "cmdHigijenicar";
            this.cmdHigijenicar.Size = new System.Drawing.Size(124, 53);
            this.cmdHigijenicar.TabIndex = 1;
            this.cmdHigijenicar.Text = "Higijeničar";
            this.cmdHigijenicar.UseVisualStyleBackColor = false;
            this.cmdHigijenicar.Click += new System.EventHandler(this.cmdHigijenicar_Click);
            // 
            // cmdBack
            // 
            this.cmdBack.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdBack.Location = new System.Drawing.Point(12, 272);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(88, 30);
            this.cmdBack.TabIndex = 2;
            this.cmdBack.Text = "Nazad";
            this.cmdBack.UseVisualStyleBackColor = false;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // NeMedOsoba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(333, 331);
            this.Controls.Add(this.cmdBack);
            this.Controls.Add(this.cmdHigijenicar);
            this.Controls.Add(this.cmdTehnickoOsoblje);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NeMedOsoba";
            this.Text = "Nemedicinsko osoblje";
            this.Load += new System.EventHandler(this.NeMedOsoba_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdTehnickoOsoblje;
        private System.Windows.Forms.Button cmdHigijenicar;
        private System.Windows.Forms.Button cmdBack;
    }
}