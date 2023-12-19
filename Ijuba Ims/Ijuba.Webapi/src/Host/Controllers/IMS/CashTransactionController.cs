using Ardalis.Specification.EntityFrameworkCore;
using Ijuba.Webapi.Application.Auditing;
using Ijuba.Webapi.Application.Catalog.Products;
using Ijuba.Webapi.Application.Common.Interfaces;
using Ijuba.Webapi.Application.IMS.Cash_Transaction;
using Ijuba.Webapi.Application.IMS.Customer;
using Ijuba.Webapi.Application.IMS.Interfaces;
using Ijuba.Webapi.Application.IMS.Stock;
using Ijuba.Webapi.Domain.IMS.Cash_Transaction;
using Ijuba.Webapi.Domain.IMS.Customer;
using Ijuba.Webapi.Infrastructure.Persistence.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Migrators.MSSQL.Migrations.Application;

namespace Ijuba.Webapi.Host.Controllers.IMS;
[Route("api/[controller]")]
[ApiController]
public class CashTransactionController : VersionNeutralApiController
{
    private readonly ApplicationDbContext _db;

    private readonly ITransactionService _imsService;
    public CashTransactionController(ApplicationDbContext db, ITransactionService imsService)
    {
        _db = db;
        _imsService = imsService;
    }

    [HttpPost("SearchCashTransAsync")]
    [MustHavePermission(FSHAction.Search, FSHResource.Products)]
    [OpenApiOperation("Search products using available filters.", "")]
    public Task<PaginationResponse<CashTransactionDto>> SearchCashTransAsync(SearchCashTransactionRequest request)
    {
        return Mediator.Send(request);
    }


    [HttpPost("SearchCashTransactionTypesAsync")]
    [MustHavePermission(FSHAction.Search, FSHResource.Customer)]
    [OpenApiOperation("Search Cash Transaction Types using available filters.", "")]
    public Task<PaginationResponse<CashTransactionTypeDto>> SearchCashTransactionTypesAsync()
    {
        var response = _imsService.GetAllCashTransactionTypes();
        return response;
    }

    [HttpPost("SearchCashTransactionsAsync")]
    [MustHavePermission(FSHAction.Search, FSHResource.Customer)]
    [OpenApiOperation("Search Cash Transactions using available filters.", "")]
    public Task<PaginationResponse<CashTransactionDto>> SearchCashTransactionsAsync()
    {
        var response = _imsService.GetAllCashTransactions();
        return response;
    }

    [HttpGet("GetAllCashTransactionsTypes")]
    [MustHavePermission(FSHAction.Search, FSHResource.Customer)]
    [OpenApiOperation("Search Cash Transactions using available filters.", "")]
    public async Task<ActionResult<List<CashTransactionTypeDto>>> GetAllCashTransactionsTypes()
    {
        List<CashTransactionTypeDto> ims = new List<CashTransactionTypeDto>();

        var cashtrantypelst = await _db.CashTransactionType.ToListAsync();

        foreach (var item in cashtrantypelst)
        {
            CashTransactionTypeDto dto = new CashTransactionTypeDto();

            dto.Id = item.Id;
            dto.Name = item.Name;
            dto.Description = item.Description;
            dto.SystemTransaction = item.SystemTransaction;
            dto.UserId = item.CreatedBy;
            ims.Add(dto);

        }

        return ims;
    }


    [HttpPost("CreateCashTransActionTypes")]
    [MustHavePermission(FSHAction.Create, FSHResource.Customer)]
    [OpenApiOperation("Create a new Cash TransAction Type", "")]
    public Task<CashTransactionTypeDto> CreateCashTransActionTypes(CashTransactionTypeDto iMSDto)
    {
        CashTransactionType cashTransactiontype = new CashTransactionType();

        cashTransactiontype.Name = iMSDto.Name;
        cashTransactiontype.Description = iMSDto.Description;
        cashTransactiontype.SystemTransaction  = iMSDto.SystemTransaction;
        cashTransactiontype.LastModifiedBy = iMSDto.UserId;
        cashTransactiontype.CreatedBy = iMSDto.UserId;
        
        _db.CashTransactionType.Add(cashTransactiontype);
        _db.SaveChanges();
        iMSDto.Id = cashTransactiontype.Id;

        return Task.FromResult(iMSDto);
    }

