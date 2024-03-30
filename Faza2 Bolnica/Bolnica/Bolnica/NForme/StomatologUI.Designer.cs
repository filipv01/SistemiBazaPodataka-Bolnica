namespace Bolnica
{
    partial class StomatologUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StomatologUI));
            this.btnDodajStomatologa = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.listStomatolozi = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGRS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSmena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIDS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajStomatologa
            // 
            this.btnDodajStomatologa.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDodajStomatologa.Location = new System.Drawing.Point(304, 275);
            this.btnDodajStomatologa.Name = "btnDodajStomatologa";
            this.btnDodajStomatologa.Size = new System.Drawing.Size(136, 32);
            this.btnDodajStomatologa.TabIndex = 1;
            this.btnDodajStomatologa.Text = "Dodaj stomatologa";
            this.btnDodajStomatologa.UseVisualStyleBackColor = false;
            this.btnDodajStomatologa.Click += new System.EventHandler(this.btnDodajStomatologa_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnUpdate.Location = new System.Drawing.Point(450, 275);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(136, 32);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Ažuriraj stomatologa";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDelete.Location = new System.Drawing.Point(593, 275);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 32);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Obriši stomatologa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnExit.Location = new System.Drawing.Point(45, 332);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 30);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Nazad";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // listStomatolozi
            // 
            this.listStomatolozi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listStomatolozi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnIme,
            this.columnPrezime,
            this.columnMB,
            this.columnGRS,
            this.columnSmena,
            this.columnIDS});
            this.listStomatolozi.GridLines = true;
            this.listStomatolozi.HideSelection = false;
            this.listStomatolozi.Location = new System.Drawing.Point(304, 60);
            this.listStomatolozi.Name = "listStomatolozi";
            this.listStomatolozi.Size = new System.Drawing.Size(425, 196);
            this.listStomatolozi.TabIndex = 5;
            this.listStomatolozi.UseCompatibleStateImageBehavior = false;
            this.listStomatolozi.View = System.Windows.Forms.View.Details;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 38;
            // 
            // columnIme
            // 
            this.columnIme.Text = "Ime";
            this.columnIme.Width = 63;
            // 
            // columnPrezime
            // 
            this.columnPrezime.Text = "Prezime";
            this.columnPrezime.Width = 76;
            // 
            // columnMB
            // 
            this.columnMB.Text = "Matični broj";
            this.columnMB.Width = 70;
            // 
            // columnGRS
            // 
            this.columnGRS.Text = "Godine radnog staža";
            this.columnGRS.Width = 111;
            // 
            // columnSmena
            // 
            this.columnSmena.Text = "Smena";
            this.columnSmena.Width = 64;
            // 
            // columnIDS
            // 
            this.columnIDS.Text = "Stolica";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 60);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 247);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // StomatologUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(802, 414);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listStomatolozi);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDodajStomatologa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StomatologUI";
            this.Text = "Stomatolozi";
            this.Load += new System.EventHandler(this.StomatologUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDodajStomatologa;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListView listStomatolozi;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnIme;
        private System.Windows.Forms.ColumnHeader columnPrezime;
        private System.Windows.Forms.ColumnHeader columnMB;
        private System.Windows.Forms.ColumnHeader columnGRS;
        private System.Windows.Forms.ColumnHeader columnSmena;
        private System.Windows.Forms.ColumnHeader columnIDS;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}