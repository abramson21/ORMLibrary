namespace Library.NH.Maps
{
    using Library.Domain;
    using FluentNHibernate.Mapping;

    public class PublicationMap : ClassMap<Publisher>
    {
        public PublicationMap()
        {
            this.Table("Publishers");

            this.Id(x => x.Id);

            this.Map(x => x.Name);

            this.HasManyToMany(x => x.Books).Table("PublisherBook");
        }
    }
}
