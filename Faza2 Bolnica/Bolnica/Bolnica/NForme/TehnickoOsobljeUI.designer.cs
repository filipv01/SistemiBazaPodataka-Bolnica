namespace Bolnica
{
    partial class TehnickoOsobljeUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TehnickoOsobljeUI));
            this.cmdDodajTO = new System.Windows.Forms.Button();
            this.cmdAzurirajTO = new System.Windows.Forms.Button();
            this.cmdObrisiTO = new System.Windows.Forms.Button();
            this.cmdBack = new System.Windows.Forms.Button();
            this.listTehnicari = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStruka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdMore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdDodajTO
            // 
            this.cmdDodajTO.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdDodajTO.Location = new System.Drawing.Point(461, 54);
            this.cmdDodajTO.Margin = new System.Windows.Forms.Padding(2);
            this.cmdDodajTO.Name = "cmdDodajTO";
            this.cmdDodajTO.Size = new System.Drawing.Size(87, 51);
            this.cmdDodajTO.TabIndex = 1;
            this.cmdDodajTO.Text = "Dodaj tehničko osoblje";
            this.cmdDodajTO.UseVisualStyleBackColor = false;
            this.cmdDodajTO.Click += new System.EventHandler(this.cmdDodajTO_Click);
            // 
            // cmdAzurirajTO
            // 
            this.cmdAzurirajTO.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdAzurirajTO.Location = new System.Drawing.Point(461, 109);
            this.cmdAzurirajTO.Margin = new System.Windows.Forms.Padding(2);
            this.cmdAzurirajTO.Name = "cmdAzurirajTO";
            this.cmdAzurirajTO.Size = new System.Drawing.Size(87, 51);
            this.cmdAzurirajTO.TabIndex = 2;
            this.cmdAzurirajTO.Text = "Ažuriraj tehničko osoblje";
            this.cmdAzurirajTO.UseVisualStyleBackColor = false;
            this.cmdAzurirajTO.Click += new System.EventHandler(this.cmdAzurirajTO_Click);
            // 
            // cmdObrisiTO
            // 
            this.cmdObrisiTO.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdObrisiTO.Location = new System.Drawing.Point(461, 164);
            this.cmdObrisiTO.Margin = new System.Windows.Forms.Padding(2);
            this.cmdObrisiTO.Name = "cmdObrisiTO";
            this.cmdObrisiTO.Size = new System.Drawing.Size(87, 51);
            this.cmdObrisiTO.TabIndex = 3;
            this.cmdObrisiTO.Text = "Obriši tehničko osoblje";
            this.cmdObrisiTO.UseVisualStyleBackColor = false;
            this.cmdObrisiTO.Click += new System.EventHandler(this.cmdObrisiTO_Click);
            // 
            // cmdBack
            // 
            this.cmdBack.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdBack.Location = new System.Drawing.Point(11, 301);
            this.cmdBack.Margin = new System.Windows.Forms.Padding(2);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(88, 30);
            this.cmdBack.TabIndex = 4;
            this.cmdBack.Text = "Nazad";
            this.cmdBack.UseVisualStyleBackColor = false;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // listTehnicari
            // 
            this.listTehnicari.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listTehnicari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnIme,
            this.columnPrezime,
            this.columnMB,
            this.columnStruka});
            this.listTehnicari.GridLines = true;
            this.listTehnicari.HideSelection = false;
            this.listTehnicari.Location = new System.Drawing.Point(11, 54);
            this.listTehnicari.Margin = new System.Windows.Forms.Padding(2);
            this.listTehnicari.Name = "listTehnicari";
            this.listTehnicari.Size = new System.Drawing.Size(433, 222);
            this.listTehnicari.TabIndex = 5;
            this.listTehnicari.UseCompatibleStateImageBehavior = false;
            this.listTehnicari.View = System.Windows.Forms.View.Details;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 55;
            // 
            // columnIme
            // 
            this.columnIme.Text = "Ime";
            this.columnIme.Width = 71;
            // 
            // columnPrezime
            // 
            this.columnPrezime.Text = "Prezime";
            this.columnPrezime.Width = 87;
            // 
            // columnMB
            // 
            this.columnMB.Text = "Matični broj";
            this.columnMB.Width = 111;
            // 
            // columnStruka
            // 
            this.columnStruka.Text = "Struka";
            this.columnStruka.Width = 112;
            // 
            // cmdMore
            // 
            this.cmdMore.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdMore.Location = new System.Drawing.Point(461, 220);
            this.cmdMore.Name = "cmdMore";
            this.cmdMore.Size = new System.Drawing.Size(87, 51);
            this.cmdMore.TabIndex = 9;
            this.cmdMore.Text = "Detaljnije";
            this.cmdMore.UseVisualStyleBackColor = false;
            this.cmdMore.Click += new System.EventHandler(this.cmdMore_Click);
            // 
            // TehnickoOsobljeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.cmdMore);
            this.Controls.Add(this.listTehnicari);
            this.Controls.Add(this.cmdBack);
            this.Controls.Add(this.cmdObrisiTO);
            this.Controls.Add(this.cmdAzurirajTO);
            this.Controls.Add(this.cmdDodajTO);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TehnickoOsobljeUI";
            this.Text = "Tehnicko osoblje";
            this.Load += new System.EventHandler(this.TehnickoOsobljeUI_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdDodajTO;
        private System.Windows.Forms.Button cmdAzurirajTO;
        private System.Windows.Forms.Button cmdObrisiTO;
        private System.Windows.Forms.Button cmdBack;
        private System.Windows.Forms.ListView listTehnicari;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnIme;
        private System.Windows.Forms.ColumnHeader columnPrezime;
        private System.Windows.Forms.ColumnHeader columnMB;
        private System.Windows.Forms.ColumnHeader columnStruka;
        private System.Windows.Forms.Button cmdMore;
    }
}