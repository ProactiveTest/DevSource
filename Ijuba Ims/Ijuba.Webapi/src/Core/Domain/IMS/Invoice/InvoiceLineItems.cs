using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Domain.IMS.Invoice;
public class InvoiceLineItems : AuditableEntity, IAggregateRoot
{
    public string StockCode { get; set; }

    public string Description { get; set; }

    public decimal Quanity { get; set; }

    public decimal Price { get; set; }

    public decimal Discount { get; set; }

    public decimal Total { get; set; }

    public decimal VatTotal { get; set; }

    public Guid InvoiceId { get; set; }


}
