namespace Library.Domain
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class Room
    {
        public virtual int Id { get; protected set; }

        public virtual string Name { get; protected set; }

        [JsonIgnore]
        public virtual ISet<Shelf> Shelves { get; protected set; } = new HashSet<Shelf>();

        public override string ToString() => this.Name;
    }
}
