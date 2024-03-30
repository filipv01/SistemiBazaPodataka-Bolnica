using Bolnica.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bolnica
{
    public partial class NeMedOsoba : Form
    {
        public NeMedOsoba()
        {
            InitializeComponent();
        }

        private void NeMedOsoba_Load(object sender, EventArgs e)
        {
           
        }
        private void cmdTehnickoOsoblje_Click(object sender, EventArgs e)
        {
            TehnickoOsobljeUI f2 = new TehnickoOsobljeUI();
         
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            f2.ShowDialog();
            this.Close();
        }

        private void cmdHigijenicar_Click(object sender, EventArgs e)
        {
            HigijenicarUI f2 = new HigijenicarUI();
           
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            f2.ShowDialog();
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
    }
}
