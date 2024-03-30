using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Bolnica.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseAccess;
using Bolnica.Entiteti;
using System.Linq.Expressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BolnicaWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NemedicinskoOsobljeController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiTehnickoOsoblje")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public IActionResult getTehnickoOsoblje()
        {
            try
            {
                List<NemedicinskoOsobljeDTO> tehnicari = DataProvider.vratiSveTehnicare();
                List<StomatoloskaStolicaDTO> stolice = DataProvider.vratiStolice();

                List<object> rezultat = new List<object>();
                List<int> pom = new List<int>();
                foreach (var objekat in tehnicari)
                {
                    for (int i = 0; i < stolice.Count; i++)
                    {
                        if (stolice[i].TehnickoOdrzavanje?.IDOsobe == objekat.IDOsobe)
                            objekat.Stolice?.Add(stolice[i]);
                    }
                   
                    var jsonObjekat = new
                    {
                        IDOsobe = objekat.IDOsobe,
                        Ime = objekat.Ime,
                        Prezime = objekat.Prezime,
                        MaticniBroj = objekat.MaticniBroj,
                        TipNemedOsoblja = objekat.TipNemedOsoblja,
                        Struka = objekat.Struka,
                        Stolice = objekat.Stolice?.Select(s => s.ID).ToList()
                };

                    rezultat.Add(jsonObjekat);
                }
                return new JsonResult(rezultat);
                //return new JsonResult(DataProvider.vratiSveTehnicare());
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("PreuzmiHigijenicare")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]



        public IActionResult getHigijenicare()
        {
            try
            {
                List<NemedicinskoOsobljeDTO> higijenicari = DataProvider.vratiHigijenicare();

                List<object> rezultat = new List<object>();

                foreach (var objekat in higijenicari)
                {

                    var jsonObjekat = new
                    {
                        IDOsobe = objekat.IDOsobe,
                        Ime = objekat.Ime,
                        Prezime = objekat.Prezime,
                        MaticniBroj = objekat.MaticniBroj,
                        TipNemedOsoblja = objekat.TipNemedOsoblja,

                    };

                    rezultat.Add(jsonObjekat);
                }
                return new JsonResult(rezultat);
                //return new JsonResult(DataProvider.vratiHigijenicare());
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("PreuzmiJednoTehnickoOsoblje/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult getJednoTehnickoOsoblje([FromRoute(Name = "id")] int id)
        {
            try
            {
                List<StomatoloskaStolicaDTO> stolice = DataProvider.vratiStolice();



                var tehnicar = DataProvider.vratiTehnicara(id);



                if (tehnicar == null)
                    return BadRequest("Nije izabrano tehnicko osoblje!");



                for (int i = 0; i < stolice.Count; i++)
                {
                    if (stolice[i].TehnickoOdrzavanje?.IDOsobe == id)
                        tehnicar.Stolice?.Add(stolice[i]);
                }
                var rezultat = new
                {
                    IDOsobe = tehnicar.IDOsobe,
                    Ime = tehnicar.Ime,
                    Prezime = tehnicar.Prezime,
                    MaticniBroj = tehnicar.MaticniBroj,
                    TipNemedOsoblja = tehnicar.TipNemedOsoblja,
                    Struka = tehnicar.Struka,
                    Stolice = tehnicar.Stolice?.Select(s => s.ID).ToList()
                };


                return new JsonResult(rezultat);
                // return new JsonResult(tehnicar);
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("PreuzmiJednogHigijenicara/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult getJednogHigijenicara([FromRoute(Name = "id")] int id)
        {
            try
            {
                var higijenicar = DataProvider.vratiHigijenicara(id);


                if ( higijenicar == null)
                    return BadRequest("Nije izabran higijenicar!");

                var rezultat = new
                {
                    IDOsobe = higijenicar.IDOsobe,
                    Ime = higijenicar.Ime,
                    Prezime = higijenicar.Prezime,
                    MaticniBroj = higijenicar.MaticniBroj,
                    TipNemedOsoblja = higijenicar.TipNemedOsoblja,


                };

                return new JsonResult(rezultat);
                // return new JsonResult(DataProvider.vratiHigijenicara(id));
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        [Route("PromeniHigijenicara")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult PromeniHigijenicara([FromBody] NemedicinskoOsobljeDTO hig)
        {
            try
            {
               bool x = DataProvider.izmeniHigijenicara(hig);
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
        [Route("PromeniTehnickoOsoblje")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult PromeniTehnickoOsoblje([FromBody] NemedicinskoOsobljeDTO teh, [FromQuery] List<int>? idStolice)
        {
            try
            {
                var stolica = new StomatoloskaStolicaDTO();
                
                List<StomatoloskaStolicaDTO> stolice = new List<StomatoloskaStolicaDTO>();
                if (idStolice.Count != 0)
                {
                    for (int i = 0; i < idStolice.Count; i++)
                    {
                        stolice.Add(DataProvider.vratiStolicu(idStolice[i]));
                        teh.Stolice.Add(stolice[i]);

                        //var tehnicar = new NemedicinskoOsobljeDTO();
                        
                        //tehnicar = DataProvider.vratiTehnicara(idtehn);
                        stolice[i].TehnickoOdrzavanje = teh;

                       DataProvider.izmeniStolicu(stolice[i]);
                    }
                }
                else
                    teh.Stolice = null;

                bool x = DataProvider.izmeniTehnicara(teh);
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
        [Route("IzbrisiHigijenicara/{idHigijenicar}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult IzbrisiHigijenicara([FromRoute(Name = "idHigijenicar")] int idHigijenicar)
        {
            try
            {
                bool p = DataProvider.obrisiHigijenicara(idHigijenicar);
                if (p == false)
                {
                    return BadRequest("Nije izabran higijenicar!");
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
        [Route("IzbrisiTehnickoOsoblje/{idTehnicar}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult IzbrisiTehnickoOsoblje([FromRoute(Name = "idTehnicar")] int idTehnicar)
        {
            try
            {
                bool p = DataProvider.obrisiTehnicara(idTehnicar);
                if (p == false)
                {
                    return BadRequest("Nije izabrano tehnicko osoblje!");
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
        [Route("DodajHigijenicara")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajHigijenicara([FromBody] NemedicinskoOsobljeDTO nemed)
        {
            int flag = 0;
            try
            {
                flag = DataProvider.dodajNovogHigijenicara(nemed);
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
        [Route("DodajTehnickoOsoblje")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajTehnickoOsoblje([FromBody] NemedicinskoOsobljeDTO nemed)
        {
            int flag = 0;   
            try
            {
                flag=DataProvider.dodajNovoTehnickoOsoblje(nemed);
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
