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
using NHibernate.Criterion;
using NHibernate.Linq;

namespace Bolnica
{
    public partial class DodajTehnicara : Form
    {
        public DodajTehnicara()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            TehnickoOsobljeUI f2 = new TehnickoOsobljeUI();
           
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            f2.ShowDialog();
            this.Close();
        }

        private void cmdDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                NemedicinskoOsoblje m = new NemedicinskoOsoblje();

                m.Ime = textBoxIme.Text;
                m.Prezime = textBoxPrezime.Text;
                m.MaticniBroj = textBoxMB.Text;

              
                m.Struka = textBoxStruka.Text;
                m.TipNemedOsoblja = "Tehnicko odrzavanje";

                s.Save(m);

                s.Flush();
                s.Close();
                cmdBack_Click(sender, e);
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
