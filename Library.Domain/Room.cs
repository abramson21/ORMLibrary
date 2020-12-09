namespace Library.Domain
{
    using System.Collections.Generic;
    using Infrastructure.Extensions;

    public class Room
    {
        public virtual int Id { get; protected set; }

        public virtual string RoomName { get; protected set; }

        public virtual string Note { get; protected set; }

        public virtual ISet<Shelf> Shelves { get; protected set; } = new HashSet<Shelf>();

        public virtual ISet<Book> Books { get; protected set; } = new HashSet<Book>();

        public override string ToString() => $"{this.RoomName} --> Номер полки: {this.Shelves.Join()}";
    }
}
