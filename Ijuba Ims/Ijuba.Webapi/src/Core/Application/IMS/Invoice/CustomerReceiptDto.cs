using Ijuba.Webapi.Application.IMS.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Application.IMS.Invoice;
public class CustomerReceiptDto : IDto
{
    public CustomerDto customerdto {  get; set; }
    public InvoiceDto invoicedto { get; set; }
    public List<InvoiceLineItemsDto> lineitemsdto {  get; set; }
    
}
