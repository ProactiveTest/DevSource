using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Domain.IMS.Customer;
public class CustomerBankingDetails : AuditableEntity, IAggregateRoot
{
    public Guid CustomerID { get; set; }
    public string BankName { get; set; }

    public string BranchCode { get; set; }

    public string AccountType { get; set; }

    public string AccountNumber { get; set; }
}
