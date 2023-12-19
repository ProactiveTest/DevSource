using Ijuba.Webapi.Application.Catalog.Brands;
using Ijuba.Webapi.Application.IMS.Stock;
using Ijuba.Webapi.Domain.IMS.Stock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Application.IMS.Stock;
public class SearchStockRequest : PaginationFilter, IRequest<PaginationResponse<StockDto>>
{

}

public class StockBySearchRequestSpec : EntitiesByPaginationFilterSpec<Ijuba.Webapi.Domain.IMS.Stock.Stock, StockDto>
{
    public StockBySearchRequestSpec(SearchStockRequest request)
        : base(request) =>
        Query.OrderBy(c => c.StockCode, !request.HasOrderBy());
}

public class SearchStockRequestHandler : IRequestHandler<SearchStockRequest, PaginationResponse<StockDto>>
{
    private readonly IReadRepository<Ijuba.Webapi.Domain.IMS.Stock.Stock> _repository;

    public SearchStockRequestHandler(IReadRepository<Ijuba.Webapi.Domain.IMS.Stock.Stock> repository) => _repository = repository;

    public async Task<PaginationResponse<StockDto>> Handle(SearchStockRequest request, CancellationToken cancellationToken)
    {
        var spec = new StockBySearchRequestSpec(request);
        return await _repository.PaginatedListAsync(spec, request.PageNumber, request.PageSize, cancellationToken);
    }
}