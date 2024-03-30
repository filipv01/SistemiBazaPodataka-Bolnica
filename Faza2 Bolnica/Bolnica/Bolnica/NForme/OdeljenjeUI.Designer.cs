namespace Bolnica
{
    partial class OdeljenjeUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdeljenjeUI));
            this.listOd = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSifra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDatumIzgradnje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnImePrezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listOd
            // 
            this.listOd.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listOd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnSifra,
            this.columnTip,
            this.columnDatumIzgradnje,
            this.columnImePrezime});
            this.listOd.GridLines = true;
            this.listOd.HideSelection = false;
            this.listOd.Location = new System.Drawing.Point(24, 62);
            this.listOd.Margin = new System.Windows.Forms.Padding(2);
            this.listOd.Name = "listOd";
            this.listOd.Size = new System.Drawing.Size(491, 191);
            this.listOd.TabIndex = 1;
            this.listOd.UseCompatibleStateImageBehavior = false;
            this.listOd.View = System.Windows.Forms.View.Details;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            // 
            // columnSifra
            // 
            this.columnSifra.Text = "Šifra";
            this.columnSifra.Width = 74;
            // 
            // columnTip
            // 
            this.columnTip.Text = "Tip";
            this.columnTip.Width = 97;
            // 
            // columnDatumIzgradnje
            // 
            this.columnDatumIzgradnje.Text = "Datum izgradnje";
            this.columnDatumIzgradnje.Width = 166;
            // 
            // columnImePrezime
            // 
            this.columnImePrezime.Text = "Specijalista";
            this.columnImePrezime.Width = 170;
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAzuriraj.Location = new System.Drawing.Point(541, 106);
            this.btnAzuriraj.Margin = new System.Windows.Forms.Padding(2);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(110, 40);
            this.btnAzuriraj.TabIndex = 3;
            this.btnAzuriraj.Text = "Ažuriraj odeljenje";
            this.btnAzuriraj.UseVisualStyleBackColor = false;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnBrisi
            // 
            this.btnBrisi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBrisi.Location = new System.Drawing.Point(541, 150);
            this.btnBrisi.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(110, 40);
            this.btnBrisi.TabIndex = 4;
            this.btnBrisi.Text = "Obriši odeljenje";
            this.btnBrisi.UseVisualStyleBackColor = false;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDodaj.Location = new System.Drawing.Point(541, 62);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(110, 40);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj odeljenje";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdExit.Location = new System.Drawing.Point(24, 281);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(88, 30);
            this.cmdExit.TabIndex = 7;
            this.cmdExit.Text = "Nazad";
            this.cmdExit.UseVisualStyleBackColor = false;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Location = new System.Drawing.Point(541, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Detaljnije";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OdeljenjeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(698, 370);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.listOd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OdeljenjeUI";
            this.Text = "Odeljenja";
            this.Load += new System.EventHandler(this.OdeljenjeUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listOd;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnSifra;
        private System.Windows.Forms.ColumnHeader columnTip;
        private System.Windows.Forms.ColumnHeader columnDatumIzgradnje;
        private System.Windows.Forms.ColumnHeader columnImePrezime;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button button1;
    }
}