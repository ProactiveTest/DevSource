using Ijuba.Webapi.Application.Catalog.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Application.IMS.Cash_Transaction;
public class SearchCashTransactionRequest : PaginationFilter, IRequest<PaginationResponse<CashTransactionDto>>
{
    public DateTime? _startDate { get; set; }
    public DateTime? _endDate { get; set; }
}

public class SearchCashTransactionRequestHandler : IRequestHandler<SearchCashTransactionRequest, PaginationResponse<CashTransactionDto>>
{
    private readonly IReadRepository<Domain.IMS.Cash_Transaction.CashTransaction> _repository;

    public SearchCashTransactionRequestHandler(IReadRepository<Domain.IMS.Cash_Transaction.CashTransaction> repository) => _repository = repository;

    public async Task<PaginationResponse<CashTransactionDto>> Handle(SearchCashTransactionRequest request, CancellationToken cancellationToken)
    {
        var spec = new CashTransactionsBySearchRequest(request);
        return await _repository.PaginatedListAsync(spec, request.PageNumber, request.PageSize, cancellationToken: cancellationToken);
    }
}
