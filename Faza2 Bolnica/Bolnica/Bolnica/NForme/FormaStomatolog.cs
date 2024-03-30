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
using NHibernate.Criterion;
using NHibernate.Linq;

namespace Bolnica.Entiteti
{
    public partial class FormaStomatolog : Form
    {
        private List<StomatoloskaStolicaDTO> Stolice { get; set; }
        public FormaStomatolog()
        {
            InitializeComponent();
        }

    

        private void cmdDodajS_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                MedicinskoOsoblje m = new MedicinskoOsoblje();

                m.Ime = textBox1.Text;
                m.Prezime = textBox2.Text;
                m.MaticniBroj = textBox3.Text;

                
                m.GodineRadnogStaza =int.Parse(textBox4.Text);
                m.TipMedOsoblja = "Stomatolog";
        
                
                if(checkBox1.Checked == true)
                {
                    m.Smena = 1;
                }
                else if(checkBox2.Checked == true)
                {
                    m.Smena = 2;
                }
                else
                {
                    MessageBox.Show("Odaberite tačno jednu smenu!");
                    s.Close();
                    cmdNazad_Click(sender, e);
                }
                
                int idIzComboa = (int)comboBox1.SelectedItem; 
                StomatoloskaStolicaDTO p = Stolice.Find(x => x.ID == idIzComboa);
                int id = p.ID;
                StomatoloskaStolica o = s.Load<Bolnica.Entiteti.StomatoloskaStolica>(id);
                m.Stolica = o;
                
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cmdNazad_Click(object sender, EventArgs e)
        {
            StomatologUI f2 = new StomatologUI();
         
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            f2.ShowDialog();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormaStomatolog_Load(object sender, EventArgs e)
        {
            Stolice = DTOManager.vratiSveStolice(); 
            foreach (StomatoloskaStolicaDTO x in Stolice)
            {
                comboBox1.Items.Add(x.ID);
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
