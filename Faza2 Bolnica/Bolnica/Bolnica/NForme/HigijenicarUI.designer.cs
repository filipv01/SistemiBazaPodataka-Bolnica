namespace Bolnica
{
    partial class HigijenicarUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HigijenicarUI));
            this.cmdDodajHigijenicara = new System.Windows.Forms.Button();
            this.cmdObrisiHigijenicara = new System.Windows.Forms.Button();
            this.cmdBack = new System.Windows.Forms.Button();
            this.listHigijenicari = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMaticniBroj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdMore = new System.Windows.Forms.Button();
            this.cmdUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdDodajHigijenicara
            // 
            this.cmdDodajHigijenicara.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdDodajHigijenicara.Location = new System.Drawing.Point(475, 261);
            this.cmdDodajHigijenicara.Margin = new System.Windows.Forms.Padding(2);
            this.cmdDodajHigijenicara.Name = "cmdDodajHigijenicara";
            this.cmdDodajHigijenicara.Size = new System.Drawing.Size(88, 42);
            this.cmdDodajHigijenicara.TabIndex = 0;
            this.cmdDodajHigijenicara.Text = "Dodaj higijeničara";
            this.cmdDodajHigijenicara.UseVisualStyleBackColor = false;
            this.cmdDodajHigijenicara.Click += new System.EventHandler(this.cmdDodajHigijenicara_Click);
            // 
            // cmdObrisiHigijenicara
            // 
            this.cmdObrisiHigijenicara.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdObrisiHigijenicara.Location = new System.Drawing.Point(661, 261);
            this.cmdObrisiHigijenicara.Margin = new System.Windows.Forms.Padding(2);
            this.cmdObrisiHigijenicara.Name = "cmdObrisiHigijenicara";
            this.cmdObrisiHigijenicara.Size = new System.Drawing.Size(88, 42);
            this.cmdObrisiHigijenicara.TabIndex = 3;
            this.cmdObrisiHigijenicara.Text = "Obriši higijeničara";
            this.cmdObrisiHigijenicara.UseVisualStyleBackColor = false;
            this.cmdObrisiHigijenicara.Click += new System.EventHandler(this.cmdObrisiHigijenicara_Click);
            // 
            // cmdBack
            // 
            this.cmdBack.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdBack.Location = new System.Drawing.Point(29, 330);
            this.cmdBack.Margin = new System.Windows.Forms.Padding(2);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(88, 30);
            this.cmdBack.TabIndex = 5;
            this.cmdBack.Text = "Nazad";
            this.cmdBack.UseVisualStyleBackColor = false;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // listHigijenicari
            // 
            this.listHigijenicari.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listHigijenicari.BackgroundImageTiled = true;
            this.listHigijenicari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnIme,
            this.columnPrezime,
            this.columnMaticniBroj});
            this.listHigijenicari.GridLines = true;
            this.listHigijenicari.HideSelection = false;
            this.listHigijenicari.Location = new System.Drawing.Point(29, 49);
            this.listHigijenicari.Margin = new System.Windows.Forms.Padding(2);
            this.listHigijenicari.Name = "listHigijenicari";
            this.listHigijenicari.Size = new System.Drawing.Size(367, 254);
            this.listHigijenicari.TabIndex = 6;
            this.listHigijenicari.UseCompatibleStateImageBehavior = false;
            this.listHigijenicari.View = System.Windows.Forms.View.Details;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 70;
            // 
            // columnIme
            // 
            this.columnIme.Text = "Ime";
            this.columnIme.Width = 94;
            // 
            // columnPrezime
            // 
            this.columnPrezime.Text = "Prezime";
            this.columnPrezime.Width = 87;
            // 
            // columnMaticniBroj
            // 
            this.columnMaticniBroj.Text = "Matični broj";
            this.columnMaticniBroj.Width = 109;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(536, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 174);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // cmdMore
            // 
            this.cmdMore.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdMore.Location = new System.Drawing.Point(658, 330);
            this.cmdMore.Name = "cmdMore";
            this.cmdMore.Size = new System.Drawing.Size(88, 30);
            this.cmdMore.TabIndex = 8;
            this.cmdMore.Text = "Detaljnije";
            this.cmdMore.UseVisualStyleBackColor = false;
            this.cmdMore.Click += new System.EventHandler(this.cmdMore_Click);
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdUpdate.Location = new System.Drawing.Point(568, 261);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(88, 42);
            this.cmdUpdate.TabIndex = 9;
            this.cmdUpdate.Text = "Ažuriraj higijeničara";
            this.cmdUpdate.UseVisualStyleBackColor = false;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // HigijenicarUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(797, 384);
            this.Controls.Add(this.cmdUpdate);
            this.Controls.Add(this.cmdMore);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listHigijenicari);
            this.Controls.Add(this.cmdBack);
            this.Controls.Add(this.cmdObrisiHigijenicara);
            this.Controls.Add(this.cmdDodajHigijenicara);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HigijenicarUI";
            this.Text = "Higijenicari";
            this.Load += new System.EventHandler(this.HigijenicarUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdDodajHigijenicara;
        private System.Windows.Forms.Button cmdObrisiHigijenicara;
        private System.Windows.Forms.Button cmdBack;
        private System.Windows.Forms.ListView listHigijenicari;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnIme;
        private System.Windows.Forms.ColumnHeader columnPrezime;
        private System.Windows.Forms.ColumnHeader columnMaticniBroj;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdMore;
        private System.Windows.Forms.Button cmdUpdate;
    }
}