namespace Library.NH.Maps
{
    using FluentNHibernate.Mapping;
    using Library.Domain;

    public class BookMap : ClassMap<Book>
    {
        public BookMap()
        {
            this.Table("Books");

            this.Id(x => x.Id).GeneratedBy.Increment();

            this.Map(x => x.Title);

            this.HasManyToMany(x => x.Authors);

            this.HasManyToMany(x => x.Publishers);
            
            this.HasManyToMany(x => x.Genres);

            this.References(x => x.Shelf, "ID_Shelf");
        }
    }
}
