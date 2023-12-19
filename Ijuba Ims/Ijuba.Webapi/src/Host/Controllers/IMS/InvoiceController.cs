using Ijuba.Webapi.Application.Common.Interfaces;
using Ijuba.Webapi.Application.IMS.Interfaces;
using Ijuba.Webapi.Application.IMS.Invoice;
using Ijuba.Webapi.Application.IMS.Stock;
using Ijuba.Webapi.Infrastructure.Persistence.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ijuba.Webapi.Domain.IMS.Invoice;

namespace Ijuba.Webapi.Host.Controllers.IMS;
[Route("api/[controller]")]
[ApiController]
public class InvoiceController : VersionNeutralApiController
{
    private readonly ApplicationDbContext _db;

    public InvoiceController(ApplicationDbContext db)
    {
        _db = db;
    }


    [HttpPost("CreateInvoiceAsync")]
    [MustHavePermission(FSHAction.Create, FSHResource.Stock)]
    [OpenApiOperation("Create a new Invoice Item", "")]
    public Task<InvoiceDto> CreateInvoiceAsync(InvoiceDto iMSDto)
    {
        Invoice invoice = new Invoice();

        //invoice.Id = iMSDto.Id;
        invoice.CustomerId = iMSDto.CustomerId;
        invoice.TotalsVat = iMSDto.TotalsVat;
        invoice.TotalsDiscount = iMSDto.TotalsDiscount;
        invoice.TotalDue = iMSDto.TotalDue;
        invoice.Freight = iMSDto.Freight;
        invoice.InvoiceNo = iMSDto.InvoiceNo        ;
        invoice.CreatedBy = iMSDto.UserId ;
        invoice.LastModifiedBy = iMSDto.UserId;


        _db.Invoice.Add(invoice);
        _db.SaveChanges();
        iMSDto.Id = invoice.Id;

        return Task.FromResult(iMSDto);
    }


    [HttpPost("CreateInvoiceItemAsync")]
    [MustHavePermission(FSHAction.Create, FSHResource.Stock)]
    [OpenApiOperation("Create a new Invoice Line Item", "")]
    public Task<InvoiceLineItemsDto> CreateInvoiceItemAsync(InvoiceLineItemsDto iMSDto)
    {
        InvoiceLineItems invoicelineitem = new InvoiceLineItems();

        invoicelineitem.CreatedBy = iMSDto.UserId;
        invoicelineitem.LastModifiedBy= iMSDto.UserId;
        invoicelineitem.Discount = iMSDto.Discount;
        invoicelineitem.Quanity = iMSDto.Quanity;
        invoicelineitem.InvoiceId = iMSDto.InvoiceId;
        invoicelineitem.Discount = iMSDto.Discount;
        invoicelineitem.Total = iMSDto.Total;
        invoicelineitem.VatTotal = iMSDto.VatTotal;
        invoicelineitem.Price = iMSDto.Price;
        invoicelineitem.StockCode = iMSDto.StockCode;
        invoicelineitem.Description = iMSDto.Description;


        _db.InvoiceLineItems.Add(invoicelineitem);
        _db.SaveChanges();
        iMSDto.Id = invoicelineitem.Id;

        return Task.FromResult(iMSDto);
    }


    [HttpPut("UpdateInvoice")]
    [MustHavePermission(FSHAction.Create, FSHResource.Stock)]
    [OpenApiOperation("Update a Invoice", "")]
    public Task<InvoiceDto> UpdateInvoiceAsync(InvoiceDto iMSDto)
    {
        Invoice invoice = new Invoice();

        invoice = _db.Invoice.Where(x => x.Id == iMSDto.Id).FirstOrDefault();
        if (invoice != null)
        {
            
            invoice.CustomerId = iMSDto.CustomerId;
            invoice.TotalsVat = iMSDto.TotalsVat;
            invoice.TotalsDiscount = iMSDto.TotalsDiscount;
            invoice.TotalDue = iMSDto.TotalDue;
            invoice.Freight = iMSDto.Freight;
            invoice.InvoiceNo = iMSDto.InvoiceNo;
            invoice.LastModifiedBy = iMSDto.UserId;


            _db.Invoice.Update(invoice);
            _db.SaveChanges();
            iMSDto.Id = invoice.Id;
        }

        return Task.FromResult(iMSDto);
    }

    [HttpPut("UpdateInvoiceLineItems")]
    [MustHavePermission(FSHAction.Create, FSHResource.Stock)]
    [OpenApiOperation("Update a Invoice Line Items", "")]
    public Task<List<InvoiceLineItemsDto>> UpdateInvoiceLineItems(List<InvoiceLineItemsDto> lineitems)
    {
        InvoiceLineItems invoice = new InvoiceLineItems();
    
        //1st get list of existing items
        var invoiceid = lineitems.Select(x => x.InvoiceId).FirstOrDefault();
        var lstexistingitems = _db.InvoiceLineItems.Where(x => x.InvoiceId == invoiceid).ToList();
        //2nd delete the existing Items
        _db.InvoiceLineItems.RemoveRange(lstexistingitems);
        _db.SaveChanges();
        //3rd create new items based on the invoice


        foreach (InvoiceLineItemsDto line in lineitems)
        {
            //Create New Items
            InvoiceLineItems invoicelineitem = new InvoiceLineItems();

            invoicelineitem.CreatedBy = line.UserId;
            invoicelineitem.LastModifiedBy = line.UserId;
            invoicelineitem.Discount = line.Discount;
            invoicelineitem.Quanity = line.Quanity;
            invoicelineitem.InvoiceId = line.InvoiceId;
            invoicelineitem.Discount = line.Discount;
            invoicelineitem.Total = line.Total;
            invoicelineitem.VatTotal = line.VatTotal;
            invoicelineitem.Price = line.Price;
            invoicelineitem.StockCode = line.StockCode;
            invoicelineitem.Description = line.Description;

            _db.InvoiceLineItems.Add(invoicelineitem);
            _db.SaveChanges();
            line.Id = invoicelineitem.Id;

        }

     

        return Task.FromResult(lineitems);
    }

}
