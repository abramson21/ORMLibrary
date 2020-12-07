
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.NH.Maps
{
    using FluentNHibernate.Mapping;
    using Library.Domain;
    public class ShelfMap : ClassMap<Shelf>
    {
        public ShelfMap()
        {
            this.Table("Shelf");

            this.Id(x => x.Id);

            this.References(x => x.Room).ForeignKey("ID_Room");

            //this.Map(x => x.Note);

            this.Map(x => x.NumberShelf);
        }
    }
}
