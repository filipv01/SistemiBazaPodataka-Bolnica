using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Bolnica.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseAccess;

namespace BolnicaWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OdeljenjeController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiOdeljenja")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PreuzmiOdeljenja()
        {
            try
            {
                List<OdeljenjeDTO> odeljenja = DataProvider.vratiOdeljenja();
                List<MedicinskoOsobljeDTO> specijaliste = DataProvider.vratiSpecijaliste();

                List<object> rezultat = new List<object>();
               
                foreach (var objekat in odeljenja)
                {

                        for (int i = 0; i < specijaliste.Count; i++)
                        {
                            if (specijaliste[i].Odeljenja.Contains(objekat))
                            {
                                objekat.Specijalista = specijaliste[i];
                            }

                        }
                    var jsonObjekat = new
                    {
                        Id = objekat.ID,
                        Sifra = objekat.Sifra,
                        Tip = objekat.Tip,
                        DatumIzgradnje = objekat.DatumIzgradnje,
                        Specijalista = objekat.Specijalista?.IDOsobe + " " + objekat.Specijalista?.Ime + " " + objekat.Specijalista?.Prezime
                    };

                    rezultat.Add(jsonObjekat);
                }
                return new JsonResult(rezultat);
                // return new JsonResult(DataProvider.vratiSvaOdeljenja());
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("PreuzmiJednoOdeljenje/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PreuzmiJednoOdeljenje([FromRoute(Name = "id")] int id)
        {
            try
            {
                var odeljenje = DataProvider.vratiOd(id);
                List<MedicinskoOsobljeDTO> specijaliste = DataProvider.vratiSpecijaliste();

                if (odeljenje == null) return BadRequest("Nije izabrano odeljenje!");

                for (int i = 0; i < specijaliste.Count; i++)
                    {
                        if (specijaliste[i].Odeljenja.Contains(odeljenje))
                        {
                            odeljenje.Specijalista = specijaliste[i];
                        }

                    }
                    var rezultat = new
                    {
                        Id = odeljenje.ID,
                        Sifra = odeljenje.Sifra,
                        Tip = odeljenje.Tip,
                        DatumIzgradnje = odeljenje.DatumIzgradnje,
                        Specijalista = odeljenje.Specijalista?.IDOsobe + " " + odeljenje.Specijalista?.Ime + " " + odeljenje.Specijalista?.Prezime
                    };

                    
                return new JsonResult(rezultat);

                //return new JsonResult(DataProvider.vratiOd(id));
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        [Route("IzbrisiOdeljenje/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult IzbrisiOdeljenje([FromRoute(Name = "id")] int id)
        {
            try
            {
                bool p = DataProvider.obrisiOdeljenje(id);
                if (!p)
                {
                    return BadRequest("Odeljenje sa ovim ID-jem ne postoji!");
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
        [Route("PromeniOdeljenje/{specijalistaID?}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult PromeniOdeljenje([FromBody] OdeljenjeDTO od, int specijalistaID=0)
        {
            try
            {
                if(specijalistaID==0)
                {
                    od.Specijalista = null;
                }
                else
                {
                    var spec = DataProvider.vratiSpecijalistu(specijalistaID);
                    if (spec == null) return BadRequest("Neispravan id specijaliste!");
                    od.Specijalista = spec;
                }
             
                DataProvider.izmeniOdeljenje(od);
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                return BadRequest(e.Message);
            }
        }


        [HttpPost]
        [Route("DodajOdeljenje/{specijalistaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajOdeljenje(int specijalistaID, [FromBody] OdeljenjeDTO o)
        {
            int flag = 0;
            try
            {
                var spec = DataProvider.vratiSpecijalistu(specijalistaID);
                if (spec == null) return BadRequest("Neispravan id specijaliste!");
                o.Specijalista = spec;
                flag = DataProvider.dodajOdeljenje(o);
                if (flag == 1)
                {
                    return BadRequest("Odeljenje sa ovom sifrom vec postoji!");
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
