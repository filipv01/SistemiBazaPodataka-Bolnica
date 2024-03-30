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
using NHibernate;
using Bolnica.NForme;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Bolnica.NForme
{

   
    public partial class AzurirajStac : Form
    {

        public PacijentDTO pac { get; set; }

        public List<MedicinskoOsobljeDTO> op { get; set; }
        public List<OdeljenjeDTO> odeljenja { get; set; }
        public AzurirajStac(PacijentDTO pac)
        {
            InitializeComponent();
            this.pac = pac;
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {

            StacionarUI aa = new StacionarUI();
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            aa.ShowDialog();
            this.Close();
        }

        private void AzurirajStac_Load(object sender, EventArgs e)
        {
            op = DTOManager.vratiOP();
            foreach (MedicinskoOsobljeDTO s in op)
            {
                comboBox1.Items.Add(s.Ime + " " + s.Prezime);
            }
            odeljenja =DTOManager.vratiOdeljenja();
            
            foreach (OdeljenjeDTO s in odeljenja)
            {
                comboBox2.Items.Add(s.Tip);
            }

            textBox1.Text = pac.Ime;
            textBox2.Text = pac.Prezime;
            textBox4.Text = pac.MaticniBroj;
            dateTimePicker1.Value = (DateTime)pac.DatumPrijema;
            dateTimePicker2.Value = (DateTime)pac.DatumOtpusta;
            comboBox2.SelectedItem = pac.Odeljenje.Tip;
            comboBox1.SelectedItem = pac.LekarOpstePrakse.Ime+" "+pac.LekarOpstePrakse.Prezime;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                pac.Ime = textBox1.Text;
                pac.Prezime = textBox2.Text;
                pac.MaticniBroj = textBox4.Text;
                
                pac.TipPacijenta = "Stacionar";

                pac.DatumPrijema = dateTimePicker1.Value;
                pac.DatumOtpusta = dateTimePicker2.Value;

                OdeljenjeDTO od = odeljenja.Find(x => x.Tip == (string)comboBox2.SelectedItem);
                pac.Odeljenje = od;
                string imeIPrezime = (string)comboBox1.SelectedItem;
                string[] odvoji = imeIPrezime.Split(' ');
                string ime = odvoji[0];
                string prezime = odvoji[1];

                MedicinskoOsobljeDTO p = op.Find(x => x.Ime == ime && x.Prezime == prezime);
                pac.LekarOpstePrakse = p;

                this.Hide();
                Cursor.Current = Cursors.WaitCursor;
                StacionarUI u = new StacionarUI();

                DTOManager.izmeniStacionara(pac);

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
