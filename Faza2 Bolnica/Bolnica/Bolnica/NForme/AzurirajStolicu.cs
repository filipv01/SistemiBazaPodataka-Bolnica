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
using NHibernate;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bolnica.NForme
{
    public partial class AzurirajStolicu : Form
    {

        public StomatoloskaStolicaDTO stom { get; set; }
        public List<NemedicinskoOsobljeDTO> tehn;
        public AzurirajStolicu(StomatoloskaStolicaDTO s)
        {
            InitializeComponent();
            stom = s;
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            StomatoloskaStolicaUI aa = new StomatoloskaStolicaUI();
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            aa.ShowDialog();
            this.Close();
        }

        private void AzurirajStolicu_Load(object sender, EventArgs e)
        {
            tehn = DTOManager.vratiTehnicare();
            foreach (NemedicinskoOsobljeDTO s in tehn)
            {
                comboBox1.Items.Add(s.Ime +" "+ s.Prezime);
            }

            textBox1.Text = stom.Proizvodjac;
            dateTimePicker1.Value = stom.DatumProizvodnje;
            comboBox1.SelectedItem = stom.TehnickoOdrzavanje?.Ime+" "+stom.TehnickoOdrzavanje?.Prezime;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                stom.Proizvodjac = textBox1.Text;
                stom.DatumProizvodnje = dateTimePicker1.Value;
                string imeIPrezime = (string)comboBox1.SelectedItem;
                string[] odvoji = imeIPrezime.Split(' ');
                string ime = odvoji[0];
                string prezime = odvoji[1];
                NemedicinskoOsobljeDTO n = tehn.Find(x => x.Ime == ime && x.Prezime == prezime);
             
                stom.TehnickoOdrzavanje = n;
                this.Hide();
                Cursor.Current = Cursors.WaitCursor;
                StomatoloskaStolicaUI u = new StomatoloskaStolicaUI();



                DTOManager.izmeniStolicu(stom);



                u.ShowDialog();
                this.Close();
               
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    
    }
}
