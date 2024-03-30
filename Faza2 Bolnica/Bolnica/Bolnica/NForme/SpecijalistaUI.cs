using Bolnica.DTO;
using Bolnica.Entiteti;
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
    public partial class SpecijalistaUI : Form
    {
        public SpecijalistaUI()
        {
            InitializeComponent();
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            MedOsoba m = new MedOsoba();
          
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            m.ShowDialog();
            this.Close();
        }

        private void cmdDodajSpec_Click(object sender, EventArgs e)
        {
            FormSpecdodaj s = new FormSpecdodaj();
           
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            s.ShowDialog();
            this.Close();
        }

        private void cmdUpdateSpec_Click(object sender, EventArgs e)
        {
            if (listSpecijalisti.SelectedItems.Count != 1)
            {
                MessageBox.Show("Izaberite tačno 1 specijalistu!");
                return;
            }
            int idSpec = int.Parse(listSpecijalisti.SelectedItems[0].SubItems[0].Text);
            MedicinskoOsobljeDTO zaIzmenuMO = DTOManager.vratiSpecijalistu(idSpec);
            FormSpecUpdate s = new FormSpecUpdate(zaIzmenuMO);

            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            s.ShowDialog();
            this.Close();
        }
        private void popuniPodacima()
        {
            this.listSpecijalisti.Items.Clear();
            List<MedicinskoOsobljeDTO> zaposleni = DTOManager.vratiSpecijaliste();
            foreach (MedicinskoOsobljeDTO x in zaposleni)
            {

                listSpecijalisti.Items.Add(new ListViewItem(new string[] { x.IDOsobe.ToString(), x.Ime, x.Prezime, x.MaticniBroj,
                    x.GodineRadnogStaza.ToString(), x.Specijalnost}
                ));
            }
          
            this.listSpecijalisti.Refresh();

        }
        private void SpecijalistaUI_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void cmdDeleteSpec_Click(object sender, EventArgs e)
        {
            if (listSpecijalisti.SelectedItems.Count == 1)
            {
                int idStomatolog = int.Parse(listSpecijalisti.SelectedItems[0].SubItems[0].Text);
                DTOManager.obrisiSpec(idStomatolog);
            }
            else
            {
                MessageBox.Show("Izaberite tačno 1 specijalistu!");
                return;
            }
            popuniPodacima();
        }

        private void cmdMore_Click(object sender, EventArgs e)
        {
            if (listSpecijalisti.SelectedItems.Count != 1)
            {
                MessageBox.Show("Izaberite tačno 1 specijalistu!");
                return;
            }

            int idT = int.Parse(listSpecijalisti.SelectedItems[0].SubItems[0].Text);
            MedicinskoOsobljeDTO zaIzmenuNO = DTOManager.vratiSpecijalistu(idT); 
            MoreSpecijalista nm = new MoreSpecijalista(zaIzmenuNO);
           
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            nm.ShowDialog();
            this.Close();
        }
    }
}
