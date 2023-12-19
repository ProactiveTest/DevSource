using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Application.IMS.Invoice;
public class InvoiceLineItemsDto : IDto
{
    public Guid Id { get; set; }
    public string StockCode { get; set; }

    public string Description { get; set; }

    public decimal Quanity { get; set; }

    public decimal CurrentStockQuanity { get; set; } = 0;

    public decimal Price { get; set; }

    public decimal Discount { get; set; }

    public decimal Total { get; set; }

    public decimal VatTotal { get; set; }

    public Guid InvoiceId { get; set; }

    public Guid UserId { get; set; }
}
