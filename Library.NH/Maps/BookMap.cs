namespace Library.NH
{
    using FluentNHibernate.Mapping;
    using Library.Domain;

    class BookMap : ClassMap<Book>
    {
        public BookMap()
        {
            this.Table("Book");

            this.Id(x => x.Id);
            this.Map(x => x.Name, "Name");
        }
    }
}
