using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Domain.IMS.Cash_Transaction;
public class CashTransaction : AuditableEntity, IAggregateRoot
{
    public Guid CashTransactionTypeId { get; set; }
    public DateTime TransactionDate { get; set; }
    public decimal Amount { get; set; }
    public Guid Ref_Id { get; set; }
    
}
