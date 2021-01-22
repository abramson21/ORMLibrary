namespace Library.NH.Maps
{
    using FluentNHibernate.Mapping;
    using Library.Domain;

    public class AuthorMap : ClassMap<Author>
    {
        public AuthorMap()
        {
            this.Table("Authors");

            this.Id(x => x.ID).GeneratedBy.Increment();

            this.Component(x => x.Name);

            this.HasManyToMany(x => x.Books).Inverse();
        }
    }
}
