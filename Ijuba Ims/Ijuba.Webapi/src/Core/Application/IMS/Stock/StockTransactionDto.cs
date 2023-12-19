using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Application.IMS.Stock;
public class StockTransactionDto : IDto
{
    public Guid Id { get; set; }
    public string StockCode { get; set; }
    public Guid TransactionValueId { get; set; }
    public int Quantity { get; set; }
    public Guid Ref_Id { get; set; }
    public Guid UserID { get; set; }
}
