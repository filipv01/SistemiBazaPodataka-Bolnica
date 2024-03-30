using Bolnica.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.DTO
{
    public class StomatoloskaStolicaDTO
    {
        public int ID { get; protected set; }
        public string Proizvodjac { get; set; }
        public DateTime DatumProizvodnje { get; set; }
        public NemedicinskoOsobljeDTO TehnickoOdrzavanje { get; set; }
        public virtual IList<MedicinskoOsobljeDTO> Stomatolozi { get; set; }
        public StomatoloskaStolicaDTO(){
            Stomatolozi = new List<MedicinskoOsobljeDTO>();
        }
        public StomatoloskaStolicaDTO(StomatoloskaStolica s)
        {
            Stomatolozi = new List<MedicinskoOsobljeDTO>();

            this.ID = s.ID;
            this.Proizvodjac = s.Proizvodjac;
            this.DatumProizvodnje = s.DatumProizvodnje;
        }
    }
}
