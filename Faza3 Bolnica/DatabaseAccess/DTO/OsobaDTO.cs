using Bolnica.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.DTO
{
    public abstract class OsobaDTO
    {
        public int IDOsobe { get; set; }
        public string? Ime { get; set; }
        public string? Prezime { get; set; }
        public string? MaticniBroj { get; set; }

        public OsobaDTO() { }

        public OsobaDTO(Osoba o)
        {
            this.IDOsobe = o.IDOsobe;
            this.Ime = o.Ime;
            this.Prezime = o.Prezime;
            this.MaticniBroj = o.MaticniBroj;
        }
    }
}
