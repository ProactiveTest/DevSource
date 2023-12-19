using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Domain.IMS.Supplier;
public class SupplierBankDetails : AuditableEntity, IAggregateRoot
{
    public Guid SupplierId { get; set; }
    public string BankName { get; set; }

    public string BranchCode { get; set; }

    public string AccountType { get; set; }

    public string AccountNumber { get; set; }
}
