using Bolnica.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;

namespace Bolnica
{
    public partial class FormOPdodaj : Form
    {
        public FormOPdodaj()
        {
            InitializeComponent();
        }

        private void cmdNazad_Click(object sender, EventArgs e)
        {
            OpstaPraksaUI f2 = new OpstaPraksaUI();
           
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            f2.ShowDialog();
            this.Close();
        }

        private void cmdDodajop_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                MedicinskoOsoblje m = new MedicinskoOsoblje();

                m.Ime = textBox1.Text;
                m.Prezime = textBox2.Text;
                m.MaticniBroj = textBox3.Text;
                m.GodineRadnogStaza = int.Parse(textBox4.Text);
                m.TipMedOsoblja = "Opsta praksa";
                m.BrojOrdinacije = int.Parse(textBox5.Text);
                           

                s.Save(m);

                s.Flush();
                s.Close();
                cmdNazad_Click(sender, e);
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
