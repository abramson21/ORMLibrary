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
    /// Модульные тесты для класса <see cref="BookMap"/>.
    /// </summary>
    public class BookMappingTests
    {
        private ISession session;

        [SetUp]
        public void Setup()
        {
            this.session = NHibernateTestHelper.GetSession(true, typeof(BookMap).Assembly);
        }

        [Test]
        public void Test1()
        {
            // arrange
            var genres = new List<Genre>
            {
                new Genre("Роман"),
                new Genre("Роман_2")
            };

            var testName = new Name("Федор", "Достоевский", "Иванович");
            var authors = new List<Author>
            {
                new Author((testName))
            };

            var testShelve = new Shelf("Вторая сверху полка");

            var publishers = new List<Publisher>
            {
                new Publisher("Эксмо"),
                new Publisher("Росмэн")
            };

            //act &  assert
            new PersistenceSpecification<Book>(this.session)
                .CheckProperty(x => x.Title, "Идиот")
                .CheckList(x => x.Genres, genres, genre => genre.Id)
                .CheckList(x => x.Authors, authors, author => author.ID)
                .CheckReference(x => x.Shelf, testShelve, shelf => shelf.Id)
                .CheckList(x => x.Publishers, publishers, publisher => publisher.Id)
                .VerifyTheMappings();
        }
    }
}
