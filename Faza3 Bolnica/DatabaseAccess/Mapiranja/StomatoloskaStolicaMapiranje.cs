using Bolnica.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Mapiranja
{
   public class StomatoloskaStolicaMapiranje : ClassMap<StomatoloskaStolica>
    {
        public StomatoloskaStolicaMapiranje()
        {
            Table("STOMATOLOSKA_STOLICA");

            Id(x => x.ID, "IDSTOLICE").GeneratedBy.SequenceIdentity("S18108.STOMATOLOSKA_STOLICA_ID_SEQ");

            Map(x => x.Proizvodjac, "PROIZVODJAC");
            Map(x => x.DatumProizvodnje, "DATUMPROIZVODNJE");
            HasMany(x => x.Stomatolozi).KeyColumn("IDSTOLICE").LazyLoad().Cascade.All().Inverse();

            References(x=>x.TehnickoOdrzavanje).Column("IDTEHNODRZ").LazyLoad();
        }
    }
}
