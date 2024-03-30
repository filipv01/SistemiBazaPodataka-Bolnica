using Bolnica.DTO;
using Bolnica.Entiteti;
using DatabaseAccess;
using Microsoft.AspNetCore.Mvc;

namespace BolnicaWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PacijentController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiPacijente")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PreuzmiPacijente()
        {
            try
            {
                List<PacijentDTO> pacijenti = DataProvider.vratiSvePacijente();

                List<object> rezultat = new List<object>();



                foreach (var objekat in pacijenti)
                {
                    var jsonObjekat = new
                    {
                        IDOsobe = objekat.IDOsobe,
                        Ime = objekat.Ime,
                        Prezime = objekat.Prezime,
                        MaticniBroj = objekat.MaticniBroj,
                        TipPacijenta = objekat.TipPacijenta,
                        Adresa = objekat.Adresa,
                        VrstaIntervencije = objekat.VrstaIntervencije,
                        DatumPrijema = objekat.DatumPrijema,
                        DatumOtpusta = objekat.DatumOtpusta,
                        LekarOpstePrakse = objekat.LekarOpstePrakse?.IDOsobe + " " + objekat.LekarOpstePrakse?.Ime + " " + objekat.LekarOpstePrakse?.Prezime,
                        Odeljenje = objekat.Odeljenje?.ID + " " + objekat.Odeljenje?.Tip,
                        Stomatolog = objekat.Stomatolog?.IDOsobe + " " + objekat.Stomatolog?.Ime + " " + objekat.Stomatolog?.Prezime
                    };



                    rezultat.Add(jsonObjekat);
                }
                return new JsonResult(rezultat);
                //return new JsonResult(DataProvider.vratiSvePacijente());
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("PreuzmiPacijenteStacionare")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PreuzmiPacijenteStacionare()
        {
            try
            {
                List<PacijentDTO> pacijenti = DataProvider.vratiStacionare();



                List<object> rezultat = new List<object>();



                foreach (var objekat in pacijenti)
                {
                    var jsonObjekat = new
                    {
                        IDOsobe = objekat.IDOsobe,
                        Ime = objekat.Ime,
                        Prezime = objekat.Prezime,
                        MaticniBroj = objekat.MaticniBroj,
                        TipPacijenta = objekat.TipPacijenta,
                        DatumPrijema = objekat.DatumPrijema,
                        DatumOtpusta = objekat.DatumOtpusta,
                        LekarOpstePrakse = objekat.LekarOpstePrakse?.IDOsobe + " " + objekat.LekarOpstePrakse?.Ime + " " + objekat.LekarOpstePrakse?.Prezime,
                        Odeljenje = objekat.Odeljenje?.ID + " " + objekat.Odeljenje?.Tip
                    };



                    rezultat.Add(jsonObjekat);
                }
                return new JsonResult(rezultat);
                //return new JsonResult(DataProvider.vratiStacionare());
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                return BadRequest(e.Message);
            }
        }

      

        [HttpGet]

        [Route("PreuzmiPacijenteAmbulante")]

        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public IActionResult PreuzmiPacijenteAmbulante()

        {

            try

            {

                List<PacijentDTO> pacijenti = DataProvider.vratiSveAmb();



                List<object> rezultat = new List<object>();



                foreach (var objekat in pacijenti)

                {

                    var jsonObjekat = new

                    {

                        IDOsobe = objekat.IDOsobe,

                        Ime = objekat.Ime,

                        Prezime = objekat.Prezime,

                        MaticniBroj = objekat.MaticniBroj,

                        TipPacijenta = objekat.TipPacijenta,

                        Adresa = objekat.Adresa,

                        VrstaIntervencije = objekat.VrstaIntervencije,

                        LekarOpstePrakse = objekat.LekarOpstePrakse?.IDOsobe + " " + objekat.LekarOpstePrakse?.Ime + " " + objekat.LekarOpstePrakse?.Prezime,

                        Stomatolog = objekat.Stomatolog?.IDOsobe + " " + objekat.Stomatolog?.Ime + " " + objekat.Stomatolog?.Prezime

                    };



                    rezultat.Add(jsonObjekat);

                }

                return new JsonResult(rezultat);

                // return new JsonResult(DataProvider.vratiSveAmb());

            }

            catch (Exception e)

            {

                Console.WriteLine("Greska " + e.Message);

                return BadRequest(e.Message);

            }

        }


        [HttpGet]
        [Route("PreuzmiJednogPacijentaAmbulante/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PreuzmiJednogPacijentaAmbulante([FromRoute(Name = "id")] int id)
        {
            try
            {
                var pacijent = DataProvider.vratiAmb(id);

                if (pacijent == null) return BadRequest("Nije izabran pacijent ambulante!");

                var rezultat = new
                {
                    IDOsobe = pacijent.IDOsobe,
                    Ime = pacijent.Ime,
                    Prezime = pacijent.Prezime,
                    MaticniBroj = pacijent.MaticniBroj,
                    TipPacijenta = pacijent.TipPacijenta,
                    Adresa = pacijent.Adresa,
                    VrstaIntervencije = pacijent.VrstaIntervencije,
                    LekarOpstePrakse = pacijent.LekarOpstePrakse?.IDOsobe + " " + pacijent.LekarOpstePrakse?.Ime + " " + pacijent.LekarOpstePrakse?.Prezime,
                    Stomatolog = pacijent.Stomatolog?.IDOsobe + " " + pacijent.Stomatolog?.Ime + " " + pacijent.Stomatolog?.Prezime
                };



                return new JsonResult(rezultat);
                //return new JsonResult(DataProvider.vratiAmb(id));
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("PreuzmiJednogPacijentaStacionara/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PreuzmiJednogPacijentaStacionara([FromRoute(Name = "id")] int id)
        {
            try
            {
                var pacijent = DataProvider.vratiStacionara(id);

                if (pacijent == null) return BadRequest("Nije izabran pacijent stacionara!");

                var rezultat = new
                {
                    IDOsobe = pacijent.IDOsobe,
                    Ime = pacijent.Ime,
                    Prezime = pacijent.Prezime,
                    MaticniBroj = pacijent.MaticniBroj,
                    TipPacijenta = pacijent.TipPacijenta,
                    DatumPrijema = pacijent.DatumPrijema,
                    DatumOtpusta = pacijent.DatumOtpusta,
                    LekarOpstePrakse = pacijent.LekarOpstePrakse?.IDOsobe + " " + pacijent.LekarOpstePrakse?.Ime + " " + pacijent.LekarOpstePrakse?.Prezime,
                    Odeljenje = pacijent.Odeljenje?.ID + " " + pacijent.Odeljenje?.Tip
                };




                return new JsonResult(rezultat);
                //return new JsonResult(DataProvider.vratiStacionara(id));
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                return BadRequest(e.Message);
            }
        }

       

        [HttpPut]
        [Route("IzmeniPacijentaAmbulante/{idlop?}/{idstom?}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult IzmeniPacijentaAmbulante([FromBody] PacijentDTO pac, int idlop=0, int idstom = 0)
        {
            try
            {
                var stm = new MedicinskoOsobljeDTO();
                if (idstom == 0)
                    stm = null;
                else
                {
                    stm = DataProvider.vratiStomatologa(idstom);
                    if (stm == null) return BadRequest("Morate izabrati stomatologa");
                }                  
                                
                
                pac.Stomatolog = stm;

                var op = new MedicinskoOsobljeDTO();

                if (idlop != 0)
                {
                    op = DataProvider.vratilekaraOP(idlop);
                    if (op == null) return BadRequest("Morate izabrati lekara opste prakse");
                }
                    
                else
                    op = null;

                pac.LekarOpstePrakse = op;

                bool x = DataProvider.izmeniAmb(pac);
                if (x == false) return BadRequest("Neispravan ID!");
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        [Route("IzmeniPacijentaStacionara/{idlop?}/{idOd?}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult IzmeniPacijentaStacionara([FromBody] PacijentDTO pac, int idlop=0, int idOd=0)
        {
            try
            {
                
                if(idlop!=0)
                {
                    var op = DataProvider.vratilekaraOP(idlop);
                    if (op == null) return BadRequest("Morate izabrati lekara opste prakse");
                    pac.LekarOpstePrakse = op;
                }
                else pac.LekarOpstePrakse=null;
                if (idOd != 0)
                {
                    var odeljenje = DataProvider.vratiOd(idOd);
                    if (odeljenje == null) return BadRequest("Morate izabrati postojece odeljenje");
                    pac.Odeljenje = odeljenje;
                }
                else pac.Odeljenje = null;
               
                bool x = DataProvider.izmeniStacionara(pac);
                if (x == false) return BadRequest("Neispravan ID!");
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        [Route("IzbrisiPacijentaStacionara/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult IzbrisiPacijentaStacionara([FromRoute(Name = "id")] int id)
        {
            try
            {
                bool p = DataProvider.obrisiStacionara(id);
                if (p == false)
                {
                    return BadRequest("Nije pacijent stacionara!");
                }
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        [Route("IzbrisiPacijentaAmbulante/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult IzbrisiPacijentaAmbulante([FromRoute(Name = "id")] int id)
        {
            try
            {
                bool p = DataProvider.obrisiAmbulanta(id);
                if (p == false)
                {
                    return BadRequest("Nije pacijent ambulante!");
                }
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                return BadRequest(e.Message);
            }
        }
        [HttpPost]
        [Route("DodajPacijentaStacionara/{idlop}/{idOd}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajPacijentaStacionara(int idlop, int idOd, [FromBody] PacijentDTO p)
        {
            int flag = 0;
            try
            {
                MedicinskoOsobljeDTO medi = DataProvider.vratilekaraOP(idlop);
                if (medi == null) return BadRequest("Morate izabrati lekara opste prakse");
                p.LekarOpstePrakse = medi;
                OdeljenjeDTO od = DataProvider.vratiOd(idOd);
                if (od == null) return BadRequest("Morate izabrati postojece odeljenje");
                p.Odeljenje = od;

                flag= DataProvider.dodajPacijentaS(p);
                if (flag == 1)
                {
                    return BadRequest("Osoba sa ovim maticnim brojem vec postoji!");
                }
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                return BadRequest(e.Message);
            }
        }
        [HttpPost]
        [Route("DodajPacijentaAmbulante/{idlop}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajPacijentaAmbulante(int idlop, int stomID, [FromBody] PacijentDTO p)
        {
            int flag = 0;
            try
            {
                MedicinskoOsobljeDTO medi = DataProvider.vratilekaraOP(idlop);
                if (medi == null) return BadRequest("Morate izabrati lekara opste prakse");
                p.LekarOpstePrakse = medi;
                MedicinskoOsobljeDTO st = DataProvider.vratiStomatologa(stomID);
                if (st == null) return BadRequest("Morate izabrati postojece odeljenje");
                p.Stomatolog=st;
                flag = DataProvider.dodajPacijentaA(p);
                if (flag == 1)
                {
                    return BadRequest("Osoba sa ovim maticnim brojem vec postoji!");
                }
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                return BadRequest(e.Message);
            }
        }
    }
}
