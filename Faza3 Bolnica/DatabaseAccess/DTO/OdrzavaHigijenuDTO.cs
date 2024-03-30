using Bolnica.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.DTO
{
    public class OdrzavaHigijenuDTO
    {
        public int ID { get; set; }
        public NemedicinskoOsobljeDTO? Higijenicar { get; set; }
        public OdeljenjeDTO? Odeljenje { get; set; }

        public OdrzavaHigijenuDTO()
        {

        }
        public OdrzavaHigijenuDTO(OdrzavaHigijenu o)
        {
            this.ID = o.ID;
        }
    }
}
