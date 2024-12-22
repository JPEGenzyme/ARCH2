using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoapService
{
    public class CustomerService : ICustomerService
    {
        public string GetCustomerDetails(int customerId)
        {
            return $"Customer details for ID {customerId}";
        }
    }

}
