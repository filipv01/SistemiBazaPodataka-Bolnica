namespace Bolnica
{
    partial class SpecijalistaUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpecijalistaUI));
            this.cmdDodajSpec = new System.Windows.Forms.Button();
            this.cmdUpdateSpec = new System.Windows.Forms.Button();
            this.cmdDeleteSpec = new System.Windows.Forms.Button();
            this.cmdBack = new System.Windows.Forms.Button();
            this.listSpecijalisti = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGRS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSpecijalnost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdMore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdDodajSpec
            // 
            this.cmdDodajSpec.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdDodajSpec.Location = new System.Drawing.Point(236, 289);
            this.cmdDodajSpec.Name = "cmdDodajSpec";
            this.cmdDodajSpec.Size = new System.Drawing.Size(140, 34);
            this.cmdDodajSpec.TabIndex = 1;
            this.cmdDodajSpec.Text = "Dodaj lekara specijalistu";
            this.cmdDodajSpec.UseVisualStyleBackColor = false;
            this.cmdDodajSpec.Click += new System.EventHandler(this.cmdDodajSpec_Click);
            // 
            // cmdUpdateSpec
            // 
            this.cmdUpdateSpec.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdUpdateSpec.Location = new System.Drawing.Point(380, 289);
            this.cmdUpdateSpec.Name = "cmdUpdateSpec";
            this.cmdUpdateSpec.Size = new System.Drawing.Size(140, 34);
            this.cmdUpdateSpec.TabIndex = 2;
            this.cmdUpdateSpec.Text = "Ažuriraj lekara specijalistu";
            this.cmdUpdateSpec.UseVisualStyleBackColor = false;
            this.cmdUpdateSpec.Click += new System.EventHandler(this.cmdUpdateSpec_Click);
            // 
            // cmdDeleteSpec
            // 
            this.cmdDeleteSpec.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdDeleteSpec.Location = new System.Drawing.Point(523, 289);
            this.cmdDeleteSpec.Name = "cmdDeleteSpec";
            this.cmdDeleteSpec.Size = new System.Drawing.Size(140, 34);
            this.cmdDeleteSpec.TabIndex = 3;
            this.cmdDeleteSpec.Text = "Obriši lekara specijalistu";
            this.cmdDeleteSpec.UseVisualStyleBackColor = false;
            this.cmdDeleteSpec.Click += new System.EventHandler(this.cmdDeleteSpec_Click);
            // 
            // cmdBack
            // 
            this.cmdBack.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdBack.Location = new System.Drawing.Point(43, 347);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(88, 30);
            this.cmdBack.TabIndex = 4;
            this.cmdBack.Text = "Nazad";
            this.cmdBack.UseVisualStyleBackColor = false;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // listSpecijalisti
            // 
            this.listSpecijalisti.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listSpecijalisti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnIme,
            this.columnPrezime,
            this.columnMB,
            this.columnGRS,
            this.columnSpecijalnost});
            this.listSpecijalisti.GridLines = true;
            this.listSpecijalisti.HideSelection = false;
            this.listSpecijalisti.Location = new System.Drawing.Point(236, 65);
            this.listSpecijalisti.Name = "listSpecijalisti";
            this.listSpecijalisti.Size = new System.Drawing.Size(427, 206);
            this.listSpecijalisti.TabIndex = 5;
            this.listSpecijalisti.UseCompatibleStateImageBehavior = false;
            this.listSpecijalisti.View = System.Windows.Forms.View.Details;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 40;
            // 
            // columnIme
            // 
            this.columnIme.Text = "Ime";
            // 
            // columnPrezime
            // 
            this.columnPrezime.Text = "Prezime";
            // 
            // columnMB
            // 
            this.columnMB.Text = "Matčini broj";
            this.columnMB.Width = 67;
            // 
            // columnGRS
            // 
            this.columnGRS.Text = "Godine radnog staža";
            this.columnGRS.Width = 114;
            // 
            // columnSpecijalnost
            // 
            this.columnSpecijalnost.Text = "Specijalnost";
            this.columnSpecijalnost.Width = 102;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 58);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 212);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // cmdMore
            // 
            this.cmdMore.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdMore.Location = new System.Drawing.Point(575, 347);
            this.cmdMore.Name = "cmdMore";
            this.cmdMore.Size = new System.Drawing.Size(88, 30);
            this.cmdMore.TabIndex = 7;
            this.cmdMore.Text = "Detaljnije";
            this.cmdMore.UseVisualStyleBackColor = false;
            this.cmdMore.Click += new System.EventHandler(this.cmdMore_Click);
            // 
            // SpecijalistaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(724, 424);
            this.Controls.Add(this.cmdMore);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listSpecijalisti);
            this.Controls.Add(this.cmdBack);
            this.Controls.Add(this.cmdDeleteSpec);
            this.Controls.Add(this.cmdUpdateSpec);
            this.Controls.Add(this.cmdDodajSpec);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SpecijalistaUI";
            this.Text = "Lekari specijalisti";
            this.Load += new System.EventHandler(this.SpecijalistaUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdDodajSpec;
        private System.Windows.Forms.Button cmdUpdateSpec;
        private System.Windows.Forms.Button cmdDeleteSpec;
        private System.Windows.Forms.Button cmdBack;
        private System.Windows.Forms.ListView listSpecijalisti;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnIme;
        private System.Windows.Forms.ColumnHeader columnPrezime;
        private System.Windows.Forms.ColumnHeader columnMB;
        private System.Windows.Forms.ColumnHeader columnGRS;
        private System.Windows.Forms.ColumnHeader columnSpecijalnost;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdMore;
    }
}