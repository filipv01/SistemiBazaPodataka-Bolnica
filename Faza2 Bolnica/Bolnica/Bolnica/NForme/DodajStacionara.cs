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
    public partial class DodajStacionara : Form
    {
        private List<MedicinskoOsobljeDTO> LekariOpstePrakse { get; set; }
        private List<OdeljenjeDTO> Odeljenja { get; set; }
        public DodajStacionara()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            StacionarUI a = new StacionarUI();
          
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            a.ShowDialog();
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Pacijent m = new Pacijent();

                m.Ime = textBox1.Text;
                m.Prezime = textBox2.Text;
                m.MaticniBroj = textBox3.Text;


                m.DatumPrijema = dateTimePicker1.Value;
                m.DatumOtpusta = dateTimePicker2.Value;
                
                m.TipPacijenta = "Stacionar";

                string tipOdeljenja = (string)comboBox1.SelectedItem;
                OdeljenjeDTO oo = Odeljenja.Find(x => x.Tip == tipOdeljenja);
                Odeljenje od = s.Load<Bolnica.Entiteti.Odeljenje>(oo.ID);         
                m.Odeljenje = od;
                

                string imeIPrezime = (string)comboBox2.SelectedItem;
                string[] odvoji = imeIPrezime.Split(' ');
                string ime = odvoji[0];
                string prezime = odvoji[1];

                MedicinskoOsobljeDTO p = LekariOpstePrakse.Find(x => x.Ime == ime && x.Prezime == prezime);
                int id = p.IDOsobe;
                MedicinskoOsoblje o = s.Load<Bolnica.Entiteti.MedicinskoOsoblje>(id);
                m.LekarOpstePrakse = o;

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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DodajStacionara_Load(object sender, EventArgs e)
        {
            LekariOpstePrakse = DTOManager.vratiSveLekareOpstePrakse(); 
            foreach (MedicinskoOsobljeDTO x in LekariOpstePrakse)
            {
                comboBox2.Items.Add(x.Ime + " " + x.Prezime);
            }
            Odeljenja = DTOManager.vratiSvaOdeljenja(); 
            foreach (OdeljenjeDTO x in Odeljenja)
            {
                comboBox1.Items.Add(x.Tip);
            }

        }

     
    }
}
