namespace Library.Domain
{
    using System.Collections.Generic;
    using Infrastructure.Extensions;

    public class Book
    {
        public virtual int Id { get; protected set; }

        public virtual string Name { get; protected set; }

        public virtual string Detailes { get; protected set; }

        public virtual ISet<Author> Authors { get; protected set; } = new HashSet<Author>();

        public virtual Genre Genre { get; protected set; }

        public virtual Publication Publication { get; protected set; }

        public virtual Room Room { get; protected set; }

        public override string ToString() => $"Название книги: \"{this.Name}\" \n\t Автор: {this.Authors.Join()} \n\t Жанр: {this.Genre} \n\t Детали: {this.Detailes} \n\t Расположение: {this.Room} \n\t Издание: {this.Publication} \n\n";
    }
}
