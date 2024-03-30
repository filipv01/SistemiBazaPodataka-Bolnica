using Bolnica.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Mapiranja
{
   public  class PacijentMapiranje : SubclassMap<Pacijent>
    {
        public PacijentMapiranje()
        {
            Table("PACIJENT");

            KeyColumn("IDOSOBE");            

            Map(x => x.TipPacijenta, "TIPPACIJENTA"); 
            Map(x => x.Adresa, "ADRESA");
            Map(x => x.DatumPrijema, "DATUMPRIJEMA");
            Map(x => x.DatumOtpusta, "DATUMOTPUSTA");
            Map(x => x.DatumIntervencije, "DATUMINTERVENCIJE");
            Map(x => x.VrstaIntervencije, "VRSTAINTERVENCIJE");

            References(x => x.LekarOpstePrakse).Column("IDLEKARAOP").LazyLoad();
            References(x => x.Odeljenje).Column("IDODELJENJA").LazyLoad();
            References(x => x.Stomatolog).Column("IDSTOMATOLOGA").LazyLoad();
        }
    }
}
