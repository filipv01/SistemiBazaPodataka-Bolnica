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
using Bolnica.NForme;

namespace Bolnica
{
    public partial class StomatoloskaStolicaUI : Form
    {
        public StomatoloskaStolicaUI()
        {
            InitializeComponent();
        }

        private void btnStomStolica_Click(object sender, EventArgs e)
        {
            DodajStolicu ds = new DodajStolicu();
           
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            ds.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (listStolica.SelectedItems.Count != 1)
            {
                MessageBox.Show("Izaberite tačno 1 stolicu!");
                return;
            }
            int idStolice = int.Parse(listStolica.SelectedItems[0].SubItems[0].Text);
            DTOManager.obrisiStolice(idStolice);
            popuniPodacima();

        }
        private void popuniPodacima(){

            this.listStolica.Items.Clear();
            List<StomatoloskaStolicaDTO> s = DTOManager.vratiStolice();
            foreach (StomatoloskaStolicaDTO x in s)
            {
                listStolica.Items.Add(new ListViewItem(new string[] { x.ID.ToString(), x.Proizvodjac, x.DatumProizvodnje.ToString(), x.TehnickoOdrzavanje?.Ime + " " + x.TehnickoOdrzavanje?.Prezime}
                ));
            }
          
            this.listStolica.Refresh();

        }

    

        private void StomatoloskaStolicaUI_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

    

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Form1 f1=new Form1();
           
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            f1.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (listStolica.SelectedItems.Count != 1)
            {
                MessageBox.Show("Izaberite tačno 1 stolicu!");
                return;
            }
            int idStolica = int.Parse(listStolica.SelectedItems[0].SubItems[0].Text);
            StomatoloskaStolicaDTO zaIzmenuMO = DTOManager.vratiStolicu(idStolica);
            AzurirajStolicu fs = new AzurirajStolicu(zaIzmenuMO);
         
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            fs.ShowDialog();
            this.Close();
          
        }
    }
}
