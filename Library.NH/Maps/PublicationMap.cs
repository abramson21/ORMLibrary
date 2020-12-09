using Library.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.NH.Maps
{
    using FluentNHibernate;
    using FluentNHibernate.Mapping;

    public class PublicationMap : ClassMap<Publication>
    {
       public PublicationMap()
        {
            this.Table("Publication");

            this.Id(x => x.Id);

            this.Map(x => x.Name);

            this.References(x => x.Book).ForeignKey("ID_Publication");
        }
    }
}
