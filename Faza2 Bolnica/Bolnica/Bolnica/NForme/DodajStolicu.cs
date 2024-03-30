using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bolnica.Entiteti;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using NHibernate;
using Bolnica.DTO;

namespace Bolnica
{
    public partial class DodajStolicu : Form
    {
        private List<NemedicinskoOsobljeDTO> Tehnicari { get; set; }
        public DodajStolicu()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            StomatoloskaStolicaUI s = new StomatoloskaStolicaUI();
         
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            s.ShowDialog();
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                StomatoloskaStolica ss = new StomatoloskaStolica();

                ss.Proizvodjac = textBox1.Text;
                ss.DatumProizvodnje = dateTimePicker1.Value;

                string imeIPrezime = (string)comboBox1.SelectedItem;
                string[] odvoji = imeIPrezime.Split(' ');
                string ime = odvoji[0];
                string prezime = odvoji[1];

                NemedicinskoOsobljeDTO p = Tehnicari.Find(x => x.Ime == ime && x.Prezime == prezime);
                int id = p.IDOsobe;
                NemedicinskoOsoblje o = s.Load<Bolnica.Entiteti.NemedicinskoOsoblje>(id);
                ss.TehnickoOdrzavanje = o;

                s.Save(ss);

                s.Flush();
                s.Close();
                btnBack_Click(sender, e);
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void DodajStolicu_Load(object sender, EventArgs e)
        {
            Tehnicari = DTOManager.vratiSveTehnicare(); 
            foreach (NemedicinskoOsobljeDTO x in Tehnicari)
            {
                comboBox1.Items.Add(x.Ime + " " + x.Prezime);
            }
        }

     
    }
    
}
