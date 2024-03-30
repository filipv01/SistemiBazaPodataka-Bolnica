using Bolnica.DTO;
using Bolnica.Entiteti;
using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bolnica
{
    public partial class FormOPupdate : Form
    {
        public MedicinskoOsobljeDTO Med { get; set; }
        public FormOPupdate(MedicinskoOsobljeDTO m)
        {
            InitializeComponent();
            Med = m;
        }

        private void cmdNazad_Click(object sender, EventArgs e)
        {
            OpstaPraksaUI f2 = new OpstaPraksaUI();
         
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            f2.ShowDialog();
            this.Close();
        }

        private void cmdAzurirajS_Click(object sender, EventArgs e) 
        {
            try
            {
               
  
                Med.Ime = textBox1.Text;
                Med.Prezime = textBox2.Text;
                Med.MaticniBroj = textBox3.Text;
                Med.GodineRadnogStaza = int.Parse(textBox4.Text);
                Med.BrojOrdinacije = int.Parse(textBox5.Text);
                this.Hide();
                Cursor.Current = Cursors.WaitCursor;
                OpstaPraksaUI s = new OpstaPraksaUI();
                DTOManager.izmeniOP(Med);
                s.ShowDialog();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void FormOPupdate_Load(object sender, EventArgs e)
        {
            textBox1.Text = Med.Ime;
            textBox2.Text = Med.Prezime;
            textBox3.Text = Med.MaticniBroj;
            textBox4.Text = Med.GodineRadnogStaza.ToString();
            textBox5.Text = Med.BrojOrdinacije.ToString();
        }
    }
}
