using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bolnica.DTO;
using Bolnica.NForme;
using NHibernate;
namespace Bolnica
{
    public partial class StacionarUI : Form
    {
        public StacionarUI()
        {
            InitializeComponent();
        }

        private void btnPStacionara_Click(object sender, EventArgs e)
        {
            DodajStacionara ds = new DodajStacionara();
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            ds.ShowDialog();
            this.Close();
        }

        private void StacionarUI_Load(object sender, EventArgs e)
        {
             popuniPodacima();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBrisiStac_Click(object sender, EventArgs e)
        {


            if (listStacionari.SelectedItems.Count != 1)
                {
                    MessageBox.Show("Izaberite tačno 1 pacijenta stacionara!");
                    return;
                }
                int idStacionara = int.Parse(listStacionari.SelectedItems[0].SubItems[0].Text);
                DTOManager.obrisiStacionare(idStacionara);
                popuniPodacima();
            
        }


        private void popuniPodacima()
        {

            this.listStacionari.Items.Clear();
            List<PacijentDTO> p = DTOManager.vratiStacionare();

            foreach (PacijentDTO x in p)
            {
               
                listStacionari.Items.Add(new ListViewItem(new string[] { x.IDOsobe.ToString(), x.Ime, x.Prezime, x.MaticniBroj, x.DatumPrijema.ToString(), x.DatumOtpusta.ToString(), x.Odeljenje.Tip, x.LekarOpstePrakse?.Ime +" "+ x.LekarOpstePrakse?.Prezime }
                )) ;
            }
           
            this.listStacionari.Refresh();

        }



        private void cmdExit_Click(object sender, EventArgs e)
        {
            Pacijenti p = new Pacijenti();
           
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();
            this.Close();

        }

        private void btnAzurirajStac_Click(object sender, EventArgs e)
        {
            if (listStacionari.SelectedItems.Count != 1)
            {
                MessageBox.Show("Izaberite tačno 1 pacijenta stacionara!");
                return;
            }

            int idStacionar = int.Parse(listStacionari.SelectedItems[0].SubItems[0].Text);

            PacijentDTO zaIzmenuP = DTOManager.vratiStacionara(idStacionar);
            AzurirajStac fs = new AzurirajStac(zaIzmenuP);

            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            fs.ShowDialog();
            this.Close();

        }
    }
}
