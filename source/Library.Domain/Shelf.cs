using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Library.Domain
{
    public class Shelf
    {
        public Shelf() { }

        public Shelf(string description)
        {
            this.Description = description;
        }

        public virtual int Id { get; protected set; }

        public virtual int ID_Room { get; protected set; }

        public virtual string Description { get; protected set; }

        [JsonIgnore]
        public virtual ISet<Book> Books { get; protected set; } = new HashSet<Book>();

        public virtual ISet<Book> Books { get; protected set; } = new HashSet<Book>();

        public override string ToString() => $" {this.Room} -- {this.Description}";
    }
}
