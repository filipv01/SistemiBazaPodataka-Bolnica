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
using Bolnica.Entiteti;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using NHibernate;
using Bolnica.NForme;

namespace Bolnica
{
    public partial class AmbulantaUI : Form
    {
        public AmbulantaUI()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pacijenti p = new Pacijenti();
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();
            this.Close();
        }

        private void btnDodajAmb_Click(object sender, EventArgs e)
        {
            FormaDodajAmbulanta fda = new FormaDodajAmbulanta();
            
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            fda.ShowDialog();
            this.Close();
        }

        private void btnBrisiAmb_Click(object sender, EventArgs e)
        {
            if (listAmb.SelectedItems.Count != 1)
            {
                MessageBox.Show("Izaberite tačno 1 pacijenta ambulante!");
                return;
            }
            int idAmbulante = int.Parse(listAmb.SelectedItems[0].SubItems[0].Text);
            DTOManager.obrisiStacionare(idAmbulante);
            popuniPodacima();
        }

        private void popuniPodacima()
        {

            this.listAmb.Items.Clear();
            List<PacijentDTO> s = DTOManager.vratiSveAmb();
            foreach (PacijentDTO x in s)
            {
                listAmb.Items.Add(new ListViewItem(new string[] { x.IDOsobe.ToString(), x.Ime, x.Prezime, x.MaticniBroj, x.Adresa.ToString(), x.Stomatolog?.Ime + " " + x.Stomatolog?.Prezime, x.VrstaIntervencije, x.DatumIntervencije.ToString(), x.LekarOpstePrakse?.Ime + " " + x.LekarOpstePrakse?.Prezime }
                ));
            }
         
            this.listAmb.Refresh();

        }

        private void AmbulantaUI_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void btnAzurirajAmb_Click(object sender, EventArgs e)
        {
            if (listAmb.SelectedItems.Count != 1)
            {
                MessageBox.Show("Izaberite tačno 1 pacijenta ambulante!");
                return;
            }

            int idAmbulanta = int.Parse(listAmb.SelectedItems[0].SubItems[0].Text);
           
            PacijentDTO zaIzmenuMO = DTOManager.vratiAmb(idAmbulanta);
            AzurirajAmb fs = new AzurirajAmb(zaIzmenuMO);

            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            fs.ShowDialog();
            this.Close();
           
        }     
    }
}
