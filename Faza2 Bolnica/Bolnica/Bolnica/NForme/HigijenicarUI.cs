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
    public partial class HigijenicarUI : Form
    {
        public HigijenicarUI()
        {
            InitializeComponent();
        }

        private void cmdDodajHigijenicara_Click(object sender, EventArgs e)
        {
            DodajHigijenicara fs = new DodajHigijenicara();
    
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            fs.ShowDialog();
            this.Close();
        }
        
    
        private void popuniPodacima()
        {
           
                this.listHigijenicari.Items.Clear();
                List<NemedicinskoOsobljeDTO> zaposleni = DTOManager.vratiHigijenicare();
                foreach (NemedicinskoOsobljeDTO x in zaposleni)
                {
                    listHigijenicari.Items.Add(new ListViewItem(new string[] { x.IDOsobe.ToString(), x.Ime, x.Prezime, x.MaticniBroj}
                    ));
                }
              
                this.listHigijenicari.Refresh();
   
        }

        private void cmdObrisiHigijenicara_Click(object sender, EventArgs e)
        {
           
            if (listHigijenicari.SelectedItems.Count != 1)
            {
                MessageBox.Show("Izaberite tačno 1 higijeničara!");
                return;
            }
            int idHigijenicara = int.Parse(listHigijenicari.SelectedItems[0].SubItems[0].Text);
            DTOManager.obrisiHigijenicara(idHigijenicara);
            popuniPodacima();
        }

       
      

        private void cmdBack_Click(object sender, EventArgs e)
        {
            NeMedOsoba nm = new NeMedOsoba();
            
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            nm.ShowDialog();
            this.Close();
        }

        private void HigijenicarUI_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void cmdMore_Click(object sender, EventArgs e)
        {
            if (listHigijenicari.SelectedItems.Count != 1)
            {
                MessageBox.Show("Izaberite tačno 1 higijeničara!");
                return;
            }
            int idH = int.Parse(listHigijenicari.SelectedItems[0].SubItems[0].Text);
            NemedicinskoOsobljeDTO zaIzmenuNMO = DTOManager.vratiHigijenicara(idH);
            MoreHigijenicar nm = new MoreHigijenicar(zaIzmenuNMO);
          
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            nm.ShowDialog();
            this.Close();
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            if (listHigijenicari.SelectedItems.Count != 1)
            {
                MessageBox.Show("Izaberite tačno 1 higijeničara!");
                return;
            }
            int idHigijenicar = int.Parse(listHigijenicari.SelectedItems[0].SubItems[0].Text);

            NemedicinskoOsobljeDTO zaIzmenuP = DTOManager.vratiHigijenicara(idHigijenicar);
            FormHigijenicarUpdate h = new FormHigijenicarUpdate(zaIzmenuP);
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            h.ShowDialog();
            this.Close();
        }
    }
}
