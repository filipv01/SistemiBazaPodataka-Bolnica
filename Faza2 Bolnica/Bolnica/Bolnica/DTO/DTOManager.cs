using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bolnica.DTO;
using Bolnica.Entiteti;
using System.Windows.Forms;
using NHibernate;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Diagnostics;
using FluentNHibernate.Conventions.AcceptanceCriteria;

namespace Bolnica.DTO
{
    public class DTOManager
    {
        public static List<PacijentDTO> vratiSvePacijente()
        {
            List<PacijentDTO> zaVracanje = new List<PacijentDTO>();

            try
            {
                ISession sesija = DataLayer.GetSession();

                IEnumerable<Pacijent> pacijenti = from p in sesija.Query<Pacijent>() select p;
                foreach (Pacijent x in pacijenti)
                {
                    PacijentDTO zaDodati = new PacijentDTO(x);

                    
                    zaDodati.LekarOpstePrakse = new MedicinskoOsobljeDTO(x.LekarOpstePrakse);
                    zaVracanje.Add(zaDodati);
                }

                sesija.Close();
                return zaVracanje;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return zaVracanje;
        }

        public static void obrisiStomatologa(int idStomatologa)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                MedicinskoOsoblje zaBrisanje = sesija.Load<MedicinskoOsoblje>(idStomatologa);

                sesija.Delete(zaBrisanje);
                sesija.Flush();
                sesija.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void obrisiOP(int idOP)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                MedicinskoOsoblje zaBrisanje = sesija.Load<MedicinskoOsoblje>(idOP);

                sesija.Delete(zaBrisanje);
                sesija.Flush();
                sesija.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void obrisiSpec(int idspec)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                MedicinskoOsoblje zaBrisanje = sesija.Load<MedicinskoOsoblje>(idspec);

                sesija.Delete(zaBrisanje);
                sesija.Flush();
                sesija.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void obrisiHigijenicara(int idHigijenicar)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                NemedicinskoOsoblje zaBrisanje = sesija.Load<NemedicinskoOsoblje>(idHigijenicar);

                sesija.Delete(zaBrisanje);
                sesija.Flush();
                sesija.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static List<NemedicinskoOsobljeDTO> vratiHigijenicare()
        {
            List<NemedicinskoOsobljeDTO> zaVracanje = new List<NemedicinskoOsobljeDTO>();
            try
            {
                ISession sesija = DataLayer.GetSession();

                IEnumerable<NemedicinskoOsoblje> zaposleni = from z in sesija.Query<NemedicinskoOsoblje>() where z.TipNemedOsoblja == "Higijenicar" select z;
                
                foreach (NemedicinskoOsoblje x in zaposleni)
                {
                    NemedicinskoOsobljeDTO zaDodati = new NemedicinskoOsobljeDTO(x);
                    zaVracanje.Add(zaDodati);
                }

                sesija.Close();
                return zaVracanje;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return zaVracanje;
        }

        public static NemedicinskoOsobljeDTO vratiHigijenicara(int idHigijenicar)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                NemedicinskoOsoblje higijenicar = sesija.Load<NemedicinskoOsoblje>(idHigijenicar);
                NemedicinskoOsobljeDTO zaVratiti = new NemedicinskoOsobljeDTO(higijenicar);

                sesija.Close();
                return zaVratiti;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public static bool izmeniHigijenicara(NemedicinskoOsobljeDTO izmenjen)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                NemedicinskoOsoblje higijenicar = sesija.Load<NemedicinskoOsoblje>(izmenjen.IDOsobe);
                higijenicar.Ime = izmenjen.Ime;
                higijenicar.Prezime = izmenjen.Prezime;
                higijenicar.MaticniBroj = izmenjen.MaticniBroj;

                sesija.SaveOrUpdate(higijenicar);
                sesija.Flush();
                sesija.Close();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public static List<MedicinskoOsobljeDTO> vratiStomatologe()
        {
            List<MedicinskoOsobljeDTO> zaVracanje = new List<MedicinskoOsobljeDTO>();
            try
            {
                ISession sesija = DataLayer.GetSession();

                IEnumerable<MedicinskoOsoblje> zaposleni = from z in sesija.Query<MedicinskoOsoblje>() where z.TipMedOsoblja == "Stomatolog" select z;
               
                foreach (MedicinskoOsoblje x in zaposleni)
                {
                    var tmp = x.Stolica;
                    Debug.WriteLine(tmp);
                    MedicinskoOsobljeDTO zaDodati = new MedicinskoOsobljeDTO(x);
                    zaDodati.Stolica = new StomatoloskaStolicaDTO(x.Stolica);
                    zaVracanje.Add(zaDodati);
                }

                sesija.Close();
                return zaVracanje;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return zaVracanje;
        }

        public static List<MedicinskoOsobljeDTO> vratiSpecijaliste()
        {
            List<MedicinskoOsobljeDTO> zaVracanje = new List<MedicinskoOsobljeDTO>();
            try
            {
                ISession sesija = DataLayer.GetSession();

                IEnumerable<MedicinskoOsoblje> zaposleni = from z in sesija.Query<MedicinskoOsoblje>() where z.TipMedOsoblja == "Specijalista" select z;
                foreach (MedicinskoOsoblje x in zaposleni)
                {
                    MedicinskoOsobljeDTO zaDodati = new MedicinskoOsobljeDTO(x);
                   
                    zaVracanje.Add(zaDodati);
                }

                sesija.Close();
                return zaVracanje;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return zaVracanje;
        }

        public static List<MedicinskoOsobljeDTO> vratiOP()
        {
            List<MedicinskoOsobljeDTO> zaVracanje = new List<MedicinskoOsobljeDTO>();
            try
            {
                ISession sesija = DataLayer.GetSession();

                IEnumerable<MedicinskoOsoblje> zaposleni = from z in sesija.Query<MedicinskoOsoblje>() where z.TipMedOsoblja == "Opsta praksa" select z;
               
                foreach (MedicinskoOsoblje x in zaposleni)
                {
                    MedicinskoOsobljeDTO zaDodati = new MedicinskoOsobljeDTO(x);
                    zaVracanje.Add(zaDodati);
                }

                sesija.Close();
                return zaVracanje;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return zaVracanje;
        }

        public static List<NemedicinskoOsobljeDTO> vratiTehnicare()
        {
            List<NemedicinskoOsobljeDTO> zaVracanje = new List<NemedicinskoOsobljeDTO>();
            try
            {
                ISession sesija = DataLayer.GetSession();

                IEnumerable<NemedicinskoOsoblje> zaposleni = from z in sesija.Query<NemedicinskoOsoblje>() where z.TipNemedOsoblja == "Tehnicko odrzavanje" select z;
                foreach (NemedicinskoOsoblje x in zaposleni)
                {
                    NemedicinskoOsobljeDTO zaDodati = new NemedicinskoOsobljeDTO(x);
                    zaVracanje.Add(zaDodati);
                }

                sesija.Close();
                return zaVracanje;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return zaVracanje;
        }

        public static void obrisiTehnicara(int idTehnicar)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                NemedicinskoOsoblje zaBrisanje = sesija.Load<NemedicinskoOsoblje>(idTehnicar);

                sesija.Delete(zaBrisanje);
                sesija.Flush();
                sesija.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static List<PacijentDTO> vratiStacionare()
        {
            List<PacijentDTO> zaVracanje = new List<PacijentDTO>();
            try
            {
                ISession sesija = DataLayer.GetSession();

                IEnumerable<Pacijent> pacijenti = from s in sesija.Query<Pacijent>() where s.TipPacijenta == "Stacionar" select s;
                foreach (Pacijent x in pacijenti)
                {
                    var tmp = x.LekarOpstePrakse;
                    var tmp2 = x.Odeljenje;

                    PacijentDTO zaDodati = new PacijentDTO(x);
                    if(tmp!=null)
                        zaDodati.LekarOpstePrakse = new MedicinskoOsobljeDTO(tmp);
                    else zaDodati.LekarOpstePrakse=null;
                    zaDodati.Odeljenje = new OdeljenjeDTO(tmp2);
                    zaVracanje.Add(zaDodati);
                }

                sesija.Close();
                return zaVracanje;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return zaVracanje;
            

        }

        public static void obrisiStacionare(int idStacionara)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                Pacijent zaBrisanje = sesija.Load<Pacijent>(idStacionara);

                sesija.Delete(zaBrisanje);
                sesija.Flush();
                sesija.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static void obrisiStolice(int idStolice)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                StomatoloskaStolica zaBrisanje = sesija.Load<StomatoloskaStolica>(idStolice);

                sesija.Delete(zaBrisanje);
                sesija.Flush();
                sesija.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static List<StomatoloskaStolicaDTO> vratiStolice()
        {

            List<StomatoloskaStolicaDTO> zaVracanje = new List<StomatoloskaStolicaDTO>();
            try
            {
                ISession sesija = DataLayer.GetSession();

                IEnumerable<StomatoloskaStolica> s = from z in sesija.Query<StomatoloskaStolica>() select z;
                foreach (StomatoloskaStolica x in s)
                {
                    var tmp = x.TehnickoOdrzavanje;
                    StomatoloskaStolicaDTO zaDodati = new StomatoloskaStolicaDTO(x);
                    if (tmp != null)
                        zaDodati.TehnickoOdrzavanje = new NemedicinskoOsobljeDTO(x.TehnickoOdrzavanje);
                    else
                        zaDodati.TehnickoOdrzavanje = null;
                    zaVracanje.Add(zaDodati);
                }
                sesija.Close();
                return zaVracanje;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return zaVracanje;

        }

        public static List<OdeljenjeDTO> vratiOdeljenja()
        {
            List<OdeljenjeDTO> zaVracanje = new List<OdeljenjeDTO>();
            try
            {
                ISession sesija = DataLayer.GetSession();

                IEnumerable<Odeljenje> s = from z in sesija.Query<Odeljenje>() select z;
                foreach (Odeljenje x in s)
                {
                    var tmp = x.Specijalista;
                    OdeljenjeDTO zaDodati = new OdeljenjeDTO(x);
                    if (tmp != null)
                    {
                        zaDodati.Specijalista = new MedicinskoOsobljeDTO(x.Specijalista);
                    }
                    else zaDodati.Specijalista = null;
                    
                    zaVracanje.Add(zaDodati);
                }

                sesija.Close();
                return zaVracanje;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return zaVracanje;



        }

        public static List<PacijentDTO> vratiSveAmb()
        {
            List<PacijentDTO> zaVracanje = new List<PacijentDTO>();
            try
            {
                ISession sesija = DataLayer.GetSession();

                IEnumerable<Pacijent> s = from z in sesija.Query<Pacijent>() where z.TipPacijenta == "Ambulanta" select z;
                foreach (Pacijent x in s)
                {
                    var tmp = x.Stomatolog;
                    var tmp2 = x.LekarOpstePrakse;

                    PacijentDTO zaDodati = new PacijentDTO(x);
                    if (tmp != null)
                    {
                        zaDodati.Stomatolog = new MedicinskoOsobljeDTO(x.Stomatolog);

                    }
                    else
                    {
                        zaDodati.Stomatolog = null;
                    }
                    if (tmp2 != null)
                    {
                        zaDodati.LekarOpstePrakse = new MedicinskoOsobljeDTO(x.LekarOpstePrakse);
                    }
                    else
                    {
                        zaDodati.LekarOpstePrakse = null;
                    }

                    zaVracanje.Add(zaDodati);

                }
                sesija.Close();
                return zaVracanje;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return zaVracanje;
        }

        public static void obrisiOdeljenje(int idOdeljenja)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                Odeljenje zaBrisanje = sesija.Load<Odeljenje>(idOdeljenja);

                sesija.Delete(zaBrisanje);
                sesija.Flush();
                sesija.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static List<MedicinskoOsobljeDTO> vratiSveStomatologe()
        {
            List<MedicinskoOsobljeDTO> zaVracanje = new List<MedicinskoOsobljeDTO>();
            try
            {
                ISession sesija = DataLayer.GetSession();

                IEnumerable<MedicinskoOsoblje> stomatolozi = from s in sesija.Query<MedicinskoOsoblje>() where s.TipMedOsoblja == "Stomatolog" select s;
                foreach (MedicinskoOsoblje x in stomatolozi)
                {
                    MedicinskoOsobljeDTO zaDodati = new MedicinskoOsobljeDTO(x);

                    zaVracanje.Add(zaDodati);
                }

                sesija.Close();
                return zaVracanje;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return zaVracanje;
        }

        public static List<MedicinskoOsobljeDTO> vratiSveSpecijaliste()
        {
            List<MedicinskoOsobljeDTO> zaVracanje = new List<MedicinskoOsobljeDTO>();
            try
            {
                ISession sesija = DataLayer.GetSession();

                IEnumerable<MedicinskoOsoblje> specijalisti = from s in sesija.Query<MedicinskoOsoblje>() where s.TipMedOsoblja == "Specijalista" select s;
                foreach (MedicinskoOsoblje x in specijalisti)
                {
                    MedicinskoOsobljeDTO zaDodati = new MedicinskoOsobljeDTO(x);

                    zaVracanje.Add(zaDodati);
                }

                sesija.Close();
                return zaVracanje;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return zaVracanje;
        }

        public static List<MedicinskoOsobljeDTO> vratiSveLekareOpstePrakse()
        {
            List<MedicinskoOsobljeDTO> zaVracanje = new List<MedicinskoOsobljeDTO>();
            try
            {
                ISession sesija = DataLayer.GetSession();

                IEnumerable<MedicinskoOsoblje> lekari = from s in sesija.Query<MedicinskoOsoblje>() where s.TipMedOsoblja == "Opsta praksa" select s;
                foreach (MedicinskoOsoblje x in lekari)
                {
                    MedicinskoOsobljeDTO zaDodati = new MedicinskoOsobljeDTO(x);

                    zaVracanje.Add(zaDodati);
                }

                sesija.Close();
                return zaVracanje;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return zaVracanje;
        }
        public static List<OdeljenjeDTO> vratiSvaOdeljenja()
        {
            List<OdeljenjeDTO> zaVracanje = new List<OdeljenjeDTO>();
            try
            {
                ISession sesija = DataLayer.GetSession();

                IEnumerable<Odeljenje> odeljenja = from s in sesija.Query<Odeljenje>() select s;
                foreach (Odeljenje x in odeljenja)
                {
                    OdeljenjeDTO zaDodati = new OdeljenjeDTO(x);

                    zaVracanje.Add(zaDodati);
                }

                sesija.Close();
                return zaVracanje;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return zaVracanje;
        }
        public static List<NemedicinskoOsobljeDTO> vratiSveTehnicare()
        {
            List<NemedicinskoOsobljeDTO> zaVracanje = new List<NemedicinskoOsobljeDTO>();
            try
            {
                ISession sesija = DataLayer.GetSession();

                IEnumerable<NemedicinskoOsoblje> tehnicari = from s in sesija.Query<NemedicinskoOsoblje>() where s.TipNemedOsoblja == "Tehnicko odrzavanje" select s;
                foreach (NemedicinskoOsoblje x in tehnicari)
                {
                    NemedicinskoOsobljeDTO zaDodati = new NemedicinskoOsobljeDTO(x);

                    zaVracanje.Add(zaDodati);
                }

                sesija.Close();
                return zaVracanje;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return zaVracanje;
        }
        public static List<StomatoloskaStolicaDTO> vratiSveStolice()
        {
            List<StomatoloskaStolicaDTO> zaVracanje = new List<StomatoloskaStolicaDTO>();
            try
            {
                ISession sesija = DataLayer.GetSession();

                IEnumerable<StomatoloskaStolica> stolice = from s in sesija.Query<StomatoloskaStolica>() select s;
                foreach (StomatoloskaStolica x in stolice)
                {
                    StomatoloskaStolicaDTO zaDodati = new StomatoloskaStolicaDTO(x);

                    zaVracanje.Add(zaDodati);
                }

                sesija.Close();
                return zaVracanje;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return zaVracanje;
        }
        public static MedicinskoOsobljeDTO vratiStomatologa(int idS)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                

                MedicinskoOsoblje stomatolog = sesija.Load<MedicinskoOsoblje>(idS);

                var tmp = stomatolog.Stolica;

                MedicinskoOsobljeDTO zaVratiti = new MedicinskoOsobljeDTO(stomatolog);
                StomatoloskaStolicaDTO stolica = new StomatoloskaStolicaDTO(tmp);
                zaVratiti.Stolica = stolica;


                sesija.Close();
                return zaVratiti;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        public static bool izmeniStomatologa(MedicinskoOsobljeDTO izmenjen)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                MedicinskoOsoblje s = sesija.Load<MedicinskoOsoblje>(izmenjen.IDOsobe);

                s.Ime = izmenjen.Ime;
                s.Prezime = izmenjen.Prezime;
                s.MaticniBroj = izmenjen.MaticniBroj;
                s.GodineRadnogStaza = izmenjen.GodineRadnogStaza;
                s.Smena = izmenjen.Smena;
                s.Stolica = sesija.Load<StomatoloskaStolica>(izmenjen.Stolica.ID);

                sesija.SaveOrUpdate(s);
                sesija.Flush();
                sesija.Close();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public static bool izmeniOP(MedicinskoOsobljeDTO izmenjen)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                MedicinskoOsoblje s = sesija.Load<MedicinskoOsoblje>(izmenjen.IDOsobe);

                s.Ime = izmenjen.Ime;
                s.Prezime = izmenjen.Prezime;
                s.MaticniBroj = izmenjen.MaticniBroj;
                s.GodineRadnogStaza = izmenjen.GodineRadnogStaza;
                s.BrojOrdinacije = izmenjen.BrojOrdinacije;

                sesija.SaveOrUpdate(s);
                sesija.Flush();
                sesija.Close();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public static bool izmeniSpec(MedicinskoOsobljeDTO izmenjen)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();


                MedicinskoOsoblje s = sesija.Load<MedicinskoOsoblje>(izmenjen.IDOsobe);
                s.Ime = izmenjen.Ime;
                s.Prezime = izmenjen.Prezime;
                s.MaticniBroj = izmenjen.MaticniBroj;
                s.GodineRadnogStaza = izmenjen.GodineRadnogStaza;
                s.Specijalnost = izmenjen.Specijalnost;

                sesija.SaveOrUpdate(s);
                sesija.Flush();
                sesija.Close();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public static PacijentDTO vratiStacionara(int idS)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                Pacijent pacijent = sesija.Load<Pacijent>(idS);

                var tmp = pacijent.LekarOpstePrakse;
                var od = pacijent.Odeljenje;

                PacijentDTO zaVratiti = new PacijentDTO(pacijent);

                MedicinskoOsobljeDTO lop = new MedicinskoOsobljeDTO(tmp);
                OdeljenjeDTO ode = new OdeljenjeDTO(od);

                zaVratiti.LekarOpstePrakse = lop;
                zaVratiti.Odeljenje = ode;

                sesija.Close();
                return zaVratiti;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
           
        }

        public static PacijentDTO vratiAmb(int idA)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                Pacijent pacijent = sesija.Load<Pacijent>(idA);

                var tmp = pacijent.Stomatolog;
                var tmp2 = pacijent.LekarOpstePrakse;
           
                PacijentDTO zaVratiti = new PacijentDTO(pacijent);
                if (tmp != null)
                {
                    MedicinskoOsobljeDTO stomatolog = new MedicinskoOsobljeDTO(tmp);
                    zaVratiti.Stomatolog = stomatolog;
                }
                zaVratiti.Stomatolog = null;
                if(tmp2!=null)
                {
                    MedicinskoOsobljeDTO lop = new MedicinskoOsobljeDTO(tmp2);
                    zaVratiti.LekarOpstePrakse = lop;
                }
                zaVratiti.LekarOpstePrakse = null;
               
               
                sesija.Close();
                return zaVratiti;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }


        public static StomatoloskaStolicaDTO vratiStolicu(int idS)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
            
                StomatoloskaStolica stolica = sesija.Load<StomatoloskaStolica>(idS);

                var tmp = stolica.TehnickoOdrzavanje;

                StomatoloskaStolicaDTO zaVratiti = new StomatoloskaStolicaDTO(stolica);
                if(tmp!=null) 
                {
                    NemedicinskoOsobljeDTO nem = new NemedicinskoOsobljeDTO(tmp);
                    zaVratiti.TehnickoOdrzavanje = nem;
                }
                else zaVratiti.TehnickoOdrzavanje=null;
               

                sesija.Close();
                return zaVratiti;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }


        public static OdeljenjeDTO vratiOd(int idO)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Odeljenje od = sesija.Load<Odeljenje>(idO);

                var tmp = od.Specijalista;

                OdeljenjeDTO zaVratiti = new OdeljenjeDTO(od);
                if(tmp!=null)
                {
                    MedicinskoOsobljeDTO spec = new MedicinskoOsobljeDTO(tmp);

                    zaVratiti.Specijalista = spec;
                }
                zaVratiti.Specijalista = null;
                sesija.Close();
                return zaVratiti;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public static NemedicinskoOsobljeDTO vratiTehnicko(int idO)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                NemedicinskoOsoblje od = sesija.Load<NemedicinskoOsoblje>(idO);

                NemedicinskoOsobljeDTO zaVratiti = new NemedicinskoOsobljeDTO(od);

                sesija.Close();
                return zaVratiti;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public static MedicinskoOsobljeDTO vratiSpecijalistu(int idS)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                MedicinskoOsoblje S = sesija.Load<MedicinskoOsoblje>(idS);
                MedicinskoOsobljeDTO zaVratiti = new MedicinskoOsobljeDTO(S);
                
                sesija.Close();
                return zaVratiti;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        public static bool izmeniAmb(PacijentDTO izmenjen, bool st)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                Pacijent s = sesija.Load<Pacijent>(izmenjen.IDOsobe);
                s.Ime = izmenjen.Ime;
                s.Prezime = izmenjen.Prezime;
                s.MaticniBroj = izmenjen.MaticniBroj;
                s.Adresa = izmenjen.Adresa;
                s.VrstaIntervencije = izmenjen.VrstaIntervencije;
                s.DatumIntervencije = izmenjen.DatumIntervencije;
             
                s.LekarOpstePrakse = sesija.Load<MedicinskoOsoblje>(izmenjen.LekarOpstePrakse.IDOsobe);
                if(st)
                    s.Stomatolog = sesija.Load<MedicinskoOsoblje>(izmenjen.Stomatolog.IDOsobe);
               
                sesija.Update(s);
                sesija.Flush();
                sesija.Close();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public static bool izmeniStacionara(PacijentDTO izmenjen)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                Pacijent s = sesija.Load<Pacijent>(izmenjen.IDOsobe);

                s.Ime = izmenjen.Ime;
                s.Prezime = izmenjen.Prezime;
                s.MaticniBroj = izmenjen.MaticniBroj;

                s.DatumPrijema = izmenjen.DatumPrijema;
                s.DatumOtpusta = izmenjen.DatumOtpusta;

                s.LekarOpstePrakse = sesija.Load<MedicinskoOsoblje>(izmenjen.LekarOpstePrakse.IDOsobe);
                s.Odeljenje = sesija.Load<Odeljenje>(izmenjen.Odeljenje.ID);

                sesija.Update(s);
                sesija.Flush();
                sesija.Close();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

       
        public static MedicinskoOsobljeDTO vratilekaraOP(int idS)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();



        MedicinskoOsoblje lop = sesija.Load<MedicinskoOsoblje>(idS);
        MedicinskoOsobljeDTO zaVratiti = new MedicinskoOsobljeDTO(lop);
                sesija.Close();
                return zaVratiti;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        public static bool izmeniStolicu(StomatoloskaStolicaDTO izmenjen)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                StomatoloskaStolica s = sesija.Load<StomatoloskaStolica>(izmenjen.ID);
                s.Proizvodjac = izmenjen.Proizvodjac;
                s.DatumProizvodnje = izmenjen.DatumProizvodnje;

                s.TehnickoOdrzavanje = sesija.Load<NemedicinskoOsoblje>(izmenjen.TehnickoOdrzavanje.IDOsobe);


                sesija.Update(s);
                sesija.Flush();
                sesija.Close();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public static bool izmeniOdeljenje(OdeljenjeDTO izmenjen)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                Odeljenje s = sesija.Load<Odeljenje>(izmenjen.ID);
                s.Sifra = izmenjen.Sifra;
                s.Tip = izmenjen.Tip;
                s.DatumIzgradnje = izmenjen.DatumIzgradnje;

                s.Specijalista = sesija.Load<MedicinskoOsoblje>(izmenjen.Specijalista.IDOsobe);

                sesija.Update(s);
                sesija.Flush();
                sesija.Close();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;

        }

        public static bool izmeniTehnicara(NemedicinskoOsobljeDTO izmenjen)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                NemedicinskoOsoblje tehnicar = sesija.Load<NemedicinskoOsoblje>(izmenjen.IDOsobe);
                tehnicar.Ime = izmenjen.Ime;
                tehnicar.Prezime = izmenjen.Prezime;
                tehnicar.MaticniBroj = izmenjen.MaticniBroj;
                tehnicar.Struka = izmenjen.Struka;
                sesija.SaveOrUpdate(tehnicar);
                sesija.Flush();
                sesija.Close();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public static NemedicinskoOsobljeDTO vratiTehnicara(int idTehnicar)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                NemedicinskoOsoblje tehnicar = sesija.Load<NemedicinskoOsoblje>(idTehnicar);
                NemedicinskoOsobljeDTO zaVratiti = new NemedicinskoOsobljeDTO(tehnicar);
                
                sesija.Close();
                return zaVratiti;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public static List<OdrzavaHigijenuDTO> vratiZaduzenja()
        {
            List<OdrzavaHigijenuDTO> zaVracanje = new List<OdrzavaHigijenuDTO>();
            try
            {
                ISession sesija = DataLayer.GetSession();

                IEnumerable<OdrzavaHigijenu> zaduzenja= from z in sesija.Query<OdrzavaHigijenu>()select z;
                foreach (OdrzavaHigijenu x in zaduzenja)
                {
                    OdrzavaHigijenuDTO zaDodati = new OdrzavaHigijenuDTO(x);
                    var tmp = x.Odeljenje;
                    var tmp2 = x.Higijenicar;
                    zaDodati.Higijenicar = new NemedicinskoOsobljeDTO(tmp2);                   
                    zaDodati.Odeljenje = new OdeljenjeDTO(tmp);
                    zaVracanje.Add(zaDodati);
                }

                sesija.Close();
                return zaVracanje;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return zaVracanje;
        }
        public static void obrisiZaduzenja(int idZaduzenja)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                OdrzavaHigijenu zaBrisanje = sesija.Load<OdrzavaHigijenu>(idZaduzenja);
                sesija.Delete(zaBrisanje);
                sesija.Flush();
                sesija.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static OdrzavaHigijenuDTO vratiZaduzenje(int idS)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();


                OdrzavaHigijenu oh = sesija.Load<OdrzavaHigijenu>(idS);

                var tmp = oh.Higijenicar;
                var od = oh.Odeljenje;

                OdrzavaHigijenuDTO zaVratiti = new OdrzavaHigijenuDTO(oh);

                NemedicinskoOsobljeDTO lop = new NemedicinskoOsobljeDTO(tmp);
                OdeljenjeDTO ode = new OdeljenjeDTO(od);

                zaVratiti.Higijenicar = lop;
                zaVratiti.Odeljenje = ode;

                sesija.Close();
                return zaVratiti;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;


        }

        public static bool izmeniZaduzenje(OdrzavaHigijenuDTO izmenjen)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                OdrzavaHigijenu o = sesija.Load<OdrzavaHigijenu>(izmenjen.ID);

                o.Higijenicar = sesija.Load<NemedicinskoOsoblje>(izmenjen.Higijenicar.IDOsobe);
                o.Odeljenje = sesija.Load<Odeljenje>(izmenjen.Odeljenje.ID);

                sesija.Update(o);
                sesija.Flush();
                sesija.Close();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}