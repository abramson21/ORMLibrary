namespace Library.NH.Maps
{
    using FluentNHibernate.Mapping;
    using Library.Domain;

    public class GenreMap : ClassMap<Genre>
    {
        public GenreMap()
        {
            this.Table("Genres");

            this.Id(x => x.Id);

            this.Map(x => x.Name);

            this.HasManyToMany(x => x.Books).Table("GenreBook");
        }
    }
}
