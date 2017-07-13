using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class RepositoryTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var customers = new List<Customer>
            {
                new Customer { Id = 1 ,Email = "test@ga.co", FirstName = "John", LastName = "Smith", HomeAddress = "42 Wallaby Way, Sydney", WorkAddress = "55 York street, Sydney" }
            };
            var repo = new GenericRepository<Customer>(customers);
            var expected = new Customer(1)
            {
                Id = 1,
                Email = "test@ga.co",
                FirstName = "John",
                LastName = "Smith"
            };

            // Act
            var actual = repo.GetById(1);

            // Assert
            Assert.AreEqual(expected.Id, actual.Id);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.Email, actual.Email);

        }
    }
}
