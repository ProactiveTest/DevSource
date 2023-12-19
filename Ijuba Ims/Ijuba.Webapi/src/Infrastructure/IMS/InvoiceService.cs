using DocumentFormat.OpenXml.Wordprocessing;
using Ijuba.Webapi.Application.Common.Models;
using Ijuba.Webapi.Application.IMS.Customer;
using Ijuba.Webapi.Application.IMS.Interfaces;
using Ijuba.Webapi.Application.IMS.Invoice;
using Ijuba.Webapi.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Infrastructure.IMS;
public class InvoiceService : PaginationFilter, IInvoiceService
{
    private readonly ApplicationDbContext _db;
    private int count;

    public InvoiceService(ApplicationDbContext db, int count)
    {
        _db = db;
        this.count = count;
    }

    public async Task<PaginationResponse<InvoiceDto>> GetAllInvoices()
    {
        List<InvoiceDto> ims = new List<InvoiceDto>();

        var invoicelist = _db.Invoice.ToList();

        foreach (var item in invoicelist)
        {
            InvoiceDto dto = new InvoiceDto();
            dto.Id = item.Id;
            dto.CustomerId = item.CustomerId;
            dto.UserId = item.CreatedBy;
            dto.TotalsVat = item.TotalsVat;
            dto.TotalsDiscount = item.TotalsDiscount;
            dto.TotalDue = item.TotalDue;
            dto.Freight = item.Freight;
            dto.InvoiceNo = item.InvoiceNo;
           
            ims.Add(dto);

        }

        var response = new PaginationResponse<InvoiceDto>(ims, count, PageNumber, PageSize);

        return response;
    }


    public async Task<PaginationResponse<InvoiceLineItemsDto>> GetAllInvoiceLineItems(Guid InvoiceId)
    {
        List<InvoiceLineItemsDto> ims = new List<InvoiceLineItemsDto>();

        var invoicelinelist = _db.InvoiceLineItems.Where(z => z.InvoiceId == InvoiceId);

        foreach (var item in invoicelinelist)
        {
            InvoiceLineItemsDto dto = new InvoiceLineItemsDto();
            dto.Id = item.Id;
            dto.UserId = item.CreatedBy;
            dto.Discount = item.Discount;
            dto.Quanity = item.Quanity;
            dto.InvoiceId = item.InvoiceId;
            dto.Discount = item.Discount;
            dto.Total = item.Total;
            dto.VatTotal = item.VatTotal;
            dto.Price = item.Price;
            dto.StockCode = item.StockCode;
            dto.Description = item.Description;
            

            ims.Add(dto);

        }

        var response = new PaginationResponse<InvoiceLineItemsDto>(ims, count, PageNumber, PageSize);

        return response;
    }
}
