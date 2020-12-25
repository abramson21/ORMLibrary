namespace Library.NH.Maps
{
    using FluentNHibernate.Mapping;
    using Library.Domain;

    public class ShelfMap : ClassMap<Shelf>
    {
        public ShelfMap()
        {
            this.Table("Shelf");

            this.Id(x => x.Id);

            this.Map(x => x.NumberShelf);

            this.Map(x => x.Note);

            this.References(x => x.Room).ForeignKey("ID_Room");
        }
    }
}
