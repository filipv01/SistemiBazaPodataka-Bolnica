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
using NHibernate;
using System.Data.SqlClient;
using Bolnica.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bolnica
{
    public partial class FormaDodajAmbulanta : Form
    {
        private List<MedicinskoOsobljeDTO> Stomatolozi { get; set; }
        private List<MedicinskoOsobljeDTO> OP { get; set; }
        public FormaDodajAmbulanta()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AmbulantaUI a = new AmbulantaUI();
           
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

                m.Adresa = textBox4.Text;
                m.TipPacijenta = "Ambulanta";

         

                string imeIPrezime2 = (string)comboBox2.SelectedItem;
                string[] odvoji2 = imeIPrezime2.Split(' ');
                string ime2 = odvoji2[0];
                string prezime2 = odvoji2[1];

                if(checkBox1.Checked)
                {
                    string imeIPrezime = (string)comboBox1.SelectedItem;
                    string[] odvoji = imeIPrezime.Split(' ');
                    string ime = odvoji[0];
                    string prezime = odvoji[1];

                    MedicinskoOsobljeDTO p = Stomatolozi.Find(x => x.Ime == ime && x.Prezime == prezime);
                    int id = p.IDOsobe;

                    MedicinskoOsoblje o = s.Load<Bolnica.Entiteti.MedicinskoOsoblje>(id);
                    m.Stomatolog = o;
                    m.VrstaIntervencije = textBox6.Text;
                    m.DatumIntervencije = dateTimePicker1.Value;
                }
                else
                {
                    m.DatumIntervencije = new DateTime(1753, 1, 1);
                    m.VrstaIntervencije = "";
                }
         

                MedicinskoOsobljeDTO a = OP.Find(x => x.Ime == ime2 && x.Prezime == prezime2);
                int id2 = a.IDOsobe;
                MedicinskoOsoblje o2 = s.Load<Bolnica.Entiteti.MedicinskoOsoblje>(id2);
                m.LekarOpstePrakse = o2;

                

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

   

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                groupBox1.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormaDodajAmbulanta_Load(object sender, EventArgs e)
        {
           
                Stomatolozi = DTOManager.vratiSveStomatologe(); 
                foreach (MedicinskoOsobljeDTO x in Stomatolozi)
                {
                    comboBox1.Items.Add(x.Ime + " " + x.Prezime);
                }
            OP = DTOManager.vratiOP(); 
            foreach (MedicinskoOsobljeDTO x in OP)
            {
                comboBox2.Items.Add(x.Ime + " " + x.Prezime);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
