using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Entiteti
{
    public abstract class Osoba
    {
        public virtual int IDOsobe { get; protected set; }
        public virtual string? Ime { get; set; }
        public virtual string? Prezime { get; set; }
        public virtual string? MaticniBroj { get; set; }

        public Osoba() { }  

    }
}
