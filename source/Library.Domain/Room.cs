namespace Library.Domain
{
    using System.Collections.Generic;
    using Infrastructure.Extensions;

    public class Room
    {
        public virtual int Id { get; protected set; }

        public virtual string Name { get; protected set; }

        public virtual ISet<Shelf> Shelves { get; protected set; } = new HashSet<Shelf>();

        public override string ToString() => $"{this.Name}";
    }
}
