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

            //this.Map(x => x.Name, "[Authors]");

            //this.HasMany(x => x.Authors);
            //this.HasMany(x => x.Books);

            //this.HasManyToMany(x => x.Teachers);
                //// Конвенция по умолчанию обязывает третьей сущности / таблице иметь имя "GroupsToTeachers"
                //// Это требование может не совпадать с требованиями предъявляемыми к БД, можно использовать:
                //// .Table("Teacher_Group")
        }
    }
}