    [HttpPost("CreateCashTransAction")]
    [MustHavePermission(FSHAction.Create, FSHResource.Customer)]
    [OpenApiOperation("Create a new Cash TransAction Type", "")]
    public Task<CashTransactionDto> CreateCashTransAction(CashTransactionDto iMSDto)
    {
        Ijuba.Webapi.Domain.IMS.Cash_Transaction.CashTransaction cashTransaction = new Ijuba.Webapi.Domain.IMS.Cash_Transaction.CashTransaction();

        cashTransaction.CashTransactionTypeId = iMSDto.CashTransactionTypeId;
        cashTransaction.Amount = iMSDto.Amount;
        cashTransaction.Ref_Id = iMSDto.Ref_Id;
        cashTransaction.TransactionDate = iMSDto.TransactionDate;
        cashTransaction.LastModifiedBy = iMSDto.UserId;
        cashTransaction.CreatedBy = iMSDto.UserId;

        _db.CashTransaction.Add(cashTransaction);
        _db.SaveChanges();
        iMSDto.Id = cashTransaction.Id;

        return Task.FromResult(iMSDto);
    }

    [HttpPut("UpdateCashTransActionTypeAsync")]
    [MustHavePermission(FSHAction.Update, FSHResource.Customer)]
    [OpenApiOperation("Update a Cash Transaction Type.", "")]
    public async Task<ActionResult<Guid>> UpdateCashTransActionTypeAsync(CashTransactionTypeDto iMSDto)
    {
        var exCashTransType = _db.CashTransactionType.Where(y => y.Id == iMSDto.Id).FirstOrDefault();


        exCashTransType.Name = iMSDto.Name;
        exCashTransType.Description = iMSDto.Description;
        exCashTransType.SystemTransaction = iMSDto.SystemTransaction;
        exCashTransType.LastModifiedBy = iMSDto.UserId;
        exCashTransType.LastModifiedOn = DateTime.Now;

        _db.CashTransactionType.Update(exCashTransType);
        _db.SaveChanges();

        return exCashTransType.Id;
    }

    [HttpPut("UpdateCashTransActionAsync")]
    [MustHavePermission(FSHAction.Update, FSHResource.Customer)]
    [OpenApiOperation("Update a Cash Transaction.", "")]
    public async Task<ActionResult<Guid>> UpdateCashTransActionAsync(CashTransactionDto iMSDto)
    {
        var exCashTrans = _db.CashTransaction.Where(y => y.Id == iMSDto.Id).FirstOrDefault();


        exCashTrans.CashTransactionTypeId = iMSDto.CashTransactionTypeId;
        exCashTrans.TransactionDate = iMSDto.TransactionDate;
        exCashTrans.Amount = iMSDto.Amount;
        exCashTrans.Ref_Id = iMSDto.Ref_Id;
        exCashTrans.LastModifiedBy = iMSDto.UserId;
        exCashTrans.LastModifiedOn = DateTime.Now;

        _db.CashTransaction.Update(exCashTrans);
        _db.SaveChanges();

        return exCashTrans.Id;
    }

    [HttpDelete("DeleteCashTransTypeAsync")]
    [MustHavePermission(FSHAction.Delete, FSHResource.Customer)]
    [OpenApiOperation("Delete a Cash Transaction Type.", "")]
    public async Task DeleteCashTransTypeAsync(Guid id)
    {
        var extransType = _db.CashTransactionType.Where(x => x.Id == id).FirstOrDefault();

        _db.CashTransactionType.Remove(extransType);
        _db.SaveChanges(true);
    }

    [HttpDelete("DeleteCashTransactionAsync")]
    [MustHavePermission(FSHAction.Delete, FSHResource.Customer)]
    [OpenApiOperation("Delete a Cash Transaction.", "")]
    public async Task DeleteCashTransactionAsync(Guid id)
    {
        var extrans = _db.CashTransaction.Where(x => x.Id == id).FirstOrDefault();

        _db.CashTransaction.Remove(extrans);
        _db.SaveChanges(true);
    }


    //[HttpGet("GetAllCashTransActions")]
    //[OpenApiOperation("Get audit logs of currently logged in user.", "")]
    //public async Task<ActionResult<List<CashTransactionDto>>> GetAllCashTransActions()
    //{
    //    List<CashTransactionDto> cashTransactionDtos = new List<CashTransactionDto>();

    //    var trans = _db.CashTransaction.ToList();

    //    foreach (var item in trans)
    //    {
    //        CashTransactionDto Transaction = new CashTransactionDto();

    //        Transaction.CashTransactionTypeId = item.CashTransactionTypeId;
    //        Transaction.Amount = item.Amount;
    //        Transaction.Ref_Id = item.Ref_Id;
    //        Transaction.TransactionDate = item.TransactionDate;
    //        Transaction.UserId = item.CreatedBy;
    //        Transaction.Id = item.Id;

    //        cashTransactionDtos.Add(Transaction);

    //    }

    //    return cashTransactionDtos;
    //}

    [HttpGet("GetAllCashTransAuditAsync")]
    [OpenApiOperation("Get Cash Trans.", "")]
    public Task<List<CashTransactionDto>> GetAllCashTransAuditAsync()
    {

        return Mediator.Send(new GetMyCashTransactionsRequest());
    }
}
