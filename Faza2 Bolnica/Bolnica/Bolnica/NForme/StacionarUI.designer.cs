namespace Bolnica
{
    partial class StacionarUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StacionarUI));
            this.btnPStacionara = new System.Windows.Forms.Button();
            this.btnAzurirajStac = new System.Windows.Forms.Button();
            this.btnBrisiStac = new System.Windows.Forms.Button();
            this.listStacionari = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDatimPrijema = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDatumOtpusta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTipOd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnImePrezimeOP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPStacionara
            // 
            this.btnPStacionara.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPStacionara.Location = new System.Drawing.Point(31, 315);
            this.btnPStacionara.Margin = new System.Windows.Forms.Padding(2);
            this.btnPStacionara.Name = "btnPStacionara";
            this.btnPStacionara.Size = new System.Drawing.Size(141, 36);
            this.btnPStacionara.TabIndex = 0;
            this.btnPStacionara.Text = "Dodaj pacijenta stacionara";
            this.btnPStacionara.UseVisualStyleBackColor = false;
            this.btnPStacionara.Click += new System.EventHandler(this.btnPStacionara_Click);
            // 
            // btnAzurirajStac
            // 
            this.btnAzurirajStac.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAzurirajStac.Location = new System.Drawing.Point(292, 315);
            this.btnAzurirajStac.Margin = new System.Windows.Forms.Padding(2);
            this.btnAzurirajStac.Name = "btnAzurirajStac";
            this.btnAzurirajStac.Size = new System.Drawing.Size(141, 36);
            this.btnAzurirajStac.TabIndex = 1;
            this.btnAzurirajStac.Text = "Ažuriraj pacijenta stacionara";
            this.btnAzurirajStac.UseVisualStyleBackColor = false;
            this.btnAzurirajStac.Click += new System.EventHandler(this.btnAzurirajStac_Click);
            // 
            // btnBrisiStac
            // 
            this.btnBrisiStac.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBrisiStac.Location = new System.Drawing.Point(542, 315);
            this.btnBrisiStac.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrisiStac.Name = "btnBrisiStac";
            this.btnBrisiStac.Size = new System.Drawing.Size(141, 36);
            this.btnBrisiStac.TabIndex = 2;
            this.btnBrisiStac.Text = "Obriši pacijenta stacionara";
            this.btnBrisiStac.UseVisualStyleBackColor = false;
            this.btnBrisiStac.Click += new System.EventHandler(this.btnBrisiStac_Click);
            // 
            // listStacionari
            // 
            this.listStacionari.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listStacionari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnIme,
            this.columnPrezime,
            this.columnMB,
            this.columnDatimPrijema,
            this.columnDatumOtpusta,
            this.columnTipOd,
            this.columnImePrezimeOP});
            this.listStacionari.GridLines = true;
            this.listStacionari.HideSelection = false;
            this.listStacionari.Location = new System.Drawing.Point(31, 60);
            this.listStacionari.Margin = new System.Windows.Forms.Padding(2);
            this.listStacionari.Name = "listStacionari";
            this.listStacionari.Size = new System.Drawing.Size(653, 222);
            this.listStacionari.TabIndex = 4;
            this.listStacionari.UseCompatibleStateImageBehavior = false;
            this.listStacionari.View = System.Windows.Forms.View.Details;
            this.listStacionari.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            // 
            // columnIme
            // 
            this.columnIme.Text = "Ime";
            // 
            // columnPrezime
            // 
            this.columnPrezime.Text = "Prezime";
            this.columnPrezime.Width = 115;
            // 
            // columnMB
            // 
            this.columnMB.Text = "Matični broj";
            this.columnMB.Width = 123;
            // 
            // columnDatimPrijema
            // 
            this.columnDatimPrijema.Text = "Datum prijema";
            this.columnDatimPrijema.Width = 123;
            // 
            // columnDatumOtpusta
            // 
            this.columnDatumOtpusta.Text = "Datum otpusta";
            this.columnDatumOtpusta.Width = 182;
            // 
            // columnTipOd
            // 
            this.columnTipOd.Text = "Tip odeljenja";
            this.columnTipOd.Width = 152;
            // 
            // columnImePrezimeOP
            // 
            this.columnImePrezimeOP.Text = "Lekar opšte prakse";
            this.columnImePrezimeOP.Width = 129;
            // 
            // cmdExit
            // 
            this.cmdExit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdExit.Location = new System.Drawing.Point(31, 369);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(88, 30);
            this.cmdExit.TabIndex = 5;
            this.cmdExit.Text = "Nazad";
            this.cmdExit.UseVisualStyleBackColor = false;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // StacionarUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(722, 433);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.listStacionari);
            this.Controls.Add(this.btnBrisiStac);
            this.Controls.Add(this.btnAzurirajStac);
            this.Controls.Add(this.btnPStacionara);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StacionarUI";
            this.Text = "Pacijenti stacionara";
            this.Load += new System.EventHandler(this.StacionarUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPStacionara;
        private System.Windows.Forms.Button btnAzurirajStac;
        private System.Windows.Forms.Button btnBrisiStac;
        private System.Windows.Forms.ListView listStacionari;
        private System.Windows.Forms.ColumnHeader columnIme;
        private System.Windows.Forms.ColumnHeader columnPrezime;
        private System.Windows.Forms.ColumnHeader columnMB;
        private System.Windows.Forms.ColumnHeader columnDatimPrijema;
        private System.Windows.Forms.ColumnHeader columnDatumOtpusta;
        private System.Windows.Forms.ColumnHeader columnTipOd;
        private System.Windows.Forms.ColumnHeader columnImePrezimeOP;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.Button cmdExit;
    }
}