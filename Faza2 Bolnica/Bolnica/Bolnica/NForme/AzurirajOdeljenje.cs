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
    public partial class AzurirajOdeljenje : Form
    {

        public List<MedicinskoOsobljeDTO> spec;
        public OdeljenjeDTO od { get; set; }
        public AzurirajOdeljenje(OdeljenjeDTO ode)
        {
            InitializeComponent();
            od = ode;
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {

            OdeljenjeUI aa = new OdeljenjeUI();
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            aa.ShowDialog();
            this.Close();
        }

        private void AzurirajOdeljenje_Load(object sender, EventArgs e)
        {
            spec = DTOManager.vratiSpecijaliste();
            foreach (MedicinskoOsobljeDTO s in spec)
            {
                comboBox1.Items.Add(s.Ime + " "+ s.Prezime);
            }
            textBox1.Text = od.Sifra.ToString() ;
            textBox2.Text = od.Tip;
            dateTimePicker1.Value = od.DatumIzgradnje;
            comboBox1.SelectedItem = od.Specijalista?.Ime+" "+od.Specijalista?.Prezime;

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

             
                od.Sifra = int.Parse(textBox1.Text);
                od.Tip = textBox2.Text;
                od.DatumIzgradnje = dateTimePicker1.Value;




                string imeIPrezime = (string)comboBox1.SelectedItem;
                string[] odvoji = imeIPrezime.Split(' ');
                string ime = odvoji[0];
                string prezime = odvoji[1];



                MedicinskoOsobljeDTO n = spec.Find(x => x.Ime == ime && x.Prezime == prezime);
                od.Specijalista = n;




                this.Hide();
                Cursor.Current = Cursors.WaitCursor;
                OdeljenjeUI u = new OdeljenjeUI();



                DTOManager.izmeniOdeljenje(od);



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
