using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SOAPService
{
    public class CustomerService : ICustomerService
    {
        public string GetCustomerDetails(int customerId)
        {
            return $"Customer details for ID {customerId}";
        }
    }

}
