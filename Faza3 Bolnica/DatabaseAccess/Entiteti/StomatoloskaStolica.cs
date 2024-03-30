using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bolnica.Entiteti
{
    public class StomatoloskaStolica
    {
        public virtual int ID { get; protected set; }
        public virtual string? Proizvodjac { get; set; }   
        public virtual DateTime? DatumProizvodnje { get; set; }
        public virtual IList<MedicinskoOsoblje>? Stomatolozi { get; set; }

        public virtual NemedicinskoOsoblje? TehnickoOdrzavanje { get; set; } 
        public StomatoloskaStolica() { 
            Stomatolozi = new List<MedicinskoOsoblje>();
        }
    }
}
