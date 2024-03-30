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
    public partial class MoreSpecijalista : Form
    {
        MedicinskoOsobljeDTO mediicinskoOsoblje;
        public MoreSpecijalista(MedicinskoOsobljeDTO m)
        {
            InitializeComponent();
            mediicinskoOsoblje = m;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SpecijalistaUI nm = new SpecijalistaUI();
          
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            nm.ShowDialog();
            this.Close();
        }
        private void popuniPodacima()
        {
            this.listOd.Items.Clear();
            List<OdeljenjeDTO> s = DTOManager.vratiOdeljenja();
            foreach (OdeljenjeDTO x in s)
            {
                if(x.Specijalista.IDOsobe==mediicinskoOsoblje.IDOsobe)
                listOd.Items.Add(new ListViewItem(new string[] { x.ID.ToString(), x.Sifra.ToString(), x.Tip, x.DatumIzgradnje.ToString()}
                ));
            }
           
            this.listOd.Refresh();

        }

        private void MoreSpecijalista_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
    }
}
