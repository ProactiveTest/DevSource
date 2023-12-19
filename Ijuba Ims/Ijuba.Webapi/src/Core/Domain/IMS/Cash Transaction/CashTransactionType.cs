using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Domain.IMS.Cash_Transaction;
public class CashTransactionType : AuditableEntity, IAggregateRoot
{
    public string Name { get; set; }
    public string Description { get; set; }
    public bool SystemTransaction { get; set; }

}
