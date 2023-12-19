using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Application.IMS.Cash_Transaction;
public class CashTransactionDto : IDto
{
    public Guid Id { get; set; }
    public Guid CashTransactionTypeId { get; set; }

    public string CashTransactionName { get; set; }
    public DateTime TransactionDate { get; set; }
    public decimal Amount { get; set; }
    public Guid Ref_Id { get; set; }
    public Guid UserId { get; set; }
 
}
