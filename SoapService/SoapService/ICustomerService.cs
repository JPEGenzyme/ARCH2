using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SoapService
{
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        string GetCustomerDetails(int customerId);
    }

}
