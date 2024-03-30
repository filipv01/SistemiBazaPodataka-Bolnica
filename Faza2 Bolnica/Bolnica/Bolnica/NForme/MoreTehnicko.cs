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
    public partial class MoreTehnicko : Form
    {
        NemedicinskoOsobljeDTO nemed = new NemedicinskoOsobljeDTO();
        public MoreTehnicko(NemedicinskoOsobljeDTO n)
        {
            InitializeComponent();
            nemed = n;  
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            TehnickoOsobljeUI nm = new TehnickoOsobljeUI();
           
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            nm.ShowDialog();
            this.Close();
        }
        private void popuniPodacima()
        {
            this.listStolica.Items.Clear();
            List<StomatoloskaStolicaDTO> s = DTOManager.vratiStolice();
            foreach (StomatoloskaStolicaDTO x in s)
            {
                if( x.TehnickoOdrzavanje!=null && x.TehnickoOdrzavanje.IDOsobe==nemed.IDOsobe)
                listStolica.Items.Add(new ListViewItem(new string[] { x.ID.ToString(), x.Proizvodjac, x.DatumProizvodnje.ToString()}
                ));
            }
            this.listStolica.Refresh();
        }

        private void MoreTehnicko_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
    }
}
