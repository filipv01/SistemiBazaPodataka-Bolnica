namespace Bolnica
{
    partial class AmbulantaUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AmbulantaUI));
            this.btnDodajAmb = new System.Windows.Forms.Button();
            this.btnAzurirajAmb = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnBrisiAmb = new System.Windows.Forms.Button();
            this.listAmb = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMaticniBroj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAdresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnImeIPrezimeS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVrstaI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDatumInt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLekarOP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnDodajAmb
            // 
            this.btnDodajAmb.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDodajAmb.Location = new System.Drawing.Point(65, 250);
            this.btnDodajAmb.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajAmb.Name = "btnDodajAmb";
            this.btnDodajAmb.Size = new System.Drawing.Size(141, 38);
            this.btnDodajAmb.TabIndex = 0;
            this.btnDodajAmb.Text = "Dodaj pacijenta ambulante";
            this.btnDodajAmb.UseVisualStyleBackColor = false;
            this.btnDodajAmb.Click += new System.EventHandler(this.btnDodajAmb_Click);
            // 
            // btnAzurirajAmb
            // 
            this.btnAzurirajAmb.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAzurirajAmb.Location = new System.Drawing.Point(325, 250);
            this.btnAzurirajAmb.Margin = new System.Windows.Forms.Padding(2);
            this.btnAzurirajAmb.Name = "btnAzurirajAmb";
            this.btnAzurirajAmb.Size = new System.Drawing.Size(141, 38);
            this.btnAzurirajAmb.TabIndex = 1;
            this.btnAzurirajAmb.Text = "Ažuriraj pacijenta ambulante";
            this.btnAzurirajAmb.UseVisualStyleBackColor = false;
            this.btnAzurirajAmb.Click += new System.EventHandler(this.btnAzurirajAmb_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button4.Location = new System.Drawing.Point(65, 309);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 30);
            this.button4.TabIndex = 3;
            this.button4.Text = "Nazad";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnBrisiAmb
            // 
            this.btnBrisiAmb.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBrisiAmb.Location = new System.Drawing.Point(554, 250);
            this.btnBrisiAmb.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrisiAmb.Name = "btnBrisiAmb";
            this.btnBrisiAmb.Size = new System.Drawing.Size(141, 38);
            this.btnBrisiAmb.TabIndex = 4;
            this.btnBrisiAmb.Text = "Obriši pacijenta ambulante";
            this.btnBrisiAmb.UseVisualStyleBackColor = false;
            this.btnBrisiAmb.Click += new System.EventHandler(this.btnBrisiAmb_Click);
            // 
            // listAmb
            // 
            this.listAmb.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listAmb.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnIme,
            this.columnPrezime,
            this.columnMaticniBroj,
            this.columnAdresa,
            this.columnImeIPrezimeS,
            this.columnVrstaI,
            this.columnDatumInt,
            this.columnLekarOP});
            this.listAmb.GridLines = true;
            this.listAmb.HideSelection = false;
            this.listAmb.Location = new System.Drawing.Point(65, 71);
            this.listAmb.Margin = new System.Windows.Forms.Padding(2);
            this.listAmb.Name = "listAmb";
            this.listAmb.Size = new System.Drawing.Size(631, 169);
            this.listAmb.TabIndex = 5;
            this.listAmb.UseCompatibleStateImageBehavior = false;
            this.listAmb.View = System.Windows.Forms.View.Details;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 43;
            // 
            // columnIme
            // 
            this.columnIme.Text = "Ime";
            this.columnIme.Width = 81;
            // 
            // columnPrezime
            // 
            this.columnPrezime.Text = "Prezime";
            this.columnPrezime.Width = 89;
            // 
            // columnMaticniBroj
            // 
            this.columnMaticniBroj.Text = "Matični broj";
            this.columnMaticniBroj.Width = 132;
            // 
            // columnAdresa
            // 
            this.columnAdresa.Text = "Adresa";
            this.columnAdresa.Width = 161;
            // 
            // columnImeIPrezimeS
            // 
            this.columnImeIPrezimeS.Text = "Stomatolog";
            this.columnImeIPrezimeS.Width = 207;
            // 
            // columnVrstaI
            // 
            this.columnVrstaI.Text = "Vrsta intervencije";
            this.columnVrstaI.Width = 200;
            // 
            // columnDatumInt
            // 
            this.columnDatumInt.Text = "Datum intervencije";
            this.columnDatumInt.Width = 163;
            // 
            // columnLekarOP
            // 
            this.columnLekarOP.Text = "Lekar opste prakse";
            this.columnLekarOP.Width = 145;
            // 
            // AmbulantaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(765, 365);
            this.Controls.Add(this.listAmb);
            this.Controls.Add(this.btnBrisiAmb);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnAzurirajAmb);
            this.Controls.Add(this.btnDodajAmb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AmbulantaUI";
            this.Text = "Pacijenti ambulante";
            this.Load += new System.EventHandler(this.AmbulantaUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodajAmb;
        private System.Windows.Forms.Button btnAzurirajAmb;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnBrisiAmb;
        private System.Windows.Forms.ListView listAmb;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnIme;
        private System.Windows.Forms.ColumnHeader columnPrezime;
        private System.Windows.Forms.ColumnHeader columnMaticniBroj;
        private System.Windows.Forms.ColumnHeader columnAdresa;
        private System.Windows.Forms.ColumnHeader columnImeIPrezimeS;
        private System.Windows.Forms.ColumnHeader columnVrstaI;
        private System.Windows.Forms.ColumnHeader columnDatumInt;
        private System.Windows.Forms.ColumnHeader columnLekarOP;
    }
}