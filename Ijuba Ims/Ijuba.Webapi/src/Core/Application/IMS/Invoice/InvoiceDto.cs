using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Application.IMS.Invoice;
public class InvoiceDto :IDto
{
    public Guid Id { get; set; }
    public string InvoiceNo { get; set; }

    public Guid CustomerId { get; set; }

    public decimal TotalsAmount { get; set; }

    public decimal TotalsVat { get; set; }

    public decimal TotalsDiscount { get; set; }

    public decimal Freight { get; set; }

    public decimal TotalDue { get; set; }

    public Guid UserId { get; set; }
}
