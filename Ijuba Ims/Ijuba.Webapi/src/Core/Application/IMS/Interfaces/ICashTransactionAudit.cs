using Ijuba.Webapi.Application.Auditing;
using Ijuba.Webapi.Application.IMS.Cash_Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Application.IMS.Interfaces;
public interface ICashTransactionAudit : ITransientService
{
    Task<List<CashTransactionDto>> GetUserTrailsAsync(Guid userId);
}
