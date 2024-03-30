namespace Bolnica
{
    partial class OpstaPraksaUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpstaPraksaUI));
            this.listOP = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGRS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBrO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdDodajOP = new System.Windows.Forms.Button();
            this.cmdUpdateOP = new System.Windows.Forms.Button();
            this.cmdDeleteOP = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listOP
            // 
            this.listOP.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listOP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnIme,
            this.columnPrezime,
            this.columnMB,
            this.columnGRS,
            this.columnBrO});
            this.listOP.GridLines = true;
            this.listOP.HideSelection = false;
            this.listOP.Location = new System.Drawing.Point(293, 65);
            this.listOP.Name = "listOP";
            this.listOP.Size = new System.Drawing.Size(517, 213);
            this.listOP.TabIndex = 0;
            this.listOP.UseCompatibleStateImageBehavior = false;
            this.listOP.View = System.Windows.Forms.View.Details;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 49;
            // 
            // columnIme
            // 
            this.columnIme.Text = "Ime";
            this.columnIme.Width = 77;
            // 
            // columnPrezime
            // 
            this.columnPrezime.Text = "Prezime";
            this.columnPrezime.Width = 77;
            // 
            // columnMB
            // 
            this.columnMB.Text = "Matični broj";
            this.columnMB.Width = 119;
            // 
            // columnGRS
            // 
            this.columnGRS.Text = "Godine radnog staža";
            this.columnGRS.Width = 110;
            // 
            // columnBrO
            // 
            this.columnBrO.Text = "Broj ordinacije";
            this.columnBrO.Width = 82;
            // 
            // cmdDodajOP
            // 
            this.cmdDodajOP.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdDodajOP.Location = new System.Drawing.Point(293, 306);
            this.cmdDodajOP.Name = "cmdDodajOP";
            this.cmdDodajOP.Size = new System.Drawing.Size(140, 30);
            this.cmdDodajOP.TabIndex = 1;
            this.cmdDodajOP.Text = "Dodaj lekara opšte prakse";
            this.cmdDodajOP.UseVisualStyleBackColor = false;
            this.cmdDodajOP.Click += new System.EventHandler(this.cmdDodajOP_Click);
            // 
            // cmdUpdateOP
            // 
            this.cmdUpdateOP.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdUpdateOP.Location = new System.Drawing.Point(482, 306);
            this.cmdUpdateOP.Name = "cmdUpdateOP";
            this.cmdUpdateOP.Size = new System.Drawing.Size(140, 30);
            this.cmdUpdateOP.TabIndex = 2;
            this.cmdUpdateOP.Text = "Ažuriraj lekara opšte prakse";
            this.cmdUpdateOP.UseVisualStyleBackColor = false;
            this.cmdUpdateOP.Click += new System.EventHandler(this.cmdUpdateOP_Click);
            // 
            // cmdDeleteOP
            // 
            this.cmdDeleteOP.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdDeleteOP.Location = new System.Drawing.Point(662, 306);
            this.cmdDeleteOP.Name = "cmdDeleteOP";
            this.cmdDeleteOP.Size = new System.Drawing.Size(140, 30);
            this.cmdDeleteOP.TabIndex = 3;
            this.cmdDeleteOP.Text = "Obriši lekara opšte prakse";
            this.cmdDeleteOP.UseVisualStyleBackColor = false;
            this.cmdDeleteOP.Click += new System.EventHandler(this.cmdDeleteOP_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnExit.Location = new System.Drawing.Point(55, 368);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 30);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Nazad";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 65);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 228);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // OpstaPraksaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(866, 436);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cmdDeleteOP);
            this.Controls.Add(this.cmdUpdateOP);
            this.Controls.Add(this.cmdDodajOP);
            this.Controls.Add(this.listOP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OpstaPraksaUI";
            this.Text = "Lekari opšte prakse";
            this.Load += new System.EventHandler(this.OpstaPraksaUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listOP;
        private System.Windows.Forms.Button cmdDodajOP;
        private System.Windows.Forms.Button cmdUpdateOP;
        private System.Windows.Forms.Button cmdDeleteOP;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnIme;
        private System.Windows.Forms.ColumnHeader columnPrezime;
        private System.Windows.Forms.ColumnHeader columnMB;
        private System.Windows.Forms.ColumnHeader columnGRS;
        private System.Windows.Forms.ColumnHeader columnBrO;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}