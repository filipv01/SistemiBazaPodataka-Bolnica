using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Conventions.Helpers;
using FluentNHibernate.Mapping;
using Bolnica.Entiteti;

namespace Bolnica.Mapiranja
{
    public class OsobaMapiranje : ClassMap<Osoba>
    {
        public OsobaMapiranje() {

            

            Table("OSOBA");
            Id(x=>x.IDOsobe, "IDOsobe").GeneratedBy.SequenceIdentity("S18108.OSOBA_IDOSOBE_SEQ");
            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.MaticniBroj, "MATICNIBROJ");

           
        }
        
    }
}
