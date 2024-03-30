using Bolnica.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Entiteti
{
    public class MedicinskoOsoblje : Osoba
    {
        public virtual int GodineRadnogStaza { get; set; }          
        public virtual string TipMedOsoblja { get; set; }
        public virtual int? BrojOrdinacije { get; set; } //samo lekar opste prakse
        public virtual string Specijalnost { get; set; } //samo lekar specijalista
        public virtual int? Smena { get; set; } //za stomatologa
        public virtual StomatoloskaStolica Stolica { get; set; } 
        public virtual IList<Pacijent> Pacijenti { get; set; }
        public virtual IList<Odeljenje> Odeljenja { get; set; }
                                                   
        public MedicinskoOsoblje() 
        { 
            Pacijenti= new List<Pacijent>();
            Odeljenja = new List<Odeljenje>();
        }

      
    }
}
