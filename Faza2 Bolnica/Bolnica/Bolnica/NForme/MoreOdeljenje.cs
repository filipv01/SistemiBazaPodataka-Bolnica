using Bolnica.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bolnica.NForme
{
    public partial class MoreOdeljenje : Form
    {
        public OdeljenjeDTO od { get; set; }
        public MoreOdeljenje(OdeljenjeDTO o)
        {
            InitializeComponent();
            od = o;
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            OdeljenjeUI nm = new OdeljenjeUI();
           
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            nm.ShowDialog();
            this.Close();
        }
        private void popuniPodacima()
        {
            this.listView1.Items.Clear();
            List<PacijentDTO> s = DTOManager.vratiStacionare();
            foreach (PacijentDTO x in s)
            {
                if (x.Odeljenje.ID==od.ID)
                    listView1.Items.Add(new ListViewItem(new string[] { x.IDOsobe.ToString(), x.Ime+" "+x.Prezime, x.MaticniBroj}
                    ));
            }
            this.listView1.Refresh();
        }
        private void MoreOdeljenje_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
    }
}
