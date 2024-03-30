namespace Bolnica.NForme
{
    partial class MoreHigijenicar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoreHigijenicar));
            this.btnOK = new System.Windows.Forms.Button();
            this.listOd = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSifra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDatumIzgradnje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnOK.Location = new System.Drawing.Point(26, 254);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(88, 30);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // listOd
            // 
            this.listOd.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listOd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnSifra,
            this.columnTip,
            this.columnDatumIzgradnje});
            this.listOd.GridLines = true;
            this.listOd.HideSelection = false;
            this.listOd.Location = new System.Drawing.Point(26, 35);
            this.listOd.Margin = new System.Windows.Forms.Padding(2);
            this.listOd.Name = "listOd";
            this.listOd.Size = new System.Drawing.Size(341, 191);
            this.listOd.TabIndex = 2;
            this.listOd.UseCompatibleStateImageBehavior = false;
            this.listOd.View = System.Windows.Forms.View.Details;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            // 
            // columnSifra
            // 
            this.columnSifra.Text = "Šifra";
            this.columnSifra.Width = 86;
            // 
            // columnTip
            // 
            this.columnTip.Text = "Tip";
            this.columnTip.Width = 78;
            // 
            // columnDatumIzgradnje
            // 
            this.columnDatumIzgradnje.Text = "Datum izgradnje";
            this.columnDatumIzgradnje.Width = 113;
            // 
            // MoreHigijenicar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(414, 312);
            this.Controls.Add(this.listOd);
            this.Controls.Add(this.btnOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MoreHigijenicar";
            this.Text = "Odeljenja izabranog higijeničara";
            this.Load += new System.EventHandler(this.MoreHigijenicar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ListView listOd;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnSifra;
        private System.Windows.Forms.ColumnHeader columnTip;
        private System.Windows.Forms.ColumnHeader columnDatumIzgradnje;
    }
}