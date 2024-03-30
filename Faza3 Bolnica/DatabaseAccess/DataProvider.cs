using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bolnica.DTO;
using Bolnica.Entiteti;
using NHibernate;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Diagnostics;
using FluentNHibernate.Conventions.AcceptanceCriteria;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using Bolnica;

namespace DatabaseAccess
{
    public class DataProvider
    {
        #region Vrati Pacijente
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

                    if (x.LekarOpstePrakse != null)
                        zaDodati.LekarOpstePrakse = new MedicinskoOsobljeDTO(x.LekarOpstePrakse);
                    else
                        zaDodati.LekarOpstePrakse = null;

                    //zaDodati.Stomatolog = new MedicinskoOsobljeDTO(x.Stomatolog);

                    zaVracanje.Add(zaDodati);


                }

                sesija.Close();
                return zaVracanje;

            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return zaVracanje;
        }
        public static List<PacijentDTO> vratiStacionare()  //reseno
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
                    if (tmp != null)
                        zaDodati.LekarOpstePrakse = new MedicinskoOsobljeDTO(tmp);
                    else
                        zaDodati.LekarOpstePrakse = null;
                    zaDodati.Odeljenje = new OdeljenjeDTO(tmp2);
                    zaVracanje.Add(zaDodati);
                }

                sesija.Close();
                return zaVracanje;
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return zaVracanje;


        }
        public static List<PacijentDTO> vratiSveAmb()  //reseno
        {
            List<PacijentDTO> zaVracanje = new List<PacijentDTO>();
            try
            {
                ISession sesija = DataLayer.GetSession();

                IEnumerable<Pacijent> s = from z in sesija.Query<Pacijent>() where z.TipPacijenta == "Ambulanta" select z;
                foreach (Pacijent x in s)
                {
                    PacijentDTO zaDodati = new PacijentDTO(x);
                    if (x.Stomatolog!=null)
                    {
                        zaDodati.Stomatolog = new MedicinskoOsobljeDTO(x.Stomatolog);

                    }
                    else zaDodati.Stomatolog = null;
                    if (x.LekarOpstePrakse != null)
                    {
                        zaDodati.LekarOpstePrakse = new MedicinskoOsobljeDTO(x.LekarOpstePrakse);
                    }
                    else zaDodati.LekarOpstePrakse = null;

                    zaVracanje.Add(zaDodati);

                }
                sesija.Close();
                return zaVracanje;
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return zaVracanje;
        }

        public static PacijentDTO vratiStacionara(int idS)   //reseno
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

               var Lista=sesija.Query<Pacijent>().Where(m=>m.TipPacijenta=="Stacionar"&&m.IDOsobe==idS).ToList();
                if (Lista.Count != 1)
                {
                    return null;
                }
                Pacijent S = Lista[0];
                PacijentDTO zaVratiti=new PacijentDTO(S);

                var tmp = S.LekarOpstePrakse;
                var od = S.Odeljenje;

               if(tmp!=null)
                {
                    MedicinskoOsobljeDTO lop = new MedicinskoOsobljeDTO(tmp);
                    zaVratiti.LekarOpstePrakse = lop;
                }
                else
                {
                    zaVratiti.LekarOpstePrakse = null;
                }
               if(od!=null )
                {
                    OdeljenjeDTO ode = new OdeljenjeDTO(od);
                    zaVratiti.Odeljenje = ode;
                }
                else
                {
                    zaVratiti.Odeljenje = null;
                }

                sesija.Close();
                return zaVratiti;
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return null;

        }

        public static PacijentDTO vratiAmb(int idA)  //reseno
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                var Lista=sesija.Query<Pacijent>().Where(m=>m.TipPacijenta=="Ambulanta"&&m.IDOsobe==idA).ToList();
                if (Lista.Count != 1)
                {
                    return null;
                }
                Pacijent S = Lista[0];
                PacijentDTO pacijent = new PacijentDTO(S);

               
                var tmp = S.Stomatolog;
                var tmp2 = S.LekarOpstePrakse;

                
                if (tmp != null)
                {
                    MedicinskoOsobljeDTO stomatolog = new MedicinskoOsobljeDTO(tmp);
                    pacijent.Stomatolog = stomatolog;
                }
                MedicinskoOsobljeDTO lop = new MedicinskoOsobljeDTO(tmp2);

                pacijent.LekarOpstePrakse = lop;
                sesija.Close();
                return pacijent;
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return null;
        }


        #endregion

        #region Dodaj Pacijente

        public static int dodajPacijentaA(PacijentDTO pac)
        {
            int flag = 0;
            try
            {
                ISession s = DataLayer.GetSession();
                var Lista = s.Query<Osoba>().Where(m => m.MaticniBroj == pac.MaticniBroj).ToList();
                if (Lista.Count != 0)
                {
                    flag = 1;
                    return flag;
                }
                Pacijent m = new Pacijent();
                m.Ime = pac.Ime;
                m.Prezime = pac.Prezime;
                m.MaticniBroj = pac.MaticniBroj;
                m.Adresa = pac.Adresa;
                m.TipPacijenta = "Ambulanta";

                MedicinskoOsoblje o = s.Load<MedicinskoOsoblje>(pac.Stomatolog.IDOsobe);
                m.Stomatolog = o;

                MedicinskoOsoblje o2 = s.Load<MedicinskoOsoblje>(pac.LekarOpstePrakse.IDOsobe);
                m.LekarOpstePrakse = o2;

                s.Save(m);

                s.Flush();
                s.Close();
                return flag;

            }
            catch (Exception ec)
            {
                Console.WriteLine("Greska " + ec.Message);
                throw ec;
             
            }
        }

        public static int dodajPacijentaS(PacijentDTO pac)
        {
            int flag = 0;
            try
            {
                ISession s = DataLayer.GetSession();
                var Lista = s.Query<Osoba>().Where(m => m.MaticniBroj == pac.MaticniBroj).ToList();
                if (Lista.Count != 0)
                {
                    flag = 1;
                    return flag;
                }
                Pacijent m = new Pacijent();

                m.Ime = pac.Ime;
                m.Prezime = pac.Prezime;
                m.MaticniBroj = pac.MaticniBroj;
                m.DatumPrijema = pac.DatumPrijema;
                m.DatumOtpusta = pac.DatumOtpusta;
                m.TipPacijenta = "Stacionar";


                MedicinskoOsoblje o2 = s.Load<MedicinskoOsoblje>(pac.LekarOpstePrakse.IDOsobe);
                m.LekarOpstePrakse = o2;

                Odeljenje o = s.Load<Odeljenje>(pac.Odeljenje.ID);
                m.Odeljenje = o;

                s.Save(m);
                s.Flush();
                s.Close();
                return flag;

            }
            catch (Exception ec)
            {
                Console.WriteLine("Greska " + ec.Message);
                throw ec;
               
            }
        }

        #endregion

        #region Izmeni Pacijente

        public static bool izmeniAmb(PacijentDTO izmenjen)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                var Lista = sesija.Query<Pacijent>().Where(m => m.TipPacijenta == "Ambulanta" && m.IDOsobe == izmenjen.IDOsobe).ToList();
                if (Lista.Count != 1)
                {
                    return false;
                }
                Pacijent S = Lista[0];


                Pacijent s = sesija.Load<Pacijent>(S.IDOsobe);


                if (izmenjen.Ime != null)
                    s.Ime = izmenjen.Ime;
                if (izmenjen.Prezime != null)
                    s.Prezime = izmenjen.Prezime;
                if (izmenjen.MaticniBroj != null)
                    s.MaticniBroj = izmenjen.MaticniBroj;
                if (izmenjen.Adresa != null)
                    s.Adresa = izmenjen.Adresa;
                if (izmenjen.VrstaIntervencije != null)
                    s.VrstaIntervencije = izmenjen.VrstaIntervencije;
                if (izmenjen.DatumIntervencije != null)
                    s.DatumIntervencije = izmenjen.DatumIntervencije;


                if (izmenjen.LekarOpstePrakse != null)
                    s.LekarOpstePrakse = sesija.Load<MedicinskoOsoblje>(izmenjen.LekarOpstePrakse.IDOsobe);
                else
                    s.LekarOpstePrakse = s.LekarOpstePrakse;

                if (izmenjen.Stomatolog != null)
                    s.Stomatolog = sesija.Load<MedicinskoOsoblje>(izmenjen.Stomatolog.IDOsobe);
                else
                    s.Stomatolog = null;



                sesija.Update(s);
                sesija.Flush();
                sesija.Close();



                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                
            }
            return false;
        }
        public static bool izmeniStacionara(PacijentDTO izmenjen)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                var Lista = sesija.Query<Pacijent>().Where(m => m.TipPacijenta == "Stacionar" && m.IDOsobe == izmenjen.IDOsobe).ToList();
                if (Lista.Count != 1)
                {
                    return false;
                }
                Pacijent S = Lista[0];


                Pacijent s = sesija.Load<Pacijent>(S.IDOsobe);


                if (izmenjen.Ime != null)
                    s.Ime = izmenjen.Ime;
                if (izmenjen.Prezime != null)
                    s.Prezime = izmenjen.Prezime;
                if (izmenjen.MaticniBroj != null)
                    s.MaticniBroj = izmenjen.MaticniBroj;
                if (izmenjen.DatumPrijema != null)
                    s.DatumPrijema = izmenjen.DatumPrijema;
                if (izmenjen.DatumOtpusta != null)
                    s.DatumOtpusta = izmenjen.DatumOtpusta;
                if (izmenjen.LekarOpstePrakse != null)
                    s.LekarOpstePrakse = sesija.Load<MedicinskoOsoblje>(izmenjen.LekarOpstePrakse.IDOsobe);
                else s.LekarOpstePrakse = s.LekarOpstePrakse;
                if (izmenjen.Odeljenje != null)
                    s.Odeljenje = sesija.Load<Odeljenje>(izmenjen.Odeljenje.ID);
                else s.Odeljenje = s.Odeljenje;

                sesija.Update(s);
                sesija.Flush();
                sesija.Close();



                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                
            }
            return false;
        }

        #endregion

        #region Obrisi Pacijente

        public static bool obrisiStacionara(int idStacionara)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();


                var Lista = sesija.Query<Pacijent>().Where(m => m.TipPacijenta == "Stacionar" && m.IDOsobe == idStacionara).ToList();
                if (Lista.Count != 1)
                {
                    return false;
                }

                Pacijent S = Lista[0];

                Pacijent zaBrisanje = sesija.Load<Pacijent>(idStacionara);
                zaBrisanje.Odeljenje = null;
                zaBrisanje.LekarOpstePrakse = null;


                sesija.Delete(zaBrisanje);
                sesija.Flush();
                sesija.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                return false;
            }
        }
        public static bool obrisiAmbulanta(int idAmbulante)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();


                var Lista = sesija.Query<Pacijent>().Where(m => m.TipPacijenta == "Ambulanta" && m.IDOsobe == idAmbulante).ToList();
                if (Lista.Count != 1)
                {
                    return false;
                }

                Pacijent S = Lista[0];

                Pacijent zaBrisanje = sesija.Load<Pacijent>(idAmbulante);

                zaBrisanje.LekarOpstePrakse = null;
                zaBrisanje.Stomatolog = null;

                sesija.Delete(zaBrisanje);
                sesija.Flush();
                sesija.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                return false;
            }
        }

        #endregion

        #region Vrati Medicinsko Osoblje

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
                Console.WriteLine("Greska " + e.Message);
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
                Console.WriteLine("Greska " + e.Message);
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
                Console.WriteLine("Greska " + e.Message);
            }
            return zaVracanje;
        }

        public static List<MedicinskoOsobljeDTO> vratiSveStomatologe()  //reseno
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
                Console.WriteLine("Greska " + e.Message);
            }
            return zaVracanje;
        }

        public static MedicinskoOsobljeDTO vratiStomatologa(int idS)  //reseno
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                var Lista = sesija.Query<MedicinskoOsoblje>().Where(m => m.TipMedOsoblja == "Stomatolog" && m.IDOsobe == idS).ToList();
                if (Lista.Count != 1)
                {
                    return null;
                }
                MedicinskoOsoblje S = Lista[0];
                MedicinskoOsobljeDTO zaVratiti = new MedicinskoOsobljeDTO(S);
                var tmp = S.Stolica;
                StomatoloskaStolicaDTO stolica = new StomatoloskaStolicaDTO(tmp);
                zaVratiti.Stolica = stolica;


                sesija.Close();
                return zaVratiti;
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return null;
        }

        public static MedicinskoOsobljeDTO vratiSpecijalistu(int idS)  
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                //MedicinskoOsoblje S = sesija.Load<MedicinskoOsoblje>(idS);
                var Lista = sesija.Query<MedicinskoOsoblje>().Where(m => m.TipMedOsoblja == "Specijalista" && m.IDOsobe == idS).ToList();
                if(Lista.Count!=1)
                {
                    return null;
                }
                MedicinskoOsoblje S = Lista[0];
                MedicinskoOsobljeDTO zaVratiti = new MedicinskoOsobljeDTO(S);

                sesija.Close();
                return zaVratiti;
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return null;
        }



        public static MedicinskoOsobljeDTO vratilekaraOP(int idS)  
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                //MedicinskoOsoblje S = sesija.Load<MedicinskoOsoblje>(idS);
                var Lista = sesija.Query<MedicinskoOsoblje>().Where(m => m.TipMedOsoblja == "Opsta praksa" && m.IDOsobe == idS).ToList();
                if (Lista.Count != 1)
                {
                    return null;
                }
                MedicinskoOsoblje S = Lista[0];
                MedicinskoOsobljeDTO zaVratiti = new MedicinskoOsobljeDTO(S);

                sesija.Close();
                return zaVratiti;
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return null;
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
                Console.WriteLine("Greska " + e.Message);
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
                Console.WriteLine("Greska " + e.Message);
            }
            return zaVracanje;
        }



        #endregion

        #region Dodaj Medicinsko Osoblje

        public static int dodajSpecijalistu(MedicinskoOsobljeDTO med)
        {
            int flag = 0;
           
            try
            {
                ISession s = DataLayer.GetSession();
                var Lista = s.Query<Osoba>().Where(m => m.MaticniBroj==med.MaticniBroj).ToList();
                if (Lista.Count != 0)
                {
                    flag = 1;
                    return flag;
                }
                MedicinskoOsoblje m = new MedicinskoOsoblje();

                m.Ime = med.Ime;

                m.Prezime = med.Prezime;

                m.MaticniBroj = med.MaticniBroj;

                m.GodineRadnogStaza = med.GodineRadnogStaza;

                m.Specijalnost = med.Specijalnost;

                m.TipMedOsoblja = "Specijalista";
             
               
                   s.Save(m);
                   s.Flush();
                   s.Close();
                   return flag;
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                throw e;
            }
        }

        public static int dodajStomatologa(MedicinskoOsobljeDTO med)
        {
            int flag = 0;
            try
            {
                ISession s = DataLayer.GetSession();
                var Lista = s.Query<Osoba>().Where(m => m.MaticniBroj == med.MaticniBroj).ToList();
                if (Lista.Count != 0)
                {
                    flag = 1;
                    return flag;
                }
                MedicinskoOsoblje m = new MedicinskoOsoblje();

                m.Ime = med.Ime;

                m.Prezime = med.Prezime;

                m.MaticniBroj = med.MaticniBroj;

                m.Smena = med.Smena;

                m.GodineRadnogStaza = med.GodineRadnogStaza;

                m.TipMedOsoblja = "Stomatolog";
                if (med.Stolica != null)
                {
                    StomatoloskaStolica st = s.Load<Bolnica.Entiteti.StomatoloskaStolica>(med.Stolica.ID);
                    m.Stolica = st;
                }
                else
                {
                    m.Stolica = null;
                }

                    s.Save(m);
                    s.Flush();
                    s.Close();
                    return flag;
               
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                throw e;
            }
        }

        public static int dodajLekaraOpstePrakse(MedicinskoOsobljeDTO med)
        {
            int flag = 0;
            try
            {
                ISession s = DataLayer.GetSession();
                var Lista = s.Query<Osoba>().Where(m => m.MaticniBroj == med.MaticniBroj).ToList();
                if (Lista.Count != 0)
                {
                    flag = 1;
                    return flag;
                }

                MedicinskoOsoblje m = new MedicinskoOsoblje();

                m.Ime = med.Ime;

                m.Prezime = med.Prezime;

                m.MaticniBroj = med.MaticniBroj;

                m.GodineRadnogStaza = med.GodineRadnogStaza;

                m.BrojOrdinacije = med.BrojOrdinacije;

                m.TipMedOsoblja = "Opsta praksa";
                
               
                    s.Save(m);
                    s.Flush();
                    s.Close();
                    return flag;
               
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                throw e;
            }
        }


        #endregion

        #region Izmeni Medicinsko Osoblje

        public static bool izmeniStomatologa(MedicinskoOsobljeDTO izmenjen)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                var Lista = sesija.Query<MedicinskoOsoblje>().Where(m => m.TipMedOsoblja == "Stomatolog" && m.IDOsobe == izmenjen.IDOsobe).ToList();
                if (Lista.Count != 1)
                {
                    return false;
                }
                MedicinskoOsoblje S = Lista[0];


                MedicinskoOsoblje s = sesija.Load<MedicinskoOsoblje>(S.IDOsobe);
                if (izmenjen.Ime != null)
                    s.Ime = izmenjen.Ime;
                if (izmenjen.Prezime != null)
                    s.Prezime = izmenjen.Prezime;
                if (izmenjen.MaticniBroj != null)
                    s.MaticniBroj = izmenjen.MaticniBroj;
                if (izmenjen.GodineRadnogStaza != 0)
                    s.GodineRadnogStaza = izmenjen.GodineRadnogStaza;
                if (izmenjen.Smena == 1 || izmenjen.Smena == 2)
                    s.Smena = izmenjen.Smena;
                else
                {
                    s.Smena = s.Smena;
                }
                s.TipMedOsoblja = "Stomatolog";
                if (izmenjen.Stolica != null)
                {
                    s.Stolica = sesija.Load<StomatoloskaStolica>(izmenjen.Stolica.ID);
                }
                else
                {
                    s.Stolica = s.Stolica;
                }

                sesija.SaveOrUpdate(s);
                sesija.Flush();
                sesija.Close();



                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return false;
        }

        public static bool izmeniOP(MedicinskoOsobljeDTO izmenjen)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                var Lista = sesija.Query<MedicinskoOsoblje>().Where(m => m.TipMedOsoblja == "Opsta praksa" && m.IDOsobe == izmenjen.IDOsobe).ToList();
                if (Lista.Count != 1)
                {
                    return false;
                }
                MedicinskoOsoblje S = Lista[0];


                MedicinskoOsoblje s = sesija.Load<MedicinskoOsoblje>(S.IDOsobe);
                if (izmenjen.Ime != null)
                    s.Ime = izmenjen.Ime;
                if (izmenjen.Prezime != null)
                    s.Prezime = izmenjen.Prezime;
                if (izmenjen.MaticniBroj != null)
                    s.MaticniBroj = izmenjen.MaticniBroj;
                if (izmenjen.GodineRadnogStaza != 0)
                    s.GodineRadnogStaza = izmenjen.GodineRadnogStaza;
                if (izmenjen.BrojOrdinacije != 0)
                    s.BrojOrdinacije = izmenjen.BrojOrdinacije;



                sesija.SaveOrUpdate(s);
                sesija.Flush();
                sesija.Close();



                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return false;
        }

        public static bool izmeniSpec(MedicinskoOsobljeDTO izmenjen)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                var Lista = sesija.Query<MedicinskoOsoblje>().Where(m => m.TipMedOsoblja == "Specijalista" && m.IDOsobe == izmenjen.IDOsobe).ToList();
                if (Lista.Count != 1)
                {
                    return false;
                }
                MedicinskoOsoblje S = Lista[0];


                MedicinskoOsoblje s = sesija.Load<MedicinskoOsoblje>(S.IDOsobe);
                if (izmenjen.Ime != null)
                    s.Ime = izmenjen.Ime;
                if (izmenjen.Prezime != null)
                    s.Prezime = izmenjen.Prezime;
                if (izmenjen.MaticniBroj != null)
                    s.MaticniBroj = izmenjen.MaticniBroj;
                if (izmenjen.GodineRadnogStaza != 0)
                    s.GodineRadnogStaza = izmenjen.GodineRadnogStaza;
                if (izmenjen.Specijalnost != null)
                    s.Specijalnost = izmenjen.Specijalnost;



                sesija.SaveOrUpdate(s);
                sesija.Flush();
                sesija.Close();



                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return false;
        }


        #endregion

        #region Obrisi Medicinsko Osoblje


        public static bool obrisiStomatologa(int idStomatologa)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                var Lista = sesija.Query<MedicinskoOsoblje>().Where(m => m.TipMedOsoblja == "Stomatolog" && m.IDOsobe == idStomatologa).ToList();
                if (Lista.Count != 1)
                {
                    return false;
                }

                MedicinskoOsoblje S = Lista[0];

                MedicinskoOsoblje zaBrisanje = sesija.Load<MedicinskoOsoblje>(idStomatologa);

                zaBrisanje.Stolica = null;
                
                
                sesija.Delete(zaBrisanje);
                sesija.Flush();
                sesija.Close();
                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                return false;
            }
        }

        public static bool obrisiOP(int idOP)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                var Lista = sesija.Query<MedicinskoOsoblje>().Where(m => m.TipMedOsoblja == "Opsta praksa" && m.IDOsobe == idOP).ToList();
                if (Lista.Count != 1)
                {
                    return false;
                }
                MedicinskoOsoblje S = Lista[0];
                MedicinskoOsoblje zaBrisanje = sesija.Load<MedicinskoOsoblje>(idOP);
                zaBrisanje.Pacijenti = null;
                sesija.Delete(zaBrisanje);
                sesija.Flush();
                sesija.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                return false;
            }
        }

        public static bool obrisiSpec(int idspec)  
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                var Lista = sesija.Query<MedicinskoOsoblje>().Where(m => m.TipMedOsoblja == "Specijalista" && m.IDOsobe == idspec).ToList();
                if (Lista.Count != 1)
                {
                    return false;
                }
                MedicinskoOsoblje S = Lista[0];
                MedicinskoOsoblje zaBrisanje = sesija.Load<MedicinskoOsoblje>(S.IDOsobe);
                zaBrisanje.Odeljenja = null;
                //zaBrisanje.Pacijenti = null;
              
                sesija.Delete(zaBrisanje);
                sesija.Flush();
                sesija.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                return false;
            }
        }

        #endregion

        #region Vrati Nemedicinsko Osoblje

        public static NemedicinskoOsobljeDTO vratiHigijenicara(int idHigijenicar)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                var Lista = sesija.Query<NemedicinskoOsoblje>().Where(m=>m.TipNemedOsoblja=="Higijenicar"&& m.IDOsobe==idHigijenicar).ToList();
                if(Lista.Count!=1)
                {
                    return null;
                }
                NemedicinskoOsoblje S = Lista[0];
                NemedicinskoOsobljeDTO zaVratiti = new NemedicinskoOsobljeDTO(S);
                sesija.Close();
                return zaVratiti;
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return null;
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
                Console.WriteLine("Greska " + e.Message);
            }
            return zaVracanje;
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
                Console.WriteLine("Greska " + e.Message);
            }
            return null;
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
                Console.WriteLine("Greska " + e.Message);
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
                Console.WriteLine("Greska " + e.Message);
            }
            return zaVracanje;
        }

        public static NemedicinskoOsobljeDTO vratiTehnicara(int idTehnicar)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();



                NemedicinskoOsoblje tehnicar = sesija.Load<NemedicinskoOsoblje>(idTehnicar);

                NemedicinskoOsobljeDTO zaVratiti = new NemedicinskoOsobljeDTO(tehnicar);



                //List<StomatoloskaStolicaDTO> stolice = vratiStolice();



                //for(int i=0; i<stolice.Count; i++)
                //{
                //    if (stolice[i].TehnickoOdrzavanje.IDOsobe == idTehnicar)
                //        zaVratiti.Stolice.Add(stolice[i]);
                //}



                sesija.Close();
                if (zaVratiti.TipNemedOsoblja != "Tehnicko odrzavanje")
                    return null;
                else
                    return zaVratiti;
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return null;
        }


        #endregion

        #region Dodaj Nemedicinsko Osoblje

        public static int dodajNovogHigijenicara(NemedicinskoOsobljeDTO nemed)
        {
            int flag = 0;
            try
            {
                ISession s = DataLayer.GetSession();
                var Lista = s.Query<Osoba>().Where(m => m.MaticniBroj == nemed.MaticniBroj).ToList();
                if (Lista.Count != 0)
                {
                    flag = 1;
                    return flag;
                }

                NemedicinskoOsoblje m = new NemedicinskoOsoblje();


                m.Ime = nemed.Ime;
                m.Prezime = nemed.Prezime;
                m.MaticniBroj = nemed.MaticniBroj;

                m.TipNemedOsoblja = "Higijenicar";

              
                    s.Save(m);
                    s.Flush();
                    s.Close();
                    return flag;
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                throw e;
            }
        }

        public static int dodajNovoTehnickoOsoblje(NemedicinskoOsobljeDTO nemed)
        {
            int flag = 0;
            try
            {
                ISession s = DataLayer.GetSession();
                var Lista = s.Query<Osoba>().Where(m => m.MaticniBroj == nemed.MaticniBroj).ToList();
                if (Lista.Count != 0)
                {
                    flag = 1;
                    return flag;
                }

                NemedicinskoOsoblje m = new NemedicinskoOsoblje();

                m.Ime = nemed.Ime;

                m.Prezime = nemed.Prezime;

                m.MaticniBroj = nemed.MaticniBroj;

                m.Struka = nemed.Struka;

                m.TipNemedOsoblja = "Tehnicko odrzavanje";

               
                    s.Save(m);
                    s.Flush();
                    s.Close();
                    return flag;
              
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                throw e;
            }

        }

        #endregion

        #region Izmeni Nemedicinsko Osoblje

        public static bool izmeniHigijenicara(NemedicinskoOsobljeDTO izmenjen)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                var Lista = sesija.Query<NemedicinskoOsoblje>().Where(m => m.TipNemedOsoblja == "Higijenicar" && m.IDOsobe == izmenjen.IDOsobe).ToList();
                if (Lista.Count != 1)
                {
                    return false;
                }
                NemedicinskoOsoblje S = Lista[0];


                NemedicinskoOsoblje higijenicar = sesija.Load<NemedicinskoOsoblje>(S.IDOsobe);

                if (izmenjen.Ime != null)
                    higijenicar.Ime = izmenjen.Ime;
                else
                    higijenicar.Ime = higijenicar.Ime;

                if (izmenjen.Prezime != null)
                    higijenicar.Prezime = izmenjen.Prezime;
                else
                    higijenicar.Prezime = higijenicar.Prezime;

                if (izmenjen.MaticniBroj != null)
                    higijenicar.MaticniBroj = izmenjen.MaticniBroj;


                sesija.SaveOrUpdate(higijenicar);
                sesija.Flush();
                sesija.Close();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return false;
        }

        public static bool izmeniTehnicara(NemedicinskoOsobljeDTO izmenjen)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                var Lista = sesija.Query<NemedicinskoOsoblje>().Where(m => m.TipNemedOsoblja == "Tehnicko odrzavanje" && m.IDOsobe == izmenjen.IDOsobe).ToList();
                if (Lista.Count != 1)
                {
                    return false;
                }
                NemedicinskoOsoblje S = Lista[0];


                NemedicinskoOsoblje s = sesija.Load<NemedicinskoOsoblje>(S.IDOsobe);


                if (izmenjen.Ime != null)
                    s.Ime = izmenjen.Ime;
                else
                    s.Ime = s.Ime;

                if (izmenjen.Prezime != null)
                    s.Prezime = izmenjen.Prezime;
                else
                    s.Prezime = s.Prezime;

                if (izmenjen.MaticniBroj != null)
                    s.MaticniBroj = izmenjen.MaticniBroj;
                else
                    s.MaticniBroj = s.MaticniBroj;


                if (izmenjen.Stolice == null)
                    s.Stolice = s.Stolice;
                else
                {
                    for (int i = 0; i < izmenjen.Stolice.Count; i++)
                    {
                        StomatoloskaStolica si = sesija.Load<Bolnica.Entiteti.StomatoloskaStolica>(izmenjen.Stolice[i].ID);
                        s.Stolice?.Add(si);
                    }
                }

                sesija.SaveOrUpdate(s);
                sesija.Flush();
                sesija.Close();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return false;
        }




        #endregion

        #region Obrisi Nemedicinsko Osoblje

        public static bool obrisiHigijenicara(int idHigijenicar)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                var Lista = sesija.Query<NemedicinskoOsoblje>().Where(m => m.TipNemedOsoblja == "Higijenicar" && m.IDOsobe == idHigijenicar).ToList();
                if (Lista.Count != 1)
                {
                    return false;
                }

                NemedicinskoOsoblje S = Lista[0];
                NemedicinskoOsoblje zaBrisanje = sesija.Load<NemedicinskoOsoblje>(idHigijenicar);
                zaBrisanje.Stolice = null;


                sesija.Delete(zaBrisanje);
                sesija.Flush();
                sesija.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                return false;
            }
        }


        public static bool obrisiTehnicara(int idTehnicar)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                var Lista = sesija.Query<NemedicinskoOsoblje>().Where(m => m.TipNemedOsoblja == "Tehnicko odrzavanje" && m.IDOsobe == idTehnicar).ToList();
                if (Lista.Count != 1)
                {
                    return false;
                }

                NemedicinskoOsoblje S = Lista[0];


                NemedicinskoOsoblje zaBrisanje = sesija.Load<NemedicinskoOsoblje>(idTehnicar);

                if (zaBrisanje == null)
                {
                    return false;
                }
                zaBrisanje.Stolice = null;
                sesija.Delete(zaBrisanje);
                sesija.Flush();
                sesija.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                return false;
            }
        }



        #endregion

        #region Vrati Stolice

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
                Console.WriteLine("Greska " + e.Message);
            }
            return zaVracanje;
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
                Console.WriteLine("Greska " + e.Message);
            }
            return zaVracanje;

        }


        public static StomatoloskaStolicaDTO vratiStolicu(int idS)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                var Lista = sesija.Query<StomatoloskaStolica>().Where(m=>m.ID==idS).ToList();
                if (Lista.Count != 1)
                {
                    return null;
                }
                StomatoloskaStolica S = Lista[0];
                StomatoloskaStolicaDTO zaVratiti = new StomatoloskaStolicaDTO(S);
                var tmp = S.TehnickoOdrzavanje;
                if (tmp != null)
                {
                    NemedicinskoOsobljeDTO nem = new NemedicinskoOsobljeDTO(tmp);
                    zaVratiti.TehnickoOdrzavanje = nem;
                }
                else
                    zaVratiti.TehnickoOdrzavanje = null;
                sesija.Close();
                return zaVratiti;
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return null;
        }

        #endregion

        #region Dodaj Stolicu

        public static void dodajStolicu(StomatoloskaStolicaDTO s)
        {

            try
            {
                ISession sesija = DataLayer.GetSession();

                StomatoloskaStolica ss = new StomatoloskaStolica();

                NemedicinskoOsoblje n = sesija.Load<NemedicinskoOsoblje>(s.TehnickoOdrzavanje.IDOsobe);

                ss.Proizvodjac = s.Proizvodjac;
                ss.DatumProizvodnje = s.DatumProizvodnje;
                ss.TehnickoOdrzavanje = n;



                sesija.Save(ss);
                sesija.Flush();
                sesija.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }

        }

        #endregion

        #region Izmeni Stolicu

        public static bool izmeniStolicu(StomatoloskaStolicaDTO izmenjen)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                StomatoloskaStolica s = sesija.Load<StomatoloskaStolica>(izmenjen.ID);
                if (izmenjen.Proizvodjac != null)
                    s.Proizvodjac = izmenjen.Proizvodjac;
                else
                    s.Proizvodjac = s.Proizvodjac;
                if (izmenjen.DatumProizvodnje != null)
                    s.DatumProizvodnje = izmenjen.DatumProizvodnje;
                else
                    s.DatumProizvodnje = s.DatumProizvodnje;



                if (izmenjen.TehnickoOdrzavanje == null)
                    s.TehnickoOdrzavanje = s.TehnickoOdrzavanje;
                else
                {
                    NemedicinskoOsoblje t = sesija.Load<Bolnica.Entiteti.NemedicinskoOsoblje>(izmenjen.TehnickoOdrzavanje.IDOsobe);
                    s.TehnickoOdrzavanje = t;
                }

                sesija.SaveOrUpdate(s);
                sesija.Flush();
                sesija.Close();



                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return false;
        }

        #endregion

        #region Obrisi Stolicu

        public static bool obrisiStolice(int idStolice)  
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                StomatoloskaStolica zaBrisanje = sesija.Load<StomatoloskaStolica>(idStolice);

                if (zaBrisanje == null)
                {
                    return false;
                }
                
                sesija.Delete(zaBrisanje);
                sesija.Flush();
                sesija.Close();
                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                return false;
            }

        }

        #endregion

        #region Vrati Odeljenja

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
                        zaDodati.Specijalista = new MedicinskoOsobljeDTO(tmp);
                    else
                        zaDodati.Specijalista = null;
                    zaVracanje.Add(zaDodati);
                }

                sesija.Close();
                return zaVracanje;
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return zaVracanje;



        }

        public static OdeljenjeDTO vratiOd(int idO)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                var Lista = sesija.Query<Odeljenje>().Where(m=>m.ID==idO).ToList();
                if (Lista.Count != 1)
                {
                    return null;
                }
                Odeljenje S = Lista[0];
                OdeljenjeDTO zaVratiti=new OdeljenjeDTO(S);
                var tmp = S.Specijalista;
                if (tmp != null)
                {
                    MedicinskoOsobljeDTO spec = new MedicinskoOsobljeDTO(tmp);
                    zaVratiti.Specijalista = spec;
                }
                else zaVratiti.Specijalista = null;
           
                sesija.Close();
                return zaVratiti;
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return null;
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
                Console.WriteLine("Greska " + e.Message);
            }
            return zaVracanje;
        }


        #endregion

        #region Dodaj Odeljenje

        public static int dodajOdeljenje(OdeljenjeDTO ode)
        {
            int flag = 0;
            try
            {
                ISession s = DataLayer.GetSession();
                var Lista = s.Query<Odeljenje>().Where(m => m.Sifra==ode.Sifra).ToList();
                if (Lista.Count != 0)
                {
                    flag = 1;
                    return flag;
                }
                Odeljenje m = new Odeljenje();

                m.Sifra = ode.Sifra;
                m.Tip = ode.Tip;
                m.DatumIzgradnje = ode.DatumIzgradnje;

                if (ode.Specijalista != null)
                {
                    MedicinskoOsoblje o = s.Load<MedicinskoOsoblje>(ode.Specijalista.IDOsobe);
                    m.Specijalista = o;
                }
                else ode.Specijalista = null;

                    s.Save(m);
                    s.Flush();
                    s.Close();
                    return flag;
               
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greska " + ec.Message);
                throw ec;
            }
        }

        #endregion

        #region Izmeni Odeljenje

        public static bool izmeniOdeljenje(OdeljenjeDTO izmenjen)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                Odeljenje s = sesija.Load<Odeljenje>(izmenjen.ID);
                if (izmenjen.Sifra != 0)
                    s.Sifra = izmenjen.Sifra;
                if (izmenjen.Tip != null)
                    s.Tip = izmenjen.Tip;
                if (izmenjen.DatumIzgradnje != null)
                    s.DatumIzgradnje = izmenjen.DatumIzgradnje;
                
                if (izmenjen.Specijalista != null)
                    s.Specijalista = sesija.Load<MedicinskoOsoblje>(izmenjen.Specijalista.IDOsobe);
                else
                    s.Specijalista = s.Specijalista;



                sesija.Update(s);
                sesija.Flush();
                sesija.Close();



                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return false;



        }



        #endregion

        #region Obrisi Odeljenje

        public static bool obrisiOdeljenje(int idOdeljenja) 
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                Odeljenje zaBrisanje = sesija.Load<Odeljenje>(idOdeljenja);
                if (zaBrisanje == null)
                {
                    return false;
                }
                zaBrisanje.Specijalista = null;
                sesija.Delete(zaBrisanje);
                sesija.Flush();
                sesija.Close();
                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                return false;
            }

        }


        #endregion

        #region Vrati Zaduzenja

        public static List<OdrzavaHigijenuDTO> vratiZaduzenja()
        {
            List<OdrzavaHigijenuDTO> zaVracanje = new List<OdrzavaHigijenuDTO>();
            try
            {
                ISession sesija = DataLayer.GetSession();

                IEnumerable<OdrzavaHigijenu> zaduzenja = from z in sesija.Query<OdrzavaHigijenu>() select z;
                foreach (OdrzavaHigijenu x in zaduzenja)
                {
                    OdrzavaHigijenuDTO zaDodati = new OdrzavaHigijenuDTO(x);
                    var tmp = x.Odeljenje;
                    var tmp2 = x.Higijenicar;
                    if (tmp2 != null)
                        zaDodati.Higijenicar = new NemedicinskoOsobljeDTO(tmp2);
                    else
                        zaDodati.Higijenicar = null;
                    if (tmp != null)
                        zaDodati.Odeljenje = new OdeljenjeDTO(tmp);
                    else
                        zaDodati.Odeljenje = null;

                    var tmp3 = x.Odeljenje?.Specijalista;
                    if( zaDodati.Odeljenje != null)
                    {
                        if (tmp3 != null)
                            zaDodati.Odeljenje.Specijalista = new MedicinskoOsobljeDTO(tmp3);
                        else
                            zaDodati.Odeljenje.Specijalista = null;
                    }
                    


                    zaVracanje.Add(zaDodati);
                }

                sesija.Close();
                return zaVracanje;
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return zaVracanje;
        }

        public static OdrzavaHigijenuDTO vratiZaduzenje(int idS)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                var Lista = sesija.Query<OdrzavaHigijenu>().Where(m=>m.ID==idS).ToList();
                if (Lista.Count != 1)
                {
                    return null;
                }
                OdrzavaHigijenu S = Lista[0];
                OdrzavaHigijenuDTO zaVratiti = new OdrzavaHigijenuDTO(S);
                var tmp = S.Higijenicar;
                var od = S.Odeljenje;
                if(tmp!=null)
                {
                    NemedicinskoOsobljeDTO lop = new NemedicinskoOsobljeDTO(tmp);
                    zaVratiti.Higijenicar = lop;
                }
            
                if(od!=null)
                {
                    OdeljenjeDTO ode = new OdeljenjeDTO(od);
                    zaVratiti.Odeljenje = ode;
                }
              
                sesija.Close();
                return zaVratiti;
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return null;


        }

        #endregion

        #region Dodaj Zaduzenje

        public static int dodajZaduzenje(OdrzavaHigijenuDTO odr)
        {
            try
            {

                ISession s = DataLayer.GetSession();
                NemedicinskoOsoblje hig = s.Load<NemedicinskoOsoblje>(odr.Higijenicar.IDOsobe);
                Odeljenje ode = s.Load<Odeljenje>(odr.Odeljenje.ID);
                OdrzavaHigijenu od = new OdrzavaHigijenu();
                od.Higijenicar = hig;
                od.Odeljenje = ode;
                List<OdrzavaHigijenuDTO> zaduzenja = vratiZaduzenja();
                int flag = 0;
                foreach (OdrzavaHigijenuDTO x in zaduzenja)
                {
                    if (od.Higijenicar.IDOsobe == x.Higijenicar.IDOsobe && od.Odeljenje.ID == x.Odeljenje.ID)
                    {
                        //Console.WriteLine("Taj higijeničar je već zadužen za to odeljenje! Uneti drugu kombinaciju");
                        flag = 1;
                    }
                }
                if (flag == 0)
                {
                    s.Save(od);
                    s.Flush();
                }
                return flag;
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greska " + ec.Message);
            }
            return 0;
            
        }

        #endregion

        #region Izmeni Zaduzenje

        public static int izmeniZaduzenje(OdrzavaHigijenuDTO izmenjen)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                var Lista = sesija.Query<OdrzavaHigijenu>().Where(m => m.ID == izmenjen.ID).ToList();
                if (Lista.Count != 1)
                {
                    return 7;
                }
                OdrzavaHigijenu S = Lista[0];
                //OdrzavaHigijenu novo = new OdrzavaHigijenu(izmenjen);
                //OdrzavaHigijenuDTO o = new OdrzavaHigijenuDTO(S);
               // NemedicinskoOsobljeDTO h = new NemedicinskoOsobljeDTO(S.Higijenicar);
                var tmp = S.Higijenicar;
                var od = izmenjen.Odeljenje;

                if (izmenjen.Higijenicar != null)
                    S.Higijenicar = sesija.Load<NemedicinskoOsoblje>(izmenjen.Higijenicar.IDOsobe);
                else
                    S.Higijenicar = S.Higijenicar;

                if (izmenjen.Odeljenje != null)
                    S.Odeljenje = sesija.Load<Odeljenje>(izmenjen.Odeljenje.ID);
                else
                    S.Odeljenje = S.Odeljenje;



                List<OdrzavaHigijenuDTO> zaduzenja = vratiZaduzenja();
                int flag = 0;
                foreach (OdrzavaHigijenuDTO x in zaduzenja)
                {
                    if (S.Higijenicar.IDOsobe == x.Higijenicar.IDOsobe && S.Odeljenje.ID == x.Odeljenje.ID)
                    {
                        //Console.WriteLine("Taj higijeničar je već zadužen za to odeljenje! Uneti drugu kombinaciju");
                        flag = 1;
                    }
                }
                if (flag == 0)
                {
                    sesija.Save(S);
                    sesija.Flush();
                }
                return flag;
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greska " + ec.Message);
            }
            return  0;
        }

        #endregion

        #region Obrisi Zaduzenje
        public static bool obrisiZaduzenja(int idZaduzenja) 
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                OdrzavaHigijenu zaBrisanje = sesija.Load<OdrzavaHigijenu>(idZaduzenja);
                if (zaBrisanje == null)
                {
                    return false;
                }
                zaBrisanje.Higijenicar = null;
                zaBrisanje.Odeljenje = null;
                sesija.Delete(zaBrisanje);
                sesija.Flush();
                sesija.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                return false;
            }
        }

        #endregion
               
    }
}