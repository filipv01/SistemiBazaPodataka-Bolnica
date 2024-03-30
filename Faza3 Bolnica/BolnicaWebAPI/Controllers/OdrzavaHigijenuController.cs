using Bolnica.DTO;
using Bolnica.Entiteti;
using DatabaseAccess;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace BolnicaWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OdrzavaHigijenuController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiZaduzenja")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]



        public IActionResult PreuzmiZaduzenja()
        {
            try
            {
                List<OdrzavaHigijenuDTO> zaduzenja = DataProvider.vratiZaduzenja();
                List<MedicinskoOsobljeDTO> specijaliste = DataProvider.vratiSpecijaliste();



                List<object> rezultat = new List<object>();



                foreach (var objekat in zaduzenja)
                {
                    for (int i = 0; i < specijaliste.Count; i++)
                    {
                        if (specijaliste[i].Odeljenja.Contains(objekat.Odeljenje))
                        {
                            objekat.Odeljenje.Specijalista = specijaliste[i];
                            break;
                        }
                    }
                    var jsonObjekat = new
                    {
                        id = objekat.ID,
                        Higijenicar = new
                        {
                            IDOsobe = objekat.Higijenicar.IDOsobe,
                            Ime = objekat.Higijenicar.Ime,
                            Prezime = objekat.Higijenicar.Prezime,
                            MaticniBroj = objekat.Higijenicar.MaticniBroj,
                            TipNemedOsoblja = objekat.Higijenicar.TipNemedOsoblja,
                        },
                        Odeljenje = new
                        {
                            Id = objekat.Odeljenje.ID,
                            Sifra = objekat.Odeljenje.Sifra,
                            Tip = objekat.Odeljenje.Tip,
                            DatumIzgradenje = objekat.Odeljenje.DatumIzgradnje,
                            Specijalista = objekat.Odeljenje.Specijalista?.IDOsobe + " " + objekat.Odeljenje.Specijalista?.Ime + " " + objekat.Odeljenje.Specijalista?.Prezime
                        }
                    };

                    rezultat.Add(jsonObjekat);
                }

                return new JsonResult(rezultat);
                //return new JsonResult(DataProvider.vratiZaduzenja());
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("PreuzmiJednoZaduzenje/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PreuzmiJednoZaduzenje([FromRoute(Name = "id")] int id)
        {
            try
            {
                var zaduzenje = DataProvider.vratiZaduzenje(id);
                List<MedicinskoOsobljeDTO> specijaliste = DataProvider.vratiSpecijaliste();

                if (zaduzenje == null) return BadRequest("Nije izabrano zaduzenje!");


                for (int i = 0; i < specijaliste.Count; i++)
                {
                    if (specijaliste[i].Odeljenja.Contains(zaduzenje.Odeljenje))
                    {
                        zaduzenje.Odeljenje.Specijalista = specijaliste[i];
                    }



                }

                var rezultat = new
                {
                    id = zaduzenje.ID,
                    Higijenicar = new
                    {
                        IDOsobe = zaduzenje.Higijenicar.IDOsobe,
                        Ime = zaduzenje.Higijenicar.Ime,
                        Prezime = zaduzenje.Higijenicar.Prezime,
                        MaticniBroj = zaduzenje.Higijenicar.MaticniBroj,
                        TipNemedOsoblja = zaduzenje.Higijenicar.TipNemedOsoblja,
                    },
                    Odeljenje = new
                    {
                        Id = zaduzenje.Odeljenje.ID,
                        Sifra = zaduzenje.Odeljenje.Sifra,
                        Tip = zaduzenje.Odeljenje.Tip,
                        DatumIzgradenje = zaduzenje.Odeljenje.DatumIzgradnje,
                        Specijalista = zaduzenje.Odeljenje.Specijalista?.IDOsobe + " " + zaduzenje.Odeljenje.Specijalista?.Ime + " " + zaduzenje.Odeljenje.Specijalista?.Prezime
                    }
                };



                return new JsonResult(rezultat);
                //return new JsonResult(DataProvider.vratiZaduzenje(id));
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                return BadRequest(e.Message);
            }
        }


        [HttpPut]
        [Route("PromeniZaduzenje/{idHigijenicara?}/{idOdeljenja?}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult PromeniZaduzenje( [FromBody] OdrzavaHigijenuDTO odr, int idOdeljenja=0, int idHigijenicara=0)
        {
            try
            {
                var odeljenje = new OdeljenjeDTO();

                var hig = new NemedicinskoOsobljeDTO();

                if (idOdeljenja != 0)
                    odeljenje = DataProvider.vratiOd(idOdeljenja);
                else odeljenje = null;
                if(idHigijenicara!=0)
                    hig = DataProvider.vratiHigijenicara(idHigijenicara);
                else hig = null;

                odr.Odeljenje = odeljenje;

                odr.Higijenicar = hig;

                int m = DataProvider.izmeniZaduzenje(odr);

                if (m == 1)
                    return BadRequest("Uneti drugu kombinaciju");
                else if (m == 7)
                    return BadRequest("Neispravan ID");
                else
                    return Ok();

            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);

                return BadRequest(e.Message);
            }

        }

        [HttpDelete]
        [Route("IzbrisiZaduzenje/{idZaduzenja}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult IzbrisiZaduzenje([FromRoute(Name = "idZaduzenja")] int idZaduzenja)
        {
            try
            {
                bool p = DataProvider.obrisiZaduzenja(idZaduzenja);
                if (p==false)
                {
                    return BadRequest("Zaduzenje sa ovim ID-jem ne postoji!");
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
        [Route("DodajZaduzenje/{idOdeljenja}/{idHigijenicara}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajZaduzenje(int idOdeljenja, int idHigijenicara)
        {
            try
            {

                NemedicinskoOsobljeDTO ne = DataProvider.vratiHigijenicara(idHigijenicara);
                if (ne == null) return BadRequest("Neispravan higijenicar");
                OdeljenjeDTO odeljenje = DataProvider.vratiOd(idOdeljenja);
                if (odeljenje == null) return BadRequest("Nepostojece odeljenje");
                OdrzavaHigijenuDTO od = new OdrzavaHigijenuDTO();
                if (ne.TipNemedOsoblja == "Higijenicar")
                {
                    od.Higijenicar = ne;
                    od.Odeljenje = odeljenje;
                    int m= DataProvider.dodajZaduzenje(od);
                    if(m==0)
                    return Ok();
                    else return BadRequest(" Uneti drugu kombinaciju!");
                }
                else
                    return BadRequest("Niste izabrali ispravnog higijenicara!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
                return BadRequest(e.Message);
            }
        }
    }
}
