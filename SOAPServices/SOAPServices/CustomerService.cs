using System.ServiceModel;

namespace SOAPServices
{
    [ServiceBehavior]
    public class CustomerService : ICustomerService
    {
        // Implementation of service methods
        public string GetCustomerDetails(int customerId)
        {
            return "Customer details for " + customerId;
        }
    }
}
