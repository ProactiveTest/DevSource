using Ijuba.Webapi.Application.Catalog.Products;
using Ijuba.Webapi.Domain.IMS.Cash_Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Application.IMS.Cash_Transaction;

public class CashTransactionsBySearchRequest : EntitiesByPaginationFilterSpec<CashTransaction, CashTransactionDto>
{
    public CashTransactionsBySearchRequest(SearchCashTransactionRequest request)
        : base(request) =>
        Query
            //.Include(p => p.Brand)
            .OrderBy(c => c.CashTransactionTypeId, !request.HasOrderBy())
            //.Where(p => p.BrandId.Equals(request.BrandId!.Value), request.BrandId.HasValue)
            .Where(p => p.TransactionDate >= request._startDate!.Value, request._startDate.HasValue)
            .Where(p => p.TransactionDate <= request._endDate!.Value, request._endDate.HasValue);
}


