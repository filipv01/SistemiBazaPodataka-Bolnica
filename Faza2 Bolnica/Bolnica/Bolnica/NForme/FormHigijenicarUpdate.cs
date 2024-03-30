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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bolnica.NForme
{
    public partial class FormHigijenicarUpdate : Form
    {
        NemedicinskoOsobljeDTO Nem { get; set; }
        public FormHigijenicarUpdate(NemedicinskoOsobljeDTO n)
        {
            InitializeComponent();
            Nem = n;
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            HigijenicarUI h = new HigijenicarUI();
           
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            h.ShowDialog();
            this.Close();
        }

        private void FormHigijenicarUpdate_Load(object sender, EventArgs e)
        {
            textBox1.Text = Nem.Ime;
            textBox2.Text = Nem.Prezime;
            textBox3.Text = Nem.MaticniBroj;
        }

        private void cmdAzuriraj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Nem.Ime = textBox1.Text;
                Nem.Prezime = textBox2.Text;
                Nem.MaticniBroj = textBox3.Text;


                this.Hide();
                Cursor.Current = Cursors.WaitCursor;
                HigijenicarUI u = new HigijenicarUI();

                DTOManager.izmeniHigijenicara(Nem);

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
