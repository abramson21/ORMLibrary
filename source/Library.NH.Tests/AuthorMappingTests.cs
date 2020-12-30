namespace Library.NH.Tests
{
    using NUnit.Framework;
    using NHibernate;
    using Infrastructure.Helpers;
    using System.Collections.Generic;
    using FluentNHibernate.Testing;
    using Library.Domain;

    /// <summary>
    /// ��������� ����� ��� ������ <see cref="AuthorMap"/>.
    /// </summary>
    public class AuthorMappingTests
    {

        private ISession session;

        [SetUp]
        public void Setup()
        {
            this.session = NHibernateTestHelper.GetSession(true, typeof(AuthorMap).Assembly);
        }

        [Test]
        public void Test1()
        {
            // arrange
            var books = new List<Book>
            {
                new Book("����������� �����"),
                new Book("������� ������"),
                new Book("������ � �������")
            };

            var testName = new Name("���������", "������", "���������");

            //act &  assert
            new PersistenceSpecification<Author>(this.session)
                .CheckProperty(x => x.Name, testName)
                .CheckList(x => x.Books, books, book=>book.Id)
                .VerifyTheMappings();
        }
    }
}