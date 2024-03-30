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
    public partial class StomatologUI : Form
    {
        public StomatologUI()
        {
            InitializeComponent();
        }

        private void btnDodajStomatologa_Click(object sender, EventArgs e)
        {
            FormaStomatolog fs = new FormaStomatolog();
          
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            fs.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MedOsoba med = new MedOsoba();
            
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            med.ShowDialog();
            this.Close();

        }
        private void popuniPodacima()
        {
            this.listStomatolozi.Items.Clear();
            List<MedicinskoOsobljeDTO> zaposleni = DTOManager.vratiStomatologe();
            foreach (MedicinskoOsobljeDTO x in zaposleni)
            {

                listStomatolozi.Items.Add(new ListViewItem(new string[] { x.IDOsobe.ToString(), x.Ime, x.Prezime, x.MaticniBroj,
                    x.GodineRadnogStaza.ToString(), x.Smena.ToString(), x.Stolica.ID.ToString()}
                ));
            }
           
            this.listStomatolozi.Refresh();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listStomatolozi.SelectedItems.Count == 1)
            {
                int idStomatolog = int.Parse(listStomatolozi.SelectedItems[0].SubItems[0].Text);
                DTOManager.obrisiStomatologa(idStomatolog);
            }
            else
            {
                MessageBox.Show("Izaberite tačno 1 stomatologa!");
                return;
            }
            popuniPodacima();
        }

      
         private void btnUpdate_Click(object sender, EventArgs e)
        {   
            if(listStomatolozi.SelectedItems.Count != 1)
            {
                MessageBox.Show("Izaberite tačno 1 stomatologa!");
                return;
            }
          
            int idStomatolog = int.Parse(listStomatolozi.SelectedItems[0].SubItems[0].Text);
            MedicinskoOsobljeDTO zaIzmenuMO = DTOManager.vratiStomatologa(idStomatolog);
            FormaStomatologUpdate fs = new FormaStomatologUpdate(zaIzmenuMO);
            
       
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            fs.ShowDialog();
            this.Close();
        }

        private void StomatologUI_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

      
    }
    
}
