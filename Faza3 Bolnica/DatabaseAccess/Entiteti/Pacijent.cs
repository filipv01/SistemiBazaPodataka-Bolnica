using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Entiteti
{
    public class Pacijent:Osoba
    {
        
        public virtual string? TipPacijenta { get; set; }
        public virtual string? Adresa { get; set; }  
        public virtual DateTime? DatumPrijema { get; set; }
        public virtual DateTime? DatumOtpusta { get; set; }
        public virtual string? VrstaIntervencije { get; set; }
        public virtual DateTime? DatumIntervencije { get; set; }

        public virtual MedicinskoOsoblje? Stomatolog { get; set; }
        public virtual MedicinskoOsoblje? LekarOpstePrakse { get; set; }
        public virtual Odeljenje? Odeljenje { get; set; }

        public Pacijent() { }
    }
}
