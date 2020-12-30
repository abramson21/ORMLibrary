namespace Library.Domain
{
    using System.Collections.Generic;
    using Infrastructure.Extensions;

    public class Room
    {
        public Room() { }

        public Room(string name)
        {
            this.Name = name;
        }

        public virtual int Id { get; protected set; }

        public virtual string Name { get; protected set; }

        public virtual ISet<Shelf> Shelves { get; protected set; } = new HashSet<Shelf>();

        public override string ToString() => $"{this.Name}";
    }
}
