using Ijuba.Webapi.Application.IMS.Interfaces;
using Ijuba.Webapi.Application.IMS.Stock;
using Ijuba.Webapi.Infrastructure.Persistence.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ijuba.Webapi.Domain.IMS.Stock;
using Ijuba.Webapi.Application.Catalog.Brands;
using Ijuba.Webapi.Application.IMS.Invoice;
using Ijuba.Webapi.Domain.IMS.Invoice;

namespace Ijuba.Webapi.Host.Controllers.IMS;
[Route("api/[controller]")]
[ApiController]
public class StockController : VersionNeutralApiController
{
    private readonly ApplicationDbContext _db;

    private readonly IStockService _imsService;
    public StockController(ApplicationDbContext db, IStockService imsService)
    {
        _db = db;
        _imsService = imsService;
    }

    


    [HttpPost("CreateStockTransactionAsync")]
    [MustHavePermission(FSHAction.Create, FSHResource.Stock)]
    [OpenApiOperation("Create a new Stock Transaction", "")]
    public Task<StockTransactionDto> CreateStockTransactionAsync(StockTransactionDto iMSDto)
    {
        StockTransaction stock = new StockTransaction();

        stock.StockCode = iMSDto.StockCode;
        stock.TransactionValueId = iMSDto.TransactionValueId;
        stock.Quantity = iMSDto.Quantity;
        stock.Ref_Id = iMSDto.Ref_Id;
        stock.CreatedBy = iMSDto.UserID;
        stock.LastModifiedBy = iMSDto.UserID;

        _db.StockTransaction.Add(stock);
        _db.SaveChanges();
        iMSDto.Id = stock.Id;

        return Task.FromResult(iMSDto);
    }


    [HttpGet("GetAllStock")]
    [MustHavePermission(FSHAction.Search, FSHResource.Stock)]
    [OpenApiOperation("Gets a list of Stock", "")]
    public async Task<List<StockDto>> GetAllStock()
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

        return result;
    }


    [HttpPost("search")]
    [MustHavePermission(FSHAction.Search, FSHResource.Stock)]
    [OpenApiOperation("Search stock using available filters.", "")]
    public Task<PaginationResponse<StockDto>> SearchAsync(SearchStockRequest request)
    {
        return Mediator.Send(request);
    } 

    //public Task<PaginationResponse<StockDto>> SearchAsync()
    //{

    //    var response = _imsService.GetAllStock();

    //    return response;
    //}


    [HttpPost]
    [MustHavePermission(FSHAction.Create, FSHResource.Stock)]
    [OpenApiOperation("Create a new Stock Item", "")]
    public Task<StockDto> CreateAsync(StockDto iMSDto)
    {
      Stock stock = new Stock();

        stock.CostPrice = iMSDto.CostPrice;
        stock.Description = iMSDto.Description;
        stock.RetailPrice = iMSDto.RetailPrice;
        stock.Hold = iMSDto.Hold;
        stock.StockCode = iMSDto.StockCode;
        stock.Quantity = iMSDto.Quantity;
        stock.CreatedBy = iMSDto.UserID;
        stock.SupplierId = iMSDto.SupplierId;
        stock.LastModifiedBy = iMSDto.UserID;

        _db.Stock.Add(stock);
        _db.SaveChanges();
        iMSDto.Id = stock.Id;

        return Task.FromResult(iMSDto);
    }

    [HttpPut("{id:guid}")]
    [MustHavePermission(FSHAction.Update, FSHResource.Stock)]
    [OpenApiOperation("Update a stock item.", "")]
    public async Task<ActionResult<Guid>> UpdateAsync(StockDto request, Guid id)
    {
        Stock stock = new Stock();

        var exstock = _db.Stock.Where(x => x.Id == id).FirstOrDefault();

        exstock.CostPrice = request.CostPrice;
        exstock.Description = request.Description;
        exstock.RetailPrice = request.RetailPrice;
        exstock.Hold = request.Hold;
        exstock.StockCode = request.StockCode;
        exstock.Quantity = request.Quantity;
        _db.Stock.Update(exstock);
        _db.SaveChanges();
        return exstock.Id;

    }

    [HttpDelete("{id:guid}")]
    [MustHavePermission(FSHAction.Delete, FSHResource.Stock)]
    [OpenApiOperation("Delete a Stock.", "")]
    public async Task DeleteAsync(Guid id)
    {
        var exstock = _db.Stock.Where(x => x.Id == id).FirstOrDefault();

        _db.Stock.Remove(exstock);
        _db.SaveChanges(true);

    }

}
