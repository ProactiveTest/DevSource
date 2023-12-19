using Ijuba.Webapi.Application.Common.Models;
using Ijuba.Webapi.Application.IMS.Cash_Transaction;
using Ijuba.Webapi.Application.IMS.Customer;
using Ijuba.Webapi.Application.IMS.Interfaces;
using Ijuba.Webapi.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Infrastructure.IMS;
public class TransactionService : PaginationFilter, ITransactionService
{
    private readonly ApplicationDbContext _db;
    private int count;

    public TransactionService(ApplicationDbContext db)
    {
        _db = db;
    }

    public async Task<PaginationResponse<CashTransactionTypeDto>> GetAllCashTransactionTypes()
    {
        List<CashTransactionTypeDto> ims = new List<CashTransactionTypeDto>();

        var cashtrantypelst = _db.CashTransactionType.Where(h => h.SystemTransaction == false).ToList();

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

        var response = new PaginationResponse<CashTransactionTypeDto>(ims, count, PageNumber, PageSize);

        return response;
    }


    public async Task<PaginationResponse<CashTransactionDto>> GetAllCashTransactions()
    {
        List<CashTransactionDto> ims = new List<CashTransactionDto>();

        var cashtranlst = _db.CashTransaction.ToList();
        var tranlist = _db.CashTransactionType.ToList();

        foreach (var item in cashtranlst)
        {
            CashTransactionDto dto = new CashTransactionDto();

            dto.Id = item.Id;
            dto.CashTransactionTypeId = item.CashTransactionTypeId;
            dto.TransactionDate = item.TransactionDate;
            dto.Amount = item.Amount;
            dto.Ref_Id = item.Ref_Id;
            dto.UserId = item.CreatedBy;
            dto.CashTransactionName = tranlist.Where(x => x.Id == item.CashTransactionTypeId).FirstOrDefault().Name;

            ims.Add(dto);

        }

        var response = new PaginationResponse<CashTransactionDto>(ims, count, PageNumber, PageSize);

        return response;
    }
}
