﻿namespace Library.NH
{
    using FluentNHibernate.Mapping;
    using Library.Domain;

    class BookMap : ClassMap<Book>
    {
        public BookMap()
        {

            this.Table("Books");

            this.Id(x => x.Id);
            this.Map(x => x.Name);
            this.Map(x => x.Detailes);
            this.HasMany(x => x.Genres);
            this.HasManyToMany(x => x.Authors)/*.Table("Authors")*/;
            this.HasMany(x => x.Rooms);
        }
    }
}
