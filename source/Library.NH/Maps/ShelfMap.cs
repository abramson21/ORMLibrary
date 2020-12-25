namespace Library.NH.Maps
{
    using FluentNHibernate.Mapping;
    using Library.Domain;

    public class ShelfMap : ClassMap<Shelf>
    {
        public ShelfMap()
        {
            this.Table("Shelves");

            this.Id(x => x.Id);

            this.Map(x => x.Description);

            this.HasMany(x => x.Books);

            this.References(x => x.Room, "ID_Room");
        }
    }
}
