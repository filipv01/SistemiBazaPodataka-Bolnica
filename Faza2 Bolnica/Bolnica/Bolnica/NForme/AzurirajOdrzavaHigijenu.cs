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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bolnica.NForme
{
    public partial class AzurirajOdrzavaHigijenu : Form
    {
        private List<OdeljenjeDTO> od;
        private List<NemedicinskoOsobljeDTO> nemed;
        private OdrzavaHigijenuDTO oh { get; set; }
        public AzurirajOdrzavaHigijenu(OdrzavaHigijenuDTO o)
        {
            InitializeComponent();
            oh = o;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AzurirajOdrzavaHigijenu_Load(object sender, EventArgs e)
        {


            od = DTOManager.vratiOdeljenja();
            foreach (OdeljenjeDTO s in od)
            {
                comboBox1.Items.Add(s.Tip);

            }
            nemed = DTOManager.vratiHigijenicare();
            foreach (NemedicinskoOsobljeDTO s in nemed)
            {
                comboBox2.Items.Add(s.Ime + " " + s.Prezime);
            }

            comboBox1.SelectedItem = oh.Odeljenje.Tip;
            comboBox2.SelectedItem = oh.Higijenicar.Ime +" "+ oh.Higijenicar.Prezime;

        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                  
                string imeIPrezime = (string)comboBox2.SelectedItem;
                string[] odvoji = imeIPrezime.Split(' ');
                string ime = odvoji[0];
                string prezime = odvoji[1];
                NemedicinskoOsobljeDTO n = nemed.Find(x => x.Ime == ime && x.Prezime == prezime);
                string Tip = (string)comboBox1.SelectedItem;
                OdeljenjeDTO o = od.Find(x => x.Tip == Tip);
                oh.Odeljenje = o;
                oh.Higijenicar = n;
                int flag = 0;
                List<OdrzavaHigijenuDTO> zaduzenja = DTOManager.vratiZaduzenja();
                foreach (OdrzavaHigijenuDTO x in zaduzenja)
                {
                    if (oh.Higijenicar.IDOsobe == x.Higijenicar.IDOsobe && oh.Odeljenje.ID == x.Odeljenje.ID)
                    {
                        MessageBox.Show("Taj higijenicar je vec zaduzen za to odeljenje!! Uneti drugu kombinaciju");
                        flag = 1;

                    }

                }
                if (flag == 0)
                {
                    DTOManager.izmeniZaduzenje(oh);

                    this.Hide();
                    Cursor.Current = Cursors.WaitCursor;
                    OdrzavaHigijenuUI u = new OdrzavaHigijenuUI();
                    u.ShowDialog();
                   
                }
            
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            OdrzavaHigijenuUI aa = new OdrzavaHigijenuUI();
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            aa.ShowDialog();
            this.Close();
        }
    }
}
