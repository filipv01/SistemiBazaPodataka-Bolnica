using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Entiteti
{
    public class NemedicinskoOsoblje:Osoba
    {
        public virtual string? TipNemedOsoblja { get; set; }
        public virtual string? Struka { get; set; }
        public virtual IList<StomatoloskaStolica>? Stolice { get; set; }
        
        public NemedicinskoOsoblje()
        { 
           Stolice = new List<StomatoloskaStolica>();
        }
    }
}
