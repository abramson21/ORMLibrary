namespace Library.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class Author
    {
        public virtual int ID { get; protected set; }

        public virtual Name Name { get; protected set; }

        [JsonIgnore]
        public virtual ISet<Book> Books { get; protected set; } = new HashSet<Book>();

        public override string ToString() => $"{this.Name}";

        [Obsolete("Конструктор только для ORM")]
        protected Author() { }

        public Author(string lastName, string firstName, string middleName)
        {
            this.Name = new Name(firstName, lastName, middleName);
        }
    }
}
