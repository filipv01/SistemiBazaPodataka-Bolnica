using Bolnica.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.DTO
{
    public class PacijentDTO : OsobaDTO
    {
        public string? TipPacijenta { get; set; }
        public string? Adresa { get; set; }
        public DateTime? DatumPrijema { get; set; }
        public DateTime? DatumOtpusta { get; set; }
        public string? VrstaIntervencije { get; set; }
        public DateTime? DatumIntervencije { get; set; }

        public MedicinskoOsobljeDTO? Stomatolog { get; set; }
        public MedicinskoOsobljeDTO? LekarOpstePrakse { get; set; }
        public OdeljenjeDTO? Odeljenje { get; set; }

        public PacijentDTO() : base()
        {

        }
        public PacijentDTO(Pacijent p) : base(p)
        {
            this.TipPacijenta = p.TipPacijenta;
            this.Adresa = p.Adresa;
            this.DatumPrijema = p.DatumPrijema;
            this.DatumOtpusta = p.DatumOtpusta;
            this.VrstaIntervencije = p.VrstaIntervencije;
            this.DatumIntervencije = p.DatumIntervencije;
          

        }
    }
}
