using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Domain.IMS.Stock;
public class StockTransactionValue : AuditableEntity, IAggregateRoot
{
    public Guid StockTransactionTypeId { get; set; }

    public string Code { get; set; }

    public string Value { get; set; }
}
