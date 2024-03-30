namespace Bolnica
{
    partial class FormSpecUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSpecUpdate));
            this.cmdNazad = new System.Windows.Forms.Button();
            this.cmdAzurirajS = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdNazad
            // 
            this.cmdNazad.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdNazad.Location = new System.Drawing.Point(38, 245);
            this.cmdNazad.Margin = new System.Windows.Forms.Padding(2);
            this.cmdNazad.Name = "cmdNazad";
            this.cmdNazad.Size = new System.Drawing.Size(88, 30);
            this.cmdNazad.TabIndex = 53;
            this.cmdNazad.Text = "Nazad";
            this.cmdNazad.UseVisualStyleBackColor = false;
            this.cmdNazad.Click += new System.EventHandler(this.cmdNazad_Click);
            // 
            // cmdAzurirajS
            // 
            this.cmdAzurirajS.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdAzurirajS.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdAzurirajS.Location = new System.Drawing.Point(174, 245);
            this.cmdAzurirajS.Margin = new System.Windows.Forms.Padding(2);
            this.cmdAzurirajS.Name = "cmdAzurirajS";
            this.cmdAzurirajS.Size = new System.Drawing.Size(88, 30);
            this.cmdAzurirajS.TabIndex = 52;
            this.cmdAzurirajS.Text = "Ažuriraj";
            this.cmdAzurirajS.UseVisualStyleBackColor = false;
            this.cmdAzurirajS.Click += new System.EventHandler(this.cmdAzurirajS_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(166, 184);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(96, 20);
            this.textBox5.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Specijalnost:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Godine radnog staža: ";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(166, 145);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(96, 20);
            this.textBox4.TabIndex = 48;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(166, 106);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(96, 20);
            this.textBox3.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Matični broj: ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(166, 69);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(96, 20);
            this.textBox2.TabIndex = 45;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 35);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 20);
            this.textBox1.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Prezime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Ime:";
            // 
            // FormSpecUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(306, 315);
            this.Controls.Add(this.cmdNazad);
            this.Controls.Add(this.cmdAzurirajS);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSpecUpdate";
            this.Text = "Ažuriranje lekara specijaliste";
            this.Load += new System.EventHandler(this.FormSpecUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdNazad;
        private System.Windows.Forms.Button cmdAzurirajS;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}