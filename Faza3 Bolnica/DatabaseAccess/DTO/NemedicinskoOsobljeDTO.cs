using Bolnica.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.DTO
{
    public class NemedicinskoOsobljeDTO : OsobaDTO
    {
        public string? TipNemedOsoblja { get; set; }
        public string? Struka { get; set; }
        public IList<StomatoloskaStolicaDTO>? Stolice { get; set; }

        public NemedicinskoOsobljeDTO() : base()
        {
            Stolice = new List<StomatoloskaStolicaDTO>();

        }

        public NemedicinskoOsobljeDTO(NemedicinskoOsoblje nemed) : base(nemed)
        {
            Stolice = new List<StomatoloskaStolicaDTO>();

            this.TipNemedOsoblja = nemed.TipNemedOsoblja;
            this.Struka = nemed.Struka;
        }
    }
}
