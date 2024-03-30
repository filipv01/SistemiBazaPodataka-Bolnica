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

namespace Bolnica.NForme
{
    public partial class AzurirajTehnicko : Form
    {

        public List<StomatoloskaStolicaDTO> stolice { get; set; }
        public NemedicinskoOsobljeDTO nemed { get; set; }
        public AzurirajTehnicko(NemedicinskoOsobljeDTO neme)
        {
            InitializeComponent();
            nemed = neme;
        }

        private void AzurirajTehnicko_Load(object sender, EventArgs e)
        {


            textBox1.Text = nemed.Ime;
            textBox2.Text = nemed.Prezime;
            textBox3.Text = nemed.MaticniBroj;
            textBox4.Text = nemed.Struka;


        }

        private void cmdAzuriraj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                nemed.Ime = textBox1.Text;
                nemed.Prezime = textBox2.Text;
                nemed.MaticniBroj = textBox3.Text;
                nemed.Struka = textBox4.Text;
               
                
                this.Hide();
                Cursor.Current = Cursors.WaitCursor;
                TehnickoOsobljeUI u = new TehnickoOsobljeUI();

                DTOManager.izmeniTehnicara(nemed);

                u.ShowDialog();
                this.Close();
               
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            TehnickoOsobljeUI h = new TehnickoOsobljeUI();

            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            h.ShowDialog();
            this.Close();
        }
    }
}
