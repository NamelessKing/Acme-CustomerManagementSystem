using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.BL
{
    public class Customer
    {
        public int CustomerId { get; private set; }
        public string EmailAddess { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName }, {LastName}";
            }
        }


    }
}
