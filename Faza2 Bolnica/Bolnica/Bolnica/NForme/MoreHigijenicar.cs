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
    public partial class MoreHigijenicar : Form
    {
        public NemedicinskoOsobljeDTO nem { get; set; }
        public MoreHigijenicar(NemedicinskoOsobljeDTO n)
        {
            InitializeComponent();
            nem = n;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            HigijenicarUI nm = new HigijenicarUI();
         
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            nm.ShowDialog();
            this.Close();
        }
        private void popuniPodacima()
        {
            this.listOd.Items.Clear();
            List<OdrzavaHigijenuDTO> s = DTOManager.vratiZaduzenja();
            foreach (OdrzavaHigijenuDTO x in s)
            {
               if( x.Higijenicar.IDOsobe==nem.IDOsobe)
                listOd.Items.Add(new ListViewItem(new string[] { x.Odeljenje.ID.ToString(), x.Odeljenje.Sifra.ToString(), x.Odeljenje.Tip, x.Odeljenje.DatumIzgradnje.ToString()}
                ));
            }
            this.listOd.Refresh();
        }

        private void MoreHigijenicar_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
    }
}
