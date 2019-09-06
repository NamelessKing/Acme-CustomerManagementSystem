using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.BL.Tests
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // -- Arrange
            Customer customer = new Customer
            {
                FirstName = "Gino",
                LastName = "Panino"
            };

            string expected = "Panino, Gino";

            // -- Act
            string actual = customer.FullName;

            // -- Assert 
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // -- Arrange
            Customer customer = new Customer
            {
                LastName = "Panino"
            };

            string expected = "Panino";

            // -- Act
            string actual = customer.FullName;

            // -- Assert 
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            // -- Arrange
            Customer customer = new Customer
            {
                FirstName = "Gino"
            };

            string expected = "Gino";

            // -- Act
            string actual = customer.FullName;

            // -- Assert 
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void StaticTest()
        {
            // -- Arrange
            _ = new Customer
            {
                FirstName = "Gino"
            };
            Customer.InstanceCount++;

            _ = new Customer
            {
                FirstName = "Bruno"
            };
            Customer.InstanceCount++;

            _ = new Customer
            {
                FirstName = "Mario"
            };
            Customer.InstanceCount++;

            int expected = 3;

            // -- Act
            int actual = Customer.InstanceCount;

            // -- Assert 
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void ValidateValid()
        {
            // -- Arrange
            Customer customer = new Customer
            {
                LastName = "Gino",
                EmailAddess = "gino@email.com"
            };

            bool expected = true;

            // -- Act
            bool actual = customer.Validate();

            // -- Assert 
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void ValidateMissingLastName()
        {
            // -- Arrange
            Customer customer = new Customer
            {
                EmailAddess = "gino@email.com"
            };

            bool expected = false;

            // -- Act
            bool actual = customer.Validate();

            // -- Assert 
            Assert.AreEqual(expected, actual);
        }
    }
}
