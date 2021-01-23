using Library.NH.Maps;

namespace Library.NH.Tests
{
    using NUnit.Framework;
    using NHibernate;
    using Infrastructure.Helpers;
    using System.Collections.Generic;
    using FluentNHibernate.Testing;
    using Library.Domain;

    /// <summary>
    /// Модульные тесты для класса <see cref="GenreMap"/>.
    /// </summary>
    public class GenreMappingTests
    {
        private ISession session;

        [SetUp]
        public void Setup()
        {
            this.session = NHibernateTestHelper.GetSession(true, typeof(GenreMap).Assembly);
        }

        [Test]
        public void Test1()
        {
            // arrange
            var books = new List<Book>
            {
                new Book("Горе от ума"),
                new Book("Ревизор"),
                new Book("Двенадцать стульев")
            };

            //act &  assert
            new PersistenceSpecification<Genre>(this.session)
                .CheckProperty(x => x.Name, "Комедия")
                .CheckList(x => x.Books, books, book => book.Id)
                .VerifyTheMappings();
        }
    }
}
