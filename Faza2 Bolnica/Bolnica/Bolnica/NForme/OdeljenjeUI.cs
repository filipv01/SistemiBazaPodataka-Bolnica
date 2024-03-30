using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using Bolnica.DTO;
using Bolnica.NForme;

namespace Bolnica
{
    public partial class OdeljenjeUI : Form
    {
        public OdeljenjeUI()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajOdeljenje d = new DodajOdeljenje();
           
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            d.ShowDialog();
            this.Close();
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            if (listOd.SelectedItems.Count != 1)
            {
                MessageBox.Show("Izaberite tačno 1 odeljenje!");
                return;
            }
            int idOd = int.Parse(listOd.SelectedItems[0].SubItems[0].Text);
            DTOManager.obrisiOdeljenje(idOd);
            popuniPodacima();
        }

        private void popuniPodacima()
        {
            this.listOd.Items.Clear();
            List<OdeljenjeDTO> s = DTOManager.vratiOdeljenja();
            foreach (OdeljenjeDTO x in s)
            {
                listOd.Items.Add(new ListViewItem(new string[] { x.ID.ToString(), x.Sifra.ToString(), x.Tip, x.DatumIzgradnje.ToString(), x.Specijalista?.Ime +" "+ x.Specijalista?.Prezime }
                ));
            }
          
            this.listOd.Refresh();

        }

        private void OdeljenjeUI_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            f1.ShowDialog();
            this.Close();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {

            if (listOd.SelectedItems.Count != 1)
            {
                MessageBox.Show("Izaberite tačno 1 odeljenje!");
                return;
            }



            int idOd = int.Parse(listOd.SelectedItems[0].SubItems[0].Text);
         
            OdeljenjeDTO zaIzmenuMO = DTOManager.vratiOd(idOd);
            AzurirajOdeljenje fs = new AzurirajOdeljenje(zaIzmenuMO);




          
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            fs.ShowDialog();
            this.Close();
        


         
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (listOd.SelectedItems.Count != 1)
            {
                MessageBox.Show("Izaberite tačno 1 odeljenje!");
                return;
            }
            int id = int.Parse(listOd.SelectedItems[0].SubItems[0].Text);
            OdeljenjeDTO zaIzmenuNMO = DTOManager.vratiOd(id);
            MoreOdeljenje o = new MoreOdeljenje(zaIzmenuNMO);

            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            o.ShowDialog();
            this.Close();
        }
    }

}
