using Bolnica.DTO;
using Bolnica.Entiteti;
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
    public partial class OpstaPraksaUI : Form
    {
        public OpstaPraksaUI()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MedOsoba med = new MedOsoba();
         
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            med.ShowDialog();
            this.Close();
        }

        private void cmdDodajOP_Click(object sender, EventArgs e)
        {
            FormOPdodaj OP=new FormOPdodaj();
           
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            OP.ShowDialog();
            this.Close();
        }

        private void cmdUpdateOP_Click(object sender, EventArgs e)
        {
            if (listOP.SelectedItems.Count != 1)
            {
                MessageBox.Show("Izaberite tačno 1 lekara opšte prakse!");
                return;
            }
            int idOP = int.Parse(listOP.SelectedItems[0].SubItems[0].Text);
            MedicinskoOsobljeDTO zaIzmenuMO = DTOManager.vratilekaraOP(idOP);
            FormOPupdate formOPupdate = new FormOPupdate(zaIzmenuMO);

            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            formOPupdate.ShowDialog();
            this.Close();
        }
        private void popuniPodacima()
        {
            this.listOP.Items.Clear();
            List<MedicinskoOsobljeDTO> zaposleni = DTOManager.vratiOP();
            foreach (MedicinskoOsobljeDTO x in zaposleni)
            {

                listOP.Items.Add(new ListViewItem(new string[] { x.IDOsobe.ToString(), x.Ime, x.Prezime, x.MaticniBroj,
                    x.GodineRadnogStaza.ToString(), x.BrojOrdinacije.ToString()}
                ));
            }
          
            this.listOP.Refresh();

        }
        private void OpstaPraksaUI_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void cmdDeleteOP_Click(object sender, EventArgs e)
        {
            if (listOP.SelectedItems.Count == 1)
            {
                int idStomatolog = int.Parse(listOP.SelectedItems[0].SubItems[0].Text);
                DTOManager.obrisiOP(idStomatolog);
            }
            else
            {
                MessageBox.Show("Izaberite tačno 1 lekara opšte prakse!");
                return;
            }
            popuniPodacima();
        }

    }
}
