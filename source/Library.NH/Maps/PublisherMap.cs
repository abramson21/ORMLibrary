namespace Library.NH.Maps
{
    using FluentNHibernate.Mapping;
    using Library.Domain;

    public class PublisherMap : ClassMap<Publisher>
    {
        public PublisherMap()
        {
            this.Table("Publishers");

            this.Id(x => x.Id);

            this.Map(x => x.Name);

            this.HasManyToMany(x => x.Books);
        }
    }
}
