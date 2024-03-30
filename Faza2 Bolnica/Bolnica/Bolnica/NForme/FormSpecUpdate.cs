using Bolnica.DTO;
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
    public partial class FormSpecUpdate : Form
    {
        MedicinskoOsobljeDTO Med;
        public FormSpecUpdate(MedicinskoOsobljeDTO m)
        {
            InitializeComponent();
            Med = m;
        }

        private void cmdNazad_Click(object sender, EventArgs e)
        {
            SpecijalistaUI s= new SpecijalistaUI();
            
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            s.ShowDialog();
            this.Close();
        }

        private void FormSpecUpdate_Load(object sender, EventArgs e)
        {
            textBox1.Text = Med.Ime;
            textBox2.Text = Med.Prezime;
            textBox3.Text = Med.MaticniBroj;
            textBox4.Text = Med.GodineRadnogStaza.ToString();
            textBox5.Text = Med.Specijalnost;
        }

        private void cmdAzurirajS_Click(object sender, EventArgs e)
        {
            try
            {
                Med.Ime = textBox1.Text;
                Med.Prezime = textBox2.Text;
                Med.MaticniBroj = textBox3.Text;
                Med.GodineRadnogStaza = int.Parse(textBox4.Text);
                Med.Specijalnost = textBox5.Text;

                this.Hide();
                Cursor.Current = Cursors.WaitCursor;
                SpecijalistaUI s = new SpecijalistaUI();
                DTOManager.izmeniSpec(Med);
                s.ShowDialog();
                this.Close();


                s.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
