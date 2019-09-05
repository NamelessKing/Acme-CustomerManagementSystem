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

            string expected = "Gino, Panino";

            // -- Act
            string actual = customer.FullName;

            // -- Assert 
            Assert.AreEqual(expected, actual);
        }
    }
}
