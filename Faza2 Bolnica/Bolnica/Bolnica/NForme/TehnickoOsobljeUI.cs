using Bolnica.DTO;
using Bolnica.NForme;
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
    public partial class TehnickoOsobljeUI : Form
    {
        public TehnickoOsobljeUI()
        {
            InitializeComponent();
        }

        private void popuniPodacima()
        {

            this.listTehnicari.Items.Clear();
            List<NemedicinskoOsobljeDTO> zaposleni = DTOManager.vratiTehnicare();
            foreach (NemedicinskoOsobljeDTO x in zaposleni)
            {
                listTehnicari.Items.Add(new ListViewItem(new string[] { x.IDOsobe.ToString(), x.Ime, x.Prezime, x.MaticniBroj, x.Struka}
                ));
            }
         
            this.listTehnicari.Refresh();

        }

        private void cmdObrisiTO_Click(object sender, EventArgs e)
        {
            if (listTehnicari.SelectedItems.Count != 1)
            {
                MessageBox.Show("Izaberite tačno 1 tehničko osoblje!");
                return;
            }
            int idTehnicara = int.Parse(listTehnicari.SelectedItems[0].SubItems[0].Text);
            DTOManager.obrisiTehnicara(idTehnicara);
            popuniPodacima();
        }

        private void cmdDodajTO_Click(object sender, EventArgs e)
        {
            DodajTehnicara fs = new DodajTehnicara();
           
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            fs.ShowDialog();
            this.Close();
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            NeMedOsoba nm = new NeMedOsoba();
          
           
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            nm.ShowDialog();
            this.Close();
        }

        private void cmdAzurirajTO_Click(object sender, EventArgs e)
        {
            if (listTehnicari.SelectedItems.Count != 1)
            {
                MessageBox.Show("Izaberite tačno 1 tehničko osoblje!");
                return;
            }
            int idTehnicar = int.Parse(listTehnicari.SelectedItems[0].SubItems[0].Text);

            NemedicinskoOsobljeDTO zaIzmenuP = DTOManager.vratiTehnicara(idTehnicar);
            AzurirajTehnicko fs = new AzurirajTehnicko(zaIzmenuP);

            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            fs.ShowDialog();
            this.Close();
        }    

        private void TehnickoOsobljeUI_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void cmdMore_Click(object sender, EventArgs e)
        {
            if (listTehnicari.SelectedItems.Count != 1)
            {
                MessageBox.Show("Izaberite tačno 1 tehničko osoblje!");
                return;
            }
           
            int idT= int.Parse(listTehnicari.SelectedItems[0].SubItems[0].Text);
            NemedicinskoOsobljeDTO zaIzmenuNO = DTOManager.vratiTehnicko(idT);
            MoreTehnicko nm = new MoreTehnicko(zaIzmenuNO);
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            nm.ShowDialog();
            this.Close();
        }
    }
}
