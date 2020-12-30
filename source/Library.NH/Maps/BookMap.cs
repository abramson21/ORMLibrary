namespace Library.NH
{
    using FluentNHibernate.Mapping;
    using Library.Domain;

    public class BookMap : ClassMap<Book>
    {
        public BookMap()
        {
            this.Table("Books");

            this.Id(x => x.Id);

            this.Map(x => x.Title);

            this.HasManyToMany(x => x.Genres).Table("GenreBook");

            this.HasManyToMany(x => x.Authors).Table("AuthorBook");

            this.References(x => x.Shelf, "ID_Shelve");

            this.HasManyToMany(x => x.Publishers).Table("PublisherBook");
        }
    }
}
