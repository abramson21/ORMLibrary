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
            //this.Map(x => x.Name, "[Books]");

            //this.HasManyToMany(x => x.Authors);
            //this.Name(x => x.Name);
            //this.Component(x => x.Name);

            //this.Map(x => x.Id, "[Book_Authors]");

            //this.References(x => x.Authors);
            //this.Name(x => x.Name);
            //this.HasManyToMany(x => x.Authors);
        }
    }
}
