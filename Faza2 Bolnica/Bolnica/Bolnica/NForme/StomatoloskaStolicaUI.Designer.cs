namespace Bolnica
{
    partial class StomatoloskaStolicaUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StomatoloskaStolicaUI));
            this.button2 = new System.Windows.Forms.Button();
            this.btnStomStolica = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listStolica = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnProizvodjac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDatumProizvodnje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnImePrezimeTO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.Location = new System.Drawing.Point(522, 130);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ažuriraj stomatološku stolicu";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnStomStolica
            // 
            this.btnStomStolica.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnStomStolica.Location = new System.Drawing.Point(522, 66);
            this.btnStomStolica.Margin = new System.Windows.Forms.Padding(2);
            this.btnStomStolica.Name = "btnStomStolica";
            this.btnStomStolica.Size = new System.Drawing.Size(130, 36);
            this.btnStomStolica.TabIndex = 2;
            this.btnStomStolica.Text = "Dodaj stomatološku stolicu";
            this.btnStomStolica.UseVisualStyleBackColor = false;
            this.btnStomStolica.Click += new System.EventHandler(this.btnStomStolica_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button3.Location = new System.Drawing.Point(522, 193);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "Briši stomatološku stolicu";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listStolica
            // 
            this.listStolica.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listStolica.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnProizvodjac,
            this.columnDatumProizvodnje,
            this.columnImePrezimeTO});
            this.listStolica.GridLines = true;
            this.listStolica.HideSelection = false;
            this.listStolica.Location = new System.Drawing.Point(25, 66);
            this.listStolica.Margin = new System.Windows.Forms.Padding(2);
            this.listStolica.Name = "listStolica";
            this.listStolica.Size = new System.Drawing.Size(468, 222);
            this.listStolica.TabIndex = 4;
            this.listStolica.UseCompatibleStateImageBehavior = false;
            this.listStolica.View = System.Windows.Forms.View.Details;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            // 
            // columnProizvodjac
            // 
            this.columnProizvodjac.Text = "Proizvodjač";
            this.columnProizvodjac.Width = 150;
            // 
            // columnDatumProizvodnje
            // 
            this.columnDatumProizvodnje.Text = "Datum proizvodnje";
            this.columnDatumProizvodnje.Width = 124;
            // 
            // columnImePrezimeTO
            // 
            this.columnImePrezimeTO.Text = "Tehničko osoblje";
            this.columnImePrezimeTO.Width = 165;
            // 
            // cmdExit
            // 
            this.cmdExit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdExit.Location = new System.Drawing.Point(25, 308);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(88, 30);
            this.cmdExit.TabIndex = 6;
            this.cmdExit.Text = "Nazad";
            this.cmdExit.UseVisualStyleBackColor = false;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // StomatoloskaStolicaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(675, 357);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.listStolica);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnStomStolica);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StomatoloskaStolicaUI";
            this.Text = "Stomatološke stolice";
            this.Load += new System.EventHandler(this.StomatoloskaStolicaUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnStomStolica;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView listStolica;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnProizvodjac;
        private System.Windows.Forms.ColumnHeader columnDatumProizvodnje;
        private System.Windows.Forms.ColumnHeader columnImePrezimeTO;
        private System.Windows.Forms.Button cmdExit;
    }
}