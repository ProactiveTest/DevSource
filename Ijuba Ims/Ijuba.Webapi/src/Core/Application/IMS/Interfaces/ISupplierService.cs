using Ijuba.Webapi.Application.Common.Interfaces;
using Ijuba.Webapi.Application.IMS.Supplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Application.IMS.Interfaces;
public interface ISupplierService : ITransientService
{
    Task<PaginationResponse<SupplierDto>> GetAllCreditors();
}
