using Bolnica.Entiteti;
using FluentNHibernate.Mapping;

namespace Bolnica.Mapiranja
{
    public class OdrzavaHigijenuMapiranje : ClassMap<OdrzavaHigijenu>
    {
        public OdrzavaHigijenuMapiranje()
        {

            Table("ODRZAVA_HIGIJENU");

            Id(x => x.ID, "ID").GeneratedBy.SequenceIdentity("S18108.ODRZAVA_HIGIJENU_ID_SEQ");
            
            References(x => x.Odeljenje).Column("IDODELJENJA").LazyLoad();
            References(x => x.Higijenicar).Column("IDHIGIJENICARA").LazyLoad();
        }

    }
}
