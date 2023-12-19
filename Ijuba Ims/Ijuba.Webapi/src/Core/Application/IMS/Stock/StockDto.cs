using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Application.IMS.Stock;
public class StockDto : IDto
{
    public Guid Id { get; set; }
    public decimal Quantity { get; set; }
    public decimal CostPrice { get; set; }
    public string StockCode { get; set; }
    public string Description { get; set; }
    public decimal RetailPrice { get; set; }

    public bool Hold { get; set; }

    public Guid UserID { get; set; }

    public Guid SupplierId { get; set; }
}

