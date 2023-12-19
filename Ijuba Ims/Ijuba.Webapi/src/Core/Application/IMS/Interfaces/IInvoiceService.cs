using Ijuba.Webapi.Application.IMS.Invoice;
using Ijuba.Webapi.Application.IMS.Stock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Application.IMS.Interfaces;
public interface IInvoiceService : ITransientService
{
    public Task<PaginationResponse<InvoiceDto>> GetAllInvoices();

    public Task<PaginationResponse<InvoiceLineItemsDto>> GetAllInvoiceLineItems(Guid InvoiceId);
}
