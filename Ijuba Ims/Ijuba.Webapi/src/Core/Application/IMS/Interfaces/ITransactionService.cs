using Ijuba.Webapi.Application.IMS.Cash_Transaction;
using Ijuba.Webapi.Domain.IMS.Cash_Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Application.IMS.Interfaces;
public interface ITransactionService : ITransientService
{
    Task<PaginationResponse<CashTransactionTypeDto>> GetAllCashTransactionTypes();
    Task<PaginationResponse<CashTransactionDto>> GetAllCashTransactions();
}
