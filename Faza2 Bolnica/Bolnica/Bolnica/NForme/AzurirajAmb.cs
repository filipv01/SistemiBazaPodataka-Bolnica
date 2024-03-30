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
using System.ServiceModel.Description;

namespace Bolnica.NForme
{
    public partial class AzurirajAmb : Form
    {
        private List<MedicinskoOsobljeDTO> Stomatolozi { get; set; }

        public PacijentDTO pac { get; set; }
        public List<MedicinskoOsobljeDTO> op { get; set; }
        public AzurirajAmb(PacijentDTO p)
        {
            InitializeComponent();
            pac = p;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            AmbulantaUI aa = new AmbulantaUI();
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            aa.ShowDialog();
            this.Close();
        }

        private void AzurirajAmb_Load(object sender, EventArgs e)
        {
            ISession sss = DataLayer.GetSession();

            op = DTOManager.vratiOP();
            foreach (MedicinskoOsobljeDTO s in op)
            {
                comboBox1.Items.Add(s.Ime + " " + s.Prezime);
         
            }
            Stomatolozi = DTOManager.vratiSveStomatologe();
            foreach (MedicinskoOsobljeDTO x in Stomatolozi)
            {
                comboBox2.Items.Add(x.Ime + " " + x.Prezime);
            }

            textBox1.Text = pac.Ime;
            textBox2.Text = pac.Prezime;
            textBox4.Text = pac.MaticniBroj;
            textBox3.Text = pac.Adresa;
            
            comboBox1.SelectedItem = pac.LekarOpstePrakse?.Ime+" "+pac.LekarOpstePrakse?.Prezime;

            if(pac.Stomatolog != null)
            {
                checkBox1.Checked = true;
                comboBox2.SelectedItem = pac.Stomatolog.Ime + " " + pac.Stomatolog.Prezime;
                textBox5.Text = pac.VrstaIntervencije;
                dateTimePicker1.Value = (DateTime)pac.DatumIntervencije;
            }
            else 
            {
                checkBox1.Checked = false;
                comboBox2.Text= string.Empty;
                textBox5.Text= string.Empty;
                dateTimePicker1.Value= new DateTime(1753,1,1);
            }
          
              
               
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                groupBox1.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


             

                pac.Ime = textBox1.Text;
                pac.Prezime = textBox2.Text;
                pac.MaticniBroj = textBox4.Text;
                pac.Adresa = textBox3.Text;
                
                pac.TipPacijenta = "Ambulanta";
               
                string imeIPrezime = (string)comboBox1.SelectedItem;
                string[] odvoji = imeIPrezime.Split(' ');
                string ime = odvoji[0];
                string prezime = odvoji[1];

                MedicinskoOsobljeDTO p = op.Find(x => x.Ime == ime && x.Prezime == prezime);
            
                pac.LekarOpstePrakse = p;

                if (checkBox1.Checked)
                {
                    pac.DatumIntervencije = dateTimePicker1.Value;
                    pac.VrstaIntervencije = textBox5.Text;

                    string imeIPrezime2 = (string)comboBox2.SelectedItem;
                    string[] odvoji2 = imeIPrezime2.Split(' ');
                    string ime2 = odvoji2[0];
                    string prezime2 = odvoji2[1];

                    MedicinskoOsobljeDTO p2 = Stomatolozi.Find(x => x.Ime == ime2 && x.Prezime == prezime2);
                    int id2 = p2.IDOsobe;

                    pac.Stomatolog = p2;
                    
                }
                else
                {
                    pac.DatumIntervencije = new DateTime(1753, 1, 1);
                    pac.VrstaIntervencije = "";
                }
                this.Hide();
                Cursor.Current = Cursors.WaitCursor;
                AmbulantaUI u = new AmbulantaUI();

                DTOManager.izmeniAmb(pac,checkBox1.Checked);

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
