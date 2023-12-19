using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Domain.IMS.Stock;
public class StockTransaction : AuditableEntity, IAggregateRoot
{
    public string StockCode { get; set; }
    public Guid TransactionValueId { get; set; }
    public int Quantity { get; set; }
    public Guid Ref_Id {  get; set; }

}
