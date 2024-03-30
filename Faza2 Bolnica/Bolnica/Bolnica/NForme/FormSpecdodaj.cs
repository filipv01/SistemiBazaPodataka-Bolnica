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
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bolnica
{
    public partial class FormSpecdodaj : Form
    {
        public FormSpecdodaj()
        {
            InitializeComponent();
        }

        private void cmdNazad_Click(object sender, EventArgs e)
        {
            SpecijalistaUI s = new SpecijalistaUI();
            
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            s.ShowDialog();
            this.Close();
        }

        private void cmDodajS_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                MedicinskoOsoblje m = new MedicinskoOsoblje();

                m.Ime = textBox1.Text;
                m.Prezime = textBox2.Text;
                m.MaticniBroj = textBox3.Text;
                m.GodineRadnogStaza = int.Parse(textBox4.Text);
                m.TipMedOsoblja = "Specijalista";
                m.Specijalnost = textBox5.Text;
               
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
