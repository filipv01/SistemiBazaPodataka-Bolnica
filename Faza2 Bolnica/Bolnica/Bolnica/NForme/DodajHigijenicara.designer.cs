namespace Bolnica
{
    partial class DodajHigijenicara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajHigijenicara));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.textBoxMaticniBroj = new System.Windows.Forms.TextBox();
            this.cmdDodaj = new System.Windows.Forms.Button();
            this.cmdBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Matični broj: ";
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(143, 41);
            this.textBoxIme.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(108, 20);
            this.textBoxIme.TabIndex = 6;
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(143, 89);
            this.textBoxPrezime.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(108, 20);
            this.textBoxPrezime.TabIndex = 7;
            // 
            // textBoxMaticniBroj
            // 
            this.textBoxMaticniBroj.Location = new System.Drawing.Point(143, 136);
            this.textBoxMaticniBroj.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMaticniBroj.Name = "textBoxMaticniBroj";
            this.textBoxMaticniBroj.Size = new System.Drawing.Size(108, 20);
            this.textBoxMaticniBroj.TabIndex = 8;
            // 
            // cmdDodaj
            // 
            this.cmdDodaj.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdDodaj.Location = new System.Drawing.Point(163, 202);
            this.cmdDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.cmdDodaj.Name = "cmdDodaj";
            this.cmdDodaj.Size = new System.Drawing.Size(88, 30);
            this.cmdDodaj.TabIndex = 9;
            this.cmdDodaj.Text = "Dodaj";
            this.cmdDodaj.UseVisualStyleBackColor = false;
            this.cmdDodaj.Click += new System.EventHandler(this.cmdDodaj_Click);
            // 
            // cmdBack
            // 
            this.cmdBack.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdBack.Location = new System.Drawing.Point(47, 202);
            this.cmdBack.Margin = new System.Windows.Forms.Padding(2);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(88, 30);
            this.cmdBack.TabIndex = 10;
            this.cmdBack.Text = "Nazad";
            this.cmdBack.UseVisualStyleBackColor = false;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // DodajHigijenicara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(302, 267);
            this.Controls.Add(this.cmdBack);
            this.Controls.Add(this.cmdDodaj);
            this.Controls.Add(this.textBoxMaticniBroj);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DodajHigijenicara";
            this.Text = "Dodavanje higijeničara";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxMaticniBroj;
        private System.Windows.Forms.Button cmdDodaj;
        private System.Windows.Forms.Button cmdBack;
    }
}