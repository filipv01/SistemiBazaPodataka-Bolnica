using Bolnica.DTO;
using DatabaseAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BolnicaWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MedicinskoOsobljeController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiSpecijaliste")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PreuzmiSpecijaliste()
        {
            try
            {
                List<MedicinskoOsobljeDTO> specijalisti = DataProvider.vratiSpecijaliste();
                List<OdeljenjeDTO> odeljenja = DataProvider.vratiOdeljenja();

                List<object> rezultat = new List<object>();
                List<int> pom = new List<int>();
                foreach (var objekat in specijalisti)
                {
                    for (int i = 0; i < odeljenja.Count; i++)
                    {
                        if (odeljenja[i].Specijalista?.IDOsobe == objekat.IDOsobe)
                            objekat.Odeljenja?.Add(odeljenja[i]);
                    }

                    var jsonObjekat = new
                    {
                        IDOsobe = objekat.IDOsobe,
                        Ime = objekat.Ime,
                        Prezime = objekat.Prezime,
                        MaticniBroj = objekat.MaticniBroj,
                        GodineRadnogStaza = objekat.GodineRadnogStaza,
                        Specijalnost = objekat.Specijalnost,
                        TipMedOsoblja = objekat.TipMedOsoblja,
                        Odeljenja = objekat.Odeljenja?.Select(s => s.Tip).ToList()
                    };

                    rezultat.Add(jsonObjekat);
                }
                return new JsonResult(rezultat);
                //return new JsonResult(DataProvider.vratiSpecijaliste());
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("PreuzmiJednogSpecijalistu/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult getJednogSpecijalistu([FromRoute(Name = "id")] int id)
        {
            try
            {
                List<OdeljenjeDTO> odeljenja = DataProvider.vratiOdeljenja();

                var specijalista = DataProvider.vratiSpecijalistu(id);
                if (specijalista == null) return BadRequest("Nije izabran specijalista!");

                for (int i = 0; i < odeljenja.Count; i++)
                {
                    if (odeljenja[i].Specijalista?.IDOsobe == id)
                        specijalista.Odeljenja?.Add(odeljenja[i]);
                }
                var rezultat = new
                {
                    IDOsobe = specijalista.IDOsobe,
                    Ime = specijalista.Ime,
                    Prezime = specijalista.Prezime,
                    MaticniBroj = specijalista.MaticniBroj,
                    GodineRadnogStaza = specijalista.GodineRadnogStaza,
                    Specijalnost = specijalista.Specijalnost,
                    TipMedOsoblja = specijalista.TipMedOsoblja,
                    Odeljenja = specijalista.Odeljenja?.Select(s => s.Tip).ToList()
                };

                return new JsonResult(rezultat);
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("PreuzmiLekareOpstePrakse")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PreuzmiLekareOpstePrakse()
        {
            try
            {
                List<MedicinskoOsobljeDTO> op = DataProvider.vratiOP();
                List<PacijentDTO> pacijenti = DataProvider.vratiSvePacijente();

                List<object> rezultat = new List<object>();
                List<int> pom = new List<int>();
                foreach (var objekat in op)
                {
                    for (int i = 0; i < pacijenti.Count; i++)
                    {
                        if (pacijenti[i].LekarOpstePrakse?.IDOsobe == objekat.IDOsobe)
                            objekat.Pacijenti?.Add(pacijenti[i]);
                    }

                    var jsonObjekat = new
                    {
                        IDOsobe = objekat.IDOsobe,
                        Ime = objekat.Ime,
                        Prezime = objekat.Prezime,
                        MaticniBroj = objekat.MaticniBroj,
                        GodineRadnogStaza = objekat.GodineRadnogStaza,
                        BrojOrdinacije = objekat.BrojOrdinacije,
                        TipMedOsoblja = objekat.TipMedOsoblja,
                        Pacijenti = objekat.Pacijenti?.Select(s => s.IDOsobe + " "+s.Ime + " "+ s.Prezime).ToList()
                    };

                    rezultat.Add(jsonObjekat);
                }
                return new JsonResult(rezultat);
                //return new JsonResult(DataProvider.vratiOP());
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("PreuzmiJednogLekaraOP/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult getJednogLekara([FromRoute(Name = "id")] int id)
        {
            try
            {
                //MedicinskoOsobljeDTO op = DataProvider.vratilekaraOP(id);
                List<PacijentDTO> pacijenti = DataProvider.vratiSvePacijente();
                var op = DataProvider.vratilekaraOP(id);
                if (op == null) return BadRequest("Nije izabran lekar opste prakse!");


                for (int i = 0; i < pacijenti.Count; i++)
                    {
                        if (pacijenti[i].LekarOpstePrakse?.IDOsobe == id)
                            op.Pacijenti?.Add(pacijenti[i]);
                    }

                    var rezultat = new
                    {
                        IDOsobe = op.IDOsobe,
                        Ime = op.Ime,
                        Prezime = op.Prezime,
                        MaticniBroj = op.MaticniBroj,
                        GodineRadnogStaza = op.GodineRadnogStaza,
                        BrojOrdinacije = op.BrojOrdinacije,
                        TipMedOsoblja = op.TipMedOsoblja,
                        Pacijenti = op.Pacijenti?.Select(s => s.IDOsobe + " " + s.Ime + " " + s.Prezime).ToList()
                    };                  
                
                return new JsonResult(rezultat);
                // return new JsonResult(DataProvider.vratilekaraOP(id));
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("PreuzmiStomatologe")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PreuzmiStomatologe()
        {
            try
            {
                List<MedicinskoOsobljeDTO> stomatolozi = DataProvider.vratiStomatologe();
                List<PacijentDTO> pacijenti = DataProvider.vratiSveAmb();
                List<StomatoloskaStolicaDTO> stolice = DataProvider.vratiStolice();

                List<object> rezultat = new List<object>();
              
                foreach (var objekat in stomatolozi)
                {
                    for (int i = 0; i < pacijenti.Count; i++)
                    {
                        if (pacijenti[i].Stomatolog?.IDOsobe == objekat.IDOsobe)
                            objekat.Pacijenti?.Add(pacijenti[i]);
                    }
                    for (int i = 0; i < stolice.Count; i++)
                    {
                        if (stolice[i].Stomatolozi.Contains(objekat))
                        {
                            objekat.Stolica = stolice[i];
                        }
                        
                    }

                    var jsonObjekat = new
                    {
                        IDOsobe = objekat.IDOsobe,
                        Ime = objekat.Ime,
                        Prezime = objekat.Prezime,
                        MaticniBroj = objekat.MaticniBroj,
                        GodineRadnogStaza = objekat.GodineRadnogStaza,
                        Smena = objekat.Smena,
                        TipMedOsoblja = objekat.TipMedOsoblja,
                        Pacijenti = objekat.Pacijenti?.Select(s => s.IDOsobe + " " + s.Ime + " " + s.Prezime).ToList(),
                        Stolica = objekat.Stolica?.Proizvodjac    
                    };

                    rezultat.Add(jsonObjekat);
                }
                return new JsonResult(rezultat);
                //return new JsonResult(DataProvider.vratiStomatologe());
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("PreuzmiJednogStomatologa/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult getJednogStomatologa([FromRoute(Name = "id")] int id)
        {
            try
            {
                //MedicinskoOsobljeDTO stomatolog = DataProvider.vratiStomatologa(id);
                List<PacijentDTO> pacijenti = DataProvider.vratiSveAmb();
                List<StomatoloskaStolicaDTO> stolice = DataProvider.vratiStolice();
                var stomatolog = DataProvider.vratiStomatologa(id);
                if (stomatolog == null) return BadRequest("Nije izabran stomatolog!");

                for (int i = 0; i < pacijenti.Count; i++)
                    {
                        if (pacijenti[i].Stomatolog?.IDOsobe == id)
                            stomatolog.Pacijenti?.Add(pacijenti[i]);
                    }
                    for (int i = 0; i < stolice.Count; i++)
                    {
                        if (stolice[i].Stomatolozi.Contains(stomatolog))
                        {
                            stomatolog.Stolica = stolice[i];
                        }

                    }
                    var rezultat = new
                    {
                        IDOsobe = stomatolog.IDOsobe,
                        Ime = stomatolog.Ime,
                        Prezime = stomatolog.Prezime,
                        MaticniBroj = stomatolog.MaticniBroj,
                        GodineRadnogStaza = stomatolog.GodineRadnogStaza,
                        Smena = stomatolog.Smena,
                        TipMedOsoblja = stomatolog.TipMedOsoblja,
                        Pacijenti = stomatolog.Pacijenti?.Select(s => s.IDOsobe + " " + s.Ime + " " + s.Prezime).ToList(),
                        Stolica = stomatolog.Stolica?.Proizvodjac    //Select(s => s.IDO + " " + s.Ime + " " + s.Prezime)
                    };
                                  
                return new JsonResult(rezultat);

            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("DodajSpecijalistu")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajSpecijalistu([FromBody] MedicinskoOsobljeDTO zap)
        {
            int flag=0;
            try
            {
                flag = DataProvider.dodajSpecijalistu(zap);
                if(flag==1)
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
        [Route("DodajLekaraOpstePrakse")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajLekaraOpstePrakse([FromBody] MedicinskoOsobljeDTO zap)
        {
            int flag = 0;
            try
            {
                flag=DataProvider.dodajLekaraOpstePrakse(zap);
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
        [Route("DodajStomatologa/{idStolice}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajStomatologa(int idStolice, [FromBody] MedicinskoOsobljeDTO zap)
        {
            int flag = 0;
            try
            {
                var stolica = new StomatoloskaStolicaDTO();
                stolica = DataProvider.vratiStolicu(idStolice);
                if (stolica == null) return BadRequest("Morate izabrati stolicu na kojoj ce novi stomatolog raditi!");
                zap.Stolica = stolica;
                flag = DataProvider.dodajStomatologa(zap);
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


        [HttpPut]
        [Route("IzmeniSpecijalistu")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult IzmeniSpecijalistu([FromBody] MedicinskoOsobljeDTO zap)
        {
            try
            {
              
                bool x = DataProvider.izmeniSpec(zap);
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
        [Route("IzmeniLekaraOpstePrakse")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult IzmeniLekaraOpstePrakse([FromBody] MedicinskoOsobljeDTO zap)
        {
            try
            {
               bool x= DataProvider.izmeniOP(zap);
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
        [Route("IzmeniStomatologa/{idStolice?}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult IzmeniStomatologa([FromBody] MedicinskoOsobljeDTO zap, int idStolice = 0)
        {
            try
            {
                var stolica = new StomatoloskaStolicaDTO();
                if (idStolice == 0)
                    stolica = null;
                else
                {
                    stolica = DataProvider.vratiStolicu(idStolice);
                    if (stolica == null) return BadRequest("Morate izabrati stolicu na kojoj ce ovaj stomatolog raditi!");
                }
               
                zap.Stolica = stolica;
                bool x = DataProvider.izmeniStomatologa(zap);
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
        [Route("IzbrisiSpecijalistu/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult IzbrisiSpecijalistu([FromRoute(Name = "id")] int id)
        {
            try
            {
                bool p = DataProvider.obrisiSpec(id);
                if (p==false)
                {
                    return BadRequest("Nije izabran specijalista!");
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
        [Route("IzbrisiLekaraOpstePrakse/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult IzbrisiLekaraOpstePrakse([FromRoute(Name = "id")] int id)
        {
            try
            {
                bool p = DataProvider.obrisiOP(id);
                if (p == false)
                {
                    return BadRequest("Nije izabran lekar opste prakse!");
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
        [Route("IzbrisiStomatologa/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult IzbrisiStomatologa([FromRoute(Name = "id")] int id)
        {
            try
            {
                bool p = DataProvider.obrisiStomatologa(id);
                if (p == false)
                {
                    return BadRequest("Nije izabran stomatolog!");
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

