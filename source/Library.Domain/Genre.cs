namespace Library.Domain
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class Genre
    {
        public Genre() { }

        public Genre(string name)
        {
            this.Name = name;
        }

        public virtual int Id { get; protected set; }

        public virtual string Name { get; protected set; }

        [JsonIgnore]
        public virtual ISet<Book> Books { get; protected set; } = new HashSet<Book>();

        public override string ToString() => this.Name;
    }
}
