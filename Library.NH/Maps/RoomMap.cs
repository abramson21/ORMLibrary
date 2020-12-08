using System;
using System.Collections.Generic;
using System.Text;

namespace Library.NH.Maps
{
    using FluentNHibernate.Mapping;
    using Library.Domain;
    public class RoomMap : ClassMap<Room>
    {
        public RoomMap()
        {
            this.Table("Room");

            this.Id(x => x.Id);

            this.Map(x => x.RoomName);

            this.HasMany(x => x.Shelves).Inverse();

            this.References(x => x.Book);
        }
    }
}
