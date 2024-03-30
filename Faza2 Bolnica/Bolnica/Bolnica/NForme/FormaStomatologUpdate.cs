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
    public partial class FormaStomatologUpdate : Form
    {
        public MedicinskoOsobljeDTO Med { get; set; }
        public List<StomatoloskaStolicaDTO> Stomatos;
        public FormaStomatologUpdate(MedicinskoOsobljeDTO m)
        {
            InitializeComponent();
            Med = m;
        }

        
        private void cmdNazad_Click(object sender, EventArgs e)
        {
            StomatologUI f2 = new StomatologUI();
   
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            f2.ShowDialog();
            this.Close();
        }
        private void FormaStomatologUpdate_Load(object sender, EventArgs e)
        {
            //ovo je da se forma unapred popuni :)
            Stomatos = DTOManager.vratiStolice();
            foreach(StomatoloskaStolicaDTO s in Stomatos)
            {
                comboBox1.Items.Add(s.ID);
            }
            textBox1.Text = Med.Ime;
            textBox2.Text = Med.Prezime;
            textBox3.Text = Med.MaticniBroj;
            textBox4.Text = Med.GodineRadnogStaza.ToString();
            if (Med.Smena == 1) checkBox1.Checked = true;
            else checkBox2.Checked = true;
            comboBox1.SelectedItem = Med.Stolica.ID;   
        }
        private void cmdAzurirajS_Click(object sender, EventArgs e)
        {
            try
            {
                
             
                Med.Ime = textBox1.Text;
                Med.Prezime = textBox2.Text;
                Med.MaticniBroj = textBox3.Text;
                Med.GodineRadnogStaza = int.Parse(textBox4.Text);
                if (checkBox1.Checked) Med.Smena = 1;
                else Med.Smena = 2;
                int idIzComboa = (int)comboBox1.SelectedItem;
                StomatoloskaStolicaDTO p = Stomatos.Find(x => x.ID == idIzComboa);
                int id = p.ID;
               
                Med.Stolica = p;


               
                this.Hide();
                Cursor.Current = Cursors.WaitCursor;
                StomatologUI u = new StomatologUI();
               
                    
                DTOManager.izmeniStomatologa(Med);
                     
                u.ShowDialog();
                this.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

   

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }
        }
    }
}
