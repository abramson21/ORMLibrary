namespace Library.NH
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

            this.References(x => x.Genre);

            this.HasManyToMany(x => x.Authors);

            this.References(x => x.Room);

            this.References(x => x.Publication);
        }
    }
}
