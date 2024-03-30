using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bolnica.DTO;
using Bolnica.Entiteti;
using Bolnica.NForme;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;

namespace Bolnica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     
                   

      
        private void cmdNemed_Click(object sender, EventArgs e)
        {
            NeMedOsoba nm = new NeMedOsoba();
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
      
           nm.ShowDialog();
            this.Close();
        }

        private void cmdMedicinskoOsoblje_Click(object sender, EventArgs e)
        {
            MedOsoba nm = new MedOsoba();
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
       
            nm.ShowDialog();
            this.Close();
        }

        private void cmdPacijent_Click(object sender, EventArgs e)
        {
            Pacijenti p = new Pacijenti();
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();
            this.Close();
        }

        private void cmdStomatoloskaStolica_Click(object sender, EventArgs e)
        {
            StomatoloskaStolicaUI su=new StomatoloskaStolicaUI();
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
   
            su.ShowDialog();
            this.Close();
        }

        private void cmdOdeljenje_Click(object sender, EventArgs e)
        {
            OdeljenjeUI odeljenje = new OdeljenjeUI();
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
      
            odeljenje.ShowDialog();
            this.Close();
        }

        private void cmdOdustani_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Da li zelite da ugasite aplikaciju?", "Izlaz?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            { 
                Application.Exit();
            }
            else
            {
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Odaberite jednu od opcija.", "", MessageBoxButtons.OK);
        }

        private void cmdOdrzavaHigijenu_Click(object sender, EventArgs e)
        {
            OdrzavaHigijenuUI o = new OdrzavaHigijenuUI();
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
       
            o.ShowDialog();
            this.Close();
        }
    }
}
