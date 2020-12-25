namespace Library.Domain
{
    public class Shelf
    {
        public virtual int Id { get; protected set; }

        public virtual int ID_Room { get; protected set; }

        public virtual int NumberShelf { get; protected set; }

        public virtual string Note { get; protected set; }

        public virtual Room Room { get; protected set; }

        public override string ToString() => $"{this.NumberShelf} ({this.Note})";
    }
}
