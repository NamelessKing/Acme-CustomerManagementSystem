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
    }
}
