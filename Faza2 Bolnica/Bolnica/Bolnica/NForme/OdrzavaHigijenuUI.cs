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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bolnica.NForme
{
    public partial class OdrzavaHigijenuUI : Form
    {
        public OdrzavaHigijenuUI()
        {
            InitializeComponent();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            f1.ShowDialog();
            this.Close();

        }
        private void popuniPodacima()
        {
            this.listOdeljenja.Items.Clear();
            this.listZaduzenja.Items.Clear();
            this.listHigijenicari.Items.Clear();
            List<NemedicinskoOsobljeDTO> zaposleni = DTOManager.vratiHigijenicare();
            List<OdeljenjeDTO> odeljenja = DTOManager.vratiOdeljenja();
            List<OdrzavaHigijenuDTO> zaduzenja = DTOManager.vratiZaduzenja();
            foreach (NemedicinskoOsobljeDTO x in zaposleni)
            {

                listHigijenicari.Items.Add(new ListViewItem(new string[] { x.IDOsobe.ToString(), x.Ime, x.Prezime, x.MaticniBroj}
                ));
            }
          
            this.listHigijenicari.Refresh();
            foreach (OdeljenjeDTO x in odeljenja)
            {

                listOdeljenja.Items.Add(new ListViewItem(new string[] { x.ID.ToString(), x.Sifra.ToString(), x.Tip.ToString() }
                ));
            }

            this.listOdeljenja.Refresh();
            foreach (OdrzavaHigijenuDTO x in zaduzenja)
            {

                listZaduzenja.Items.Add(new ListViewItem(new string[] { x.ID.ToString(), x.Higijenicar?.Ime+" "+x.Higijenicar?.Prezime, x.Odeljenje?.Tip }
                ));
            }

            this.listZaduzenja.Refresh();

        }


        private void OdrzavaHigijenuUI_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if(listHigijenicari.SelectedItems.Count !=1) 
            {
                MessageBox.Show("Izaberite tačno 1 higijenirača!");
                return;
            }
            if (listOdeljenja.SelectedItems.Count != 1)
            {
                MessageBox.Show("Izaberite tačno 1 odeljenje!");
                return;
            }
            int idH = int.Parse(listHigijenicari.SelectedItems[0].SubItems[0].Text);
            int idO = int.Parse(listOdeljenja.SelectedItems[0].SubItems[0].Text);

            try
            {
                ISession s = DataLayer.GetSession();
                OdrzavaHigijenu odr = new OdrzavaHigijenu();
                NemedicinskoOsoblje hig = s.Load<Bolnica.Entiteti.NemedicinskoOsoblje>(idH);
                Odeljenje ode = s.Load<Bolnica.Entiteti.Odeljenje>(idO);
                odr.Higijenicar =hig ;
                odr.Odeljenje=ode ;
                List<OdrzavaHigijenuDTO> zaduzenja = DTOManager.vratiZaduzenja();
                int flag = 0;
                foreach(OdrzavaHigijenuDTO x in zaduzenja )
                {
                    if(odr.Higijenicar.IDOsobe==x.Higijenicar.IDOsobe && odr.Odeljenje.ID==x.Odeljenje.ID)
                    {
                        MessageBox.Show("Taj higijeničar je već zadužen za to odeljenje! Uneti drugu kombinaciju");
                        flag = 1;
                        
                    }                                
                    
                }
                if (flag == 0)
                {
                    s.Save(odr);
                    s.Flush();
                    popuniPodacima();
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
         
            if (listZaduzenja.SelectedItems.Count != 1)

            {
             MessageBox.Show("Izaberite tačno 1 zaduženje!");

            return;

            }

            int idZaduzenja = int.Parse(listZaduzenja.SelectedItems[0].SubItems[0].Text);
            DTOManager.obrisiZaduzenja(idZaduzenja);
            popuniPodacima();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (listZaduzenja.SelectedItems.Count != 1)
            {
                MessageBox.Show("Izaberite tačno 1 zaduženje!");
                return;
            }

            int idZad = int.Parse(listZaduzenja.SelectedItems[0].SubItems[0].Text);
            OdrzavaHigijenuDTO o = DTOManager.vratiZaduzenje(idZad);
            AzurirajOdrzavaHigijenu a = new AzurirajOdrzavaHigijenu(o);
            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            a.ShowDialog();
            this.Close();
        }
    }
}
