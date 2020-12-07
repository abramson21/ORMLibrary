using System;
using System.Collections.Generic;
using System.Text;

namespace Library.NH.Maps
{
    using FluentNHibernate.Mapping;
    using Library.Domain;
    public class GenreMap : ClassMap<Genre>
    {
        public GenreMap()
        {
            this.Table("Genre");
            this.Id(x => x.Id);
            this.Id(x => x.ID_Genre);
            this.Map(x => x.Title);
            this.References(x => x.Book).ForeignKey("ID_Genre");
        }
    }
}
