using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Domain.IMS.Stock;
public class StockTransactionType : AuditableEntity, IAggregateRoot
{
    public string Description { get; set; }
}
