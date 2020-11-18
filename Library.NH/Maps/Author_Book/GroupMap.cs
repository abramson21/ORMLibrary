namespace University.NH.Maps
{
    using FluentNHibernate.Mapping;

    using Library.Domain;

    /// <summary>
    /// Правила отображения для <see cref="Group"/>.
    /// </summary>
    public class GroupMap : ClassMap<Group>
    {
        public GroupMap()
        {
            this.Table("Book_Authors");

            this.Id(x => x.Id);

            this.HasMany(x => x.Authors);

            this.HasMany(x => x.Books);

        }
    }
}
