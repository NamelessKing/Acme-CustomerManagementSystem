using System.Collections.Generic;

namespace Acme.BL.Repository
{
    public class CustomerRepository
    {

        private List<Customer> FakeCustomersData = new List<Customer>()
        {
            new Customer(1)
            {
                EmailAddess = "gino@email.com",
                FirstName = "Gino",
                LastName = "Panino"
            },
            new Customer(2)
            {
                EmailAddess = "pino@email.com",
                FirstName = "Pino",
                LastName = "Merlino"
            },
            new Customer(3)
            {
                EmailAddess = "Brio@email.com",
                FirstName = "Brio",
                LastName = "Blue"
            }
        };

        /// <summary>
        /// Retrieve one cutomer by id.
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            Customer customer = FakeCustomersData.Find(c => c.CustomerId == customerId);

            return customer;
        }


        /// <summary>
        /// Retrieve all customers.
        /// </summary>
        /// <returns></returns>
        public List<Customer> Retrieve()
        {
            return FakeCustomersData;
        }


        /// <summary>
        /// Save the current customer.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }
    }
}
