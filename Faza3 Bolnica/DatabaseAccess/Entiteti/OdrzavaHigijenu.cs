using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Entiteti
{
    public class OdrzavaHigijenu
    {
        public virtual int ID { get; protected set; }
        public virtual NemedicinskoOsoblje? Higijenicar { get; set; }
        public virtual Odeljenje? Odeljenje { get; set; }
        public OdrzavaHigijenu() { }
    }
}
