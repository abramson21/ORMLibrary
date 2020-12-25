using System.Collections.Generic;

namespace Library.Domain
{
    public class Shelf
    {
        public virtual int Id { get; protected set; }

        public virtual int ID_Room { get; protected set; }

        public virtual string Description { get; protected set; }

        public virtual Room Room { get; protected set; }

        public virtual ISet<Book> Books { get; protected set; } = new HashSet<Book>();

        public override string ToString() => $" {this.Room} -- {this.Description}";
    }
}
