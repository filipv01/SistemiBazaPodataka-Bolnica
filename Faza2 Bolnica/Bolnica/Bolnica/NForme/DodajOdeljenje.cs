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
    public partial class DodajOdeljenje : Form
    {
        private List<MedicinskoOsobljeDTO> Specijalisti { get; set; }
        public DodajOdeljenje()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OdeljenjeUI o = new OdeljenjeUI();
            
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            o.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Odeljenje m = new Odeljenje();

                m.Sifra = int.Parse(textBox1.Text);
                m.Tip = textBox2.Text;
                m.DatumIzgradnje = dateTimePicker1.Value;

                string imeIPrezime = (string)comboBox1.SelectedItem;
                string[] odvoji = imeIPrezime.Split(' ');
                string ime = odvoji[0];
                string prezime = odvoji[1];

                MedicinskoOsobljeDTO p = Specijalisti.Find(x => x.Ime == ime && x.Prezime == prezime);
                int id = p.IDOsobe;
                MedicinskoOsoblje o = s.Load<Bolnica.Entiteti.MedicinskoOsoblje>(id);
                m.Specijalista = o;
                
                s.Save(m);

                s.Flush();
                s.Close();
                btnBack_Click(sender, e);
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DodajOdeljenje_Load(object sender, EventArgs e)
        {
            Specijalisti = DTOManager.vratiSveSpecijaliste(); 
            foreach (MedicinskoOsobljeDTO x in Specijalisti)
            {
                comboBox1.Items.Add(x.Ime + " " + x.Prezime);
            }
        }
    }
}
