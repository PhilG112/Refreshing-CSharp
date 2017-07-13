﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameIsValidTest()
        {
            // Arrange
            var customer = new Customer()
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            var expected = "Baggins, Bilbo";

            // Act
            var actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // Arrange
            var customer = new Customer()
            {
                LastName = "Baggins"
            };
            var expected = "Baggins";

            // Act
            var actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            // Arrange
            var customer = new Customer()
            {
                FirstName = "Bilbo"
            };
            var expected = "Bilbo";

            // Act
            var actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            // Arrange
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Rosie";
            Customer.InstanceCount += 1;

            // Act

            // Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            // Arrange
            var customer = new Customer()
            {
                LastName = "Baggins",
                Email = "fbaggins@hobbiton.me"
            };
            var expected = true;

            // Act
            var actual = customer.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            // Arrange
            var customer = new Customer()
            {
                Email = "fbaggins@hobiton.me"
            };
            var expected = false;

            // Act
            var actual = customer.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingEmail()
        {
            // Arrange
            var customer = new Customer
            {
                LastName = "Baggins"
            };

            var expected = false;

            // Act
            var actual = customer.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingEmailAndLastName()
        {
            // Arrange
            var customer = new Customer();
            var expected = false;

            // Act
            var actual = customer.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }


    }
}
