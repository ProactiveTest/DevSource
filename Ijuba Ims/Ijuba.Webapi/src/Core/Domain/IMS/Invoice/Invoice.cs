using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Domain.IMS.Invoice;
public class Invoice : AuditableEntity, IAggregateRoot
{
    public string InvoiceNo { get; set; }

    public Guid CustomerId { get; set; }

    public decimal TotalsAmount { get; set; }

    public  decimal TotalsVat { get; set; }

    public decimal TotalsDiscount { get; set; }

    public decimal Freight {  get; set; }

    public decimal TotalDue { get;set; }

}
