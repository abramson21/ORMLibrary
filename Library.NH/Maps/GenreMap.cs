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

            this.Map(x => x.Title);

            this.HasMany(x => x.Books);

        }
    }
}
