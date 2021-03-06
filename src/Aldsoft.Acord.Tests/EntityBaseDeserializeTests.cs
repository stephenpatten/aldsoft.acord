﻿namespace Aldsoft.Acord.Tests
{
    using Entities;
    using System.Xml;
    using Xunit;

    public class DeserializeTests
    {
        public const string XML_STRING = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<MockAuthor xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Firstname>John</Firstname>\r\n  <Lastname>Smith</Lastname>\r\n  <Books>\r\n    <MockBook>\r\n      <ISBN>0123456788</ISBN>\r\n      <Title>Hello World!</Title>\r\n    </MockBook>\r\n    <MockBook>\r\n      <ISBN>0123456789</ISBN>\r\n      <Title>Hello World: Part 2</Title>\r\n    </MockBook>\r\n  </Books>\r\n</MockAuthor>";

        [Fact]
        public void Deserialize_Test1()
        {
            var xml = XML_STRING;

            var author = MockAuthor.Deserialize(xml);

            Assert.NotNull(author);
            Assert.Equal("John", author.Firstname);
            Assert.Equal(2, author.Books.Count);
        }

        [Fact]
        public void Deserialize_XmlReaderSettings()
        {
            var xml = XML_STRING;

            var author = MockAuthor.Deserialize(xml, new XmlReaderSettings());

            Assert.NotNull(author);
            Assert.Equal("John", author.Firstname);
            Assert.Equal(2, author.Books.Count);
        }
    }
}
