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
    public partial class Pacijenti : Form
    {
        public Pacijenti()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
           
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            f.ShowDialog();
            this.Close();
        }

        private void btnStacionar_Click(object sender, EventArgs e)
        {
            StacionarUI s = new StacionarUI();
           
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            s.ShowDialog();
            this.Close();
        }

        private void brnAmbulanta_Click(object sender, EventArgs e)
        {
            AmbulantaUI a = new AmbulantaUI();
           
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            a.ShowDialog();
            this.Close();
        }
    }
}
