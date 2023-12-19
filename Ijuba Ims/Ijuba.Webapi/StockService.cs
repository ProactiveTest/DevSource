using System;
using Ijuba.Webapi.Application.Common.Models;

public class StockService : PaginationFilter, IStockService
{
    private readonly ApplicationDbContext _db;
    private int count;

    public StockService(ApplicationDbContext db)
    {
        _db = db;
    }

    public async Task<PaginationResponse<StockDto>> GetAllStock()
    {
        var stocklist = _db.Stock.ToList();
        List<StockDto> result = new List<StockDto>();

        foreach (var stock in stocklist)
        {
            StockDto dto = new StockDto();
            dto.StockCode = stock.StockCode;
            dto.Quantity = stock.Quantity;
            dto.Hold = stock.Hold;
            dto.RetailPrice = stock.RetailPrice;
            dto.CostPrice = stock.CostPrice;
            dto.Description = stock.Description;
            dto.ID = stock.Id;
            result.Add(dto);

        }

        var response = new PaginationResponse<StockDto>(result, count, PageNumber, PageSize);

        return response;
    }
}
