using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Bolnica.Entiteti;
using FluentNHibernate.Conventions.Helpers;

namespace Bolnica.Mapiranja
{
     class MedicinskoOsobljeMapiranje:SubclassMap<MedicinskoOsoblje>
    {
        public MedicinskoOsobljeMapiranje()
        {
            Table("MEDICINSKO_OSOBLJE");

            KeyColumn("IDOSOBE");

            Map(x => x.Specijalnost, "SPECIJALNOST");
            Map(x => x.TipMedOsoblja, "TIPMEDOSOBLJA");
            Map(x => x.BrojOrdinacije, "BROJORDINACIJE");
            Map(x => x.GodineRadnogStaza, "GODINERADNOGSTAZA");
            Map(x => x.Smena, "SMENA");

            HasMany(x => x.Odeljenja).KeyColumn("IDSPECIJALISTE").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Pacijenti).KeyColumn("IDLEKARAOP").LazyLoad().Cascade.All().Inverse();
            References(x=>x.Stolica).Column("IDSTOLICE").LazyLoad();
        }
    }
}
