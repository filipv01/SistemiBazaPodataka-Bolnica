namespace Bolnica.NForme
{
    partial class OdrzavaHigijenuUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdrzavaHigijenuUI));
            this.cmdExit = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.listZaduzenja = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnImePrezimeHigenicar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOdeljenje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listHigijenicari = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listOdeljenja = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdExit
            // 
            this.cmdExit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdExit.Location = new System.Drawing.Point(36, 556);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(88, 30);
            this.cmdExit.TabIndex = 12;
            this.cmdExit.Text = "Nazad";
            this.cmdExit.UseVisualStyleBackColor = false;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDodaj.Location = new System.Drawing.Point(423, 41);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(110, 38);
            this.btnDodaj.TabIndex = 11;
            this.btnDodaj.Text = "Dodaj zaduženje";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnBrisi
            // 
            this.btnBrisi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBrisi.Location = new System.Drawing.Point(423, 194);
            this.btnBrisi.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(110, 38);
            this.btnBrisi.TabIndex = 10;
            this.btnBrisi.Text = "Obriši zaduženje";
            this.btnBrisi.UseVisualStyleBackColor = false;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAzuriraj.Location = new System.Drawing.Point(423, 118);
            this.btnAzuriraj.Margin = new System.Windows.Forms.Padding(2);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(110, 38);
            this.btnAzuriraj.TabIndex = 9;
            this.btnAzuriraj.Text = "Ažuriraj zaduženje";
            this.btnAzuriraj.UseVisualStyleBackColor = false;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // listZaduzenja
            // 
            this.listZaduzenja.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listZaduzenja.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnImePrezimeHigenicar,
            this.columnOdeljenje});
            this.listZaduzenja.GridLines = true;
            this.listZaduzenja.HideSelection = false;
            this.listZaduzenja.Location = new System.Drawing.Point(25, 30);
            this.listZaduzenja.Margin = new System.Windows.Forms.Padding(2);
            this.listZaduzenja.Name = "listZaduzenja";
            this.listZaduzenja.Size = new System.Drawing.Size(324, 191);
            this.listZaduzenja.TabIndex = 8;
            this.listZaduzenja.UseCompatibleStateImageBehavior = false;
            this.listZaduzenja.View = System.Windows.Forms.View.Details;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 37;
            // 
            // columnImePrezimeHigenicar
            // 
            this.columnImePrezimeHigenicar.Text = "Higijeničar";
            this.columnImePrezimeHigenicar.Width = 168;
            // 
            // columnOdeljenje
            // 
            this.columnOdeljenje.Text = "Odeljenje";
            this.columnOdeljenje.Width = 113;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listZaduzenja);
            this.groupBox1.Location = new System.Drawing.Point(36, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(363, 247);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zaduzenja";
            // 
            // listHigijenicari
            // 
            this.listHigijenicari.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listHigijenicari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listHigijenicari.GridLines = true;
            this.listHigijenicari.HideSelection = false;
            this.listHigijenicari.Location = new System.Drawing.Point(16, 29);
            this.listHigijenicari.Margin = new System.Windows.Forms.Padding(2);
            this.listHigijenicari.Name = "listHigijenicari";
            this.listHigijenicari.Size = new System.Drawing.Size(331, 191);
            this.listHigijenicari.TabIndex = 8;
            this.listHigijenicari.UseCompatibleStateImageBehavior = false;
            this.listHigijenicari.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            this.columnHeader4.Width = 36;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ime";
            this.columnHeader5.Width = 74;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Prezime";
            this.columnHeader6.Width = 106;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Matični broj";
            this.columnHeader7.Width = 110;
            // 
            // listOdeljenja
            // 
            this.listOdeljenja.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listOdeljenja.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listOdeljenja.GridLines = true;
            this.listOdeljenja.HideSelection = false;
            this.listOdeljenja.Location = new System.Drawing.Point(24, 29);
            this.listOdeljenja.Margin = new System.Windows.Forms.Padding(2);
            this.listOdeljenja.Name = "listOdeljenja";
            this.listOdeljenja.Size = new System.Drawing.Size(209, 191);
            this.listOdeljenja.TabIndex = 14;
            this.listOdeljenja.UseCompatibleStateImageBehavior = false;
            this.listOdeljenja.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 34;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Šifra";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tip ";
            this.columnHeader3.Width = 98;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listHigijenicari);
            this.groupBox2.Location = new System.Drawing.Point(316, 282);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(363, 248);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Higijenicari";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listOdeljenja);
            this.groupBox3.Location = new System.Drawing.Point(36, 282);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(256, 248);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Odeljenja";
            // 
            // OdrzavaHigijenuUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(714, 613);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnAzuriraj);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OdrzavaHigijenuUI";
            this.Text = "Odrzavanje higijene";
            this.Load += new System.EventHandler(this.OdrzavaHigijenuUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.ListView listZaduzenja;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnImePrezimeHigenicar;
        private System.Windows.Forms.ColumnHeader columnOdeljenje;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listHigijenicari;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView listOdeljenja;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}