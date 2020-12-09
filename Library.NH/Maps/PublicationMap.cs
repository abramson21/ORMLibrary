namespace Library.NH.Maps
{
    using Library.Domain;
    using FluentNHibernate.Mapping;

    public class PublicationMap : ClassMap<Publication>
    {
       public PublicationMap()
        {
            this.Table("Publication");

            this.Id(x => x.Id);

            this.Map(x => x.Name);

            this.HasMany(x => x.Books);
        }
    }
}
