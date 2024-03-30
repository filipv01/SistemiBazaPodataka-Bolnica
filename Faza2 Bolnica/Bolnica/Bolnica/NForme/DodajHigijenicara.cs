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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bolnica
{
    public partial class DodajHigijenicara : Form
    {
        public DodajHigijenicara()
        {
            InitializeComponent();
        }

        private void cmdDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NemedicinskoOsoblje m = new NemedicinskoOsoblje();


                m.Ime = textBoxIme.Text;
                m.Prezime = textBoxPrezime.Text;
                m.MaticniBroj = textBoxMaticniBroj.Text;

                m.Stolice = null;
                m.Struka = "";
                m.TipNemedOsoblja = "Higijenicar";

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

        private void cmdBack_Click(object sender, EventArgs e)
        {
            HigijenicarUI f2 = new HigijenicarUI();
           
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            f2.ShowDialog();
            this.Close();
        }

       
    }
}
