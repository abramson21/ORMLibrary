namespace Library.Domain
{
    using System.Collections.Generic;

    public class Publisher
    {
        public Publisher() { }

        public Publisher(string name)
        {
            this.Name = name;
        }

        public virtual int Id { get; protected set; }

        public virtual string Name { get; protected set; }

        [JsonIgnore]
        public virtual ISet<Book> Books { get; protected set; } = new HashSet<Book>();

        public override string ToString() => $"{this.Name} ";
    }
}
