using Ijuba.Webapi.Application.IMS.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Application.IMS.Interfaces;
public interface ICustomerService: ITransientService
{
    public Task<PaginationResponse<CustomerDto>> GetAllCustomers();
}
