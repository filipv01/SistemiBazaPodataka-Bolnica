using Bolnica.DTO;
using Bolnica.Entiteti;
using DatabaseAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BolnicaWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StomatoloskaStolicaController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiStolice")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PreuzmiStolice()
        {
            try
            {
                List<StomatoloskaStolicaDTO> stolice = DataProvider.vratiStolice();
                List<MedicinskoOsobljeDTO> stomatolozi = DataProvider.vratiStomatologe();



                List<object> rezultat = new List<object>();



                foreach (var objekat in stolice)
                {



                    for (int i = 0; i < stomatolozi.Count; i++)
                    {
                        if (stomatolozi[i].Stolica?.ID == objekat.ID)
                        {
                            objekat.Stomatolozi?.Add(stomatolozi[i]);
                        }



                    }
                    var jsonObjekat = new
                    {
                        Id = objekat.ID,
                        Proizvodjac = objekat.Proizvodjac,
                        DatumProizvodnje = objekat.DatumProizvodnje,
                        Tehnicar = objekat.TehnickoOdrzavanje?.IDOsobe + " " + objekat.TehnickoOdrzavanje?.Ime + " " + objekat.TehnickoOdrzavanje?.Prezime,
                        Stomatolozi = objekat.Stomatolozi?.Select(x => x.IDOsobe + " " + x.Ime + x.Prezime).ToList()
                    };



                    rezultat.Add(jsonObjekat);
                }
                return new JsonResult(rezultat);
                //return new JsonResult(DataProvider.vratiStolice());
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("PreuzmiJednuStolicu/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult getJednuStolicu([FromRoute(Name = "id")] int id)
        {
            try
            {
                var stolica = DataProvider.vratiStolicu(id);
                List<MedicinskoOsobljeDTO> stomatolozi = DataProvider.vratiStomatologe();

                if (stolica == null) return BadRequest("Nije izabrana stolica!");


                for (int i = 0; i < stomatolozi.Count; i++)
                {
                    if (stomatolozi[i].Stolica?.ID == stolica.ID)
                    {
                        stolica.Stomatolozi?.Add(stomatolozi[i]);
                    }



                }
                var rezultat = new
                {
                    Id = stolica.ID,
                    Proizvodjac = stolica.Proizvodjac,
                    DatumProizvodnje = stolica.DatumProizvodnje,
                    Tehnicar = stolica.TehnickoOdrzavanje?.IDOsobe + " " + stolica.TehnickoOdrzavanje?.Ime + " " + stolica.TehnickoOdrzavanje?.Prezime,
                    Stomatolozi = stolica.Stomatolozi?.Select(x => x.IDOsobe + " " + x.Ime + " " + x.Prezime).ToList()
                };





                return new JsonResult(rezultat);
                //return new JsonResult(DataProvider.vratiStolicu(id));
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("DodajStolicu/{idtehn}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajStolicu(int idtehn, [FromBody] StomatoloskaStolicaDTO s)
        {
            try
            {
                var tehnicar = DataProvider.vratiTehnicara(idtehn);
                if(tehnicar==null) return BadRequest("Morate izabrati nekog od postojecih tehnicara");
              
                s.TehnickoOdrzavanje=tehnicar;
                DataProvider.dodajStolicu(s);
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        [Route("IzmeniStolicu/{idtehn?}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult IzmeniStolicu([FromBody] StomatoloskaStolicaDTO s, int idtehn = 0)
        {
            try
            {
                var tehnicar = new NemedicinskoOsobljeDTO();
                if (idtehn == 0)
                    tehnicar = null;
                else
                {
                    tehnicar = DataProvider.vratiTehnicara(idtehn);
                    if (tehnicar==null) return BadRequest("Morate izabrati nekog od postojecih tehnicara");
                }
                  
                s.TehnickoOdrzavanje = tehnicar;

                DataProvider.izmeniStolicu(s);
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        [Route("IzbrisiStolicu/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult IzbrisiSpecijalistu([FromRoute(Name = "id")] int id)
        {
            try
            {
                bool p = DataProvider.obrisiStolice(id);
                if (!p)
                {
                    return BadRequest("Stolica sa ovim ID-jem ne postoji!");
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
