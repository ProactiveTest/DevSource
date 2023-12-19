using DocumentFormat.OpenXml.Wordprocessing;
using Ijuba.Webapi.Application.Common.Models;
using Ijuba.Webapi.Application.IMS.Interfaces;
using Ijuba.Webapi.Application.IMS.Stock;
using Ijuba.Webapi.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Infrastructure.IMS;
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
            dto.Id = stock.Id;
            result.Add(dto);

        }

        var response = new PaginationResponse<StockDto>(result, count, PageNumber, PageSize);

        return response;
    }
}

