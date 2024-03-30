namespace Bolnica.NForme
{
    partial class MoreTehnicko
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoreTehnicko));
            this.listStolica = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnProizvodjac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDatumProizvodnje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listStolica
            // 
            this.listStolica.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listStolica.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnProizvodjac,
            this.columnDatumProizvodnje});
            this.listStolica.GridLines = true;
            this.listStolica.HideSelection = false;
            this.listStolica.Location = new System.Drawing.Point(14, 24);
            this.listStolica.Margin = new System.Windows.Forms.Padding(2);
            this.listStolica.Name = "listStolica";
            this.listStolica.Size = new System.Drawing.Size(320, 221);
            this.listStolica.TabIndex = 5;
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
            this.columnProizvodjac.Width = 103;
            // 
            // columnDatumProizvodnje
            // 
            this.columnDatumProizvodnje.Text = "Datum proizvodnje";
            this.columnDatumProizvodnje.Width = 153;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnOK.Location = new System.Drawing.Point(47, 304);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(88, 30);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listStolica);
            this.groupBox1.Location = new System.Drawing.Point(47, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(346, 258);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stolice koje ovaj tehnicar odrzava";
            // 
            // MoreTehnicko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(442, 366);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MoreTehnicko";
            this.Text = "Stomatološke stolice izabranog tehničkog osoblja";
            this.Load += new System.EventHandler(this.MoreTehnicko_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listStolica;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnProizvodjac;
        private System.Windows.Forms.ColumnHeader columnDatumProizvodnje;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}