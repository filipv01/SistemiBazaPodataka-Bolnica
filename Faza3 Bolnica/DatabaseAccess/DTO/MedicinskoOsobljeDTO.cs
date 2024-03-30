using Bolnica.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bolnica.DTO;

namespace Bolnica.DTO
{
    public class MedicinskoOsobljeDTO : OsobaDTO
    {
        public int GodineRadnogStaza { get; set; }
        public string? TipMedOsoblja { get; set; }
        public int? BrojOrdinacije { get; set; }
        public string? Specijalnost { get; set; } 
        public int? Smena { get; set; } 
        public StomatoloskaStolicaDTO? Stolica { get; set; }
        public IList<PacijentDTO>? Pacijenti { get; set; }
        public IList<OdeljenjeDTO>? Odeljenja { get; set; }

        public MedicinskoOsobljeDTO() : base()
        {
            Pacijenti = new List<PacijentDTO>();
            Odeljenja = new List<OdeljenjeDTO>();
        }

        public MedicinskoOsobljeDTO(MedicinskoOsoblje med) : base(med)
        {
            Pacijenti = new List<PacijentDTO>();
            Odeljenja = new List<OdeljenjeDTO>();

            this.GodineRadnogStaza = med.GodineRadnogStaza;
            this.TipMedOsoblja = med.TipMedOsoblja;
            this.BrojOrdinacije = med.BrojOrdinacije;
            this.Specijalnost = med.Specijalnost;
            this.Smena = med.Smena;

        }
    }
}
