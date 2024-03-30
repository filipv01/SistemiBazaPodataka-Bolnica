using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bolnica.Entiteti
{
    public partial class MedOsoba : Form
    {
        public MedOsoba()
        {
            InitializeComponent();
        }

   
        private void cmdStomatolog_Click(object sender, EventArgs e)
        {
            StomatologUI sUI=new StomatologUI();
          
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            sUI.ShowDialog();
            this.Close();
        }

    
        private void cmdBack_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
           
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            f1.ShowDialog();
            this.Close();
        }

        private void cmdLekarOP_Click(object sender, EventArgs e)
        {
            OpstaPraksaUI OP = new OpstaPraksaUI();
            
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            OP.ShowDialog();
            this.Close();
        }

        private void cmdSpecijalista_Click(object sender, EventArgs e)
        {
            SpecijalistaUI s = new SpecijalistaUI();
          
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            s.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Odaberite jednog lekara ili idite na dugme Nazad", "", MessageBoxButtons.OK);
           
        }

    }
}
