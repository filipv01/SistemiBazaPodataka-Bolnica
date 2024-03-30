using Bolnica.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.DTO
{
    public class OdeljenjeDTO
    {
        public int ID { get; protected set; }
        public int Sifra { get; set; }
        public string Tip { get; set; }
   
        public DateTime DatumIzgradnje { get; set; }
        public MedicinskoOsobljeDTO Specijalista { get; set; }

        public OdeljenjeDTO()
        {

        }
        public OdeljenjeDTO(Odeljenje o) : this()
        {
            this.ID = o.ID;
            this.Sifra = o.Sifra;
            this.Tip= o.Tip;            
            this.DatumIzgradnje= o.DatumIzgradnje;
            
        }
    }
}
