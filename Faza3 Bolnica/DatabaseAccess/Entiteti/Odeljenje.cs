using Bolnica.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Entiteti
{
    public class Odeljenje
    {
        public virtual int ID { get; protected set; }
        public virtual int Sifra { get; set; }
        public virtual string? Tip { get; set; }
        public virtual DateTime? DatumIzgradnje { get; set; }
        public virtual MedicinskoOsoblje? Specijalista { get; set; }
       
        public Odeljenje() 
        {
            
        }

       
    }
}
