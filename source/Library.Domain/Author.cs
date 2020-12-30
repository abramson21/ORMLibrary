namespace Library.Domain
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class Author
    {
        public virtual int Id { get; protected set; }

        public virtual Name Name { get; protected set; }

        [JsonIgnore]
        public virtual ISet<Book> Books { get; protected set; } = new HashSet<Book>();

        public override string ToString() => $"{ this.Name }";

        protected Author() { }

        //public Author(string fullName/*lastName, string firstName, string middleName*/)
        //{
        //    //this.Name = new Name(firstName, lastName, middleName);
        //    this.Name = fullName;
        //}
    }
}
