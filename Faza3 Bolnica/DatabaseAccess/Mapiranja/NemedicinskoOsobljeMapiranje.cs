using Bolnica.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Mapiranja
{
    public class NemedicinskoOsobljeMapiranje:SubclassMap<NemedicinskoOsoblje>
    {
        public NemedicinskoOsobljeMapiranje()
        {
            Table("NEMEDICINSKO_OSOBLJE");

            KeyColumn("IDOSOBE");

            Map(x => x.TipNemedOsoblja, "TIPNEMEDOSOBLJA"); 
            Map(x => x.Struka, "STRUKA");
            HasMany(x => x.Stolice).KeyColumn("IDSTOLICE").LazyLoad().Cascade.Refresh().Inverse();
        }
    }
}
