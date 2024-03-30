using Bolnica.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Mapiranja
{
    public class OdeljenjeMapiranje:ClassMap<Odeljenje>
    {
        public OdeljenjeMapiranje()
        {
            Table("ODELJENJE");

            Id(x => x.ID, "ID").GeneratedBy.SequenceIdentity("S18108.ODELJENJE_ID_SEQ");
            Map(x => x.Sifra, "SIFRA");
            Map(x => x.Tip, "TIP");           
            Map(x => x.DatumIzgradnje, "DATUMIZGRADNJE");
            References(x => x.Specijalista).Column("IDSPECIJALISTE").LazyLoad();
            
        }
    }
}
