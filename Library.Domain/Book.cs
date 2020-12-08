namespace Library.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text;
    using Infrastructure.Extensions;

    public class Book
    {
        public virtual int Id { get; protected set; }

        public virtual string Name { get; protected set; }

        public virtual string Detailes { get; protected set; }

        //public virtual int TypeBook { get; protected set; }

        public virtual ISet<Author> Authors { get; protected set; } = new HashSet<Author>();

        public virtual ISet<Genre> Genres { get; protected set; } = new HashSet<Genre>();

        public virtual ISet<Room> Rooms { get; protected set; } = new HashSet<Room>();

        public override string ToString() => $"{this.Name} - {this.Genres.Join()} [{this.Detailes}] --- {this.Rooms.Join()}";
    }
}
