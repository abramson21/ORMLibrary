namespace Library.NH
{
    using FluentNHibernate.Mapping;
    using Library.Domain;

    internal class AuthorMap : ClassMap<Author>
    {

        public AuthorMap()
        {
            this.Table("Author");

            this.Id(x => x.Id);

            this.Component(x => x.Name);
        }
    }
}
