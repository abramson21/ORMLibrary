namespace Library.NH.Maps
{
    using FluentNHibernate.Mapping;
    using Library.Domain;

    public class RoomMap : ClassMap<Room>
    {
        public RoomMap()
        {
            this.Table("Rooms");

            this.Id(x => x.Id);

            this.Map(x => x.Name);

            this.HasMany(x => x.Shelves);
        }
    }
}
