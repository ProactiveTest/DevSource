using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Application.IMS.Cash_Transaction;
public class CashTransactionTypeDto : IDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool SystemTransaction { get; set; }
    public Guid UserId { get; set; }

}
