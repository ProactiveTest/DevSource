using DocumentFormat.OpenXml.Bibliography;
using Ijuba.Webapi.Application.IMS.Interfaces;
using Ijuba.Webapi.Application.IMS.Supplier;
using Ijuba.Webapi.Domain.IMS.Supplier;
using Ijuba.Webapi.Infrastructure.Persistence.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ijuba.Webapi.Host.Controllers.IMS;
[Route("api/[controller]")]
[ApiController]
public class SupplierController : VersionNeutralApiController
{
    private readonly ApplicationDbContext _db;

    private readonly ISupplierService _imsService;
    public SupplierController(ApplicationDbContext db, ISupplierService imsService)
    {
        _db = db;
        _imsService = imsService;
    }

    [HttpPost("SearchSupplierAsync")]
    [MustHavePermission(FSHAction.Search, FSHResource.Supplier)]
    [OpenApiOperation("Search suppliers using available filters.", "")]
    public Task<PaginationResponse<SupplierDto>> SearchSupplierAsync()
    {

        var response = _imsService.GetAllCreditors();

        var creditor = response.Result;

        return response;

    }

    [HttpPost("CreateSupplier")]
    [MustHavePermission(FSHAction.Search, FSHResource.Supplier)]
    [OpenApiOperation("Create a new supplier ", "")]
    public Task<SupplierDto> CreateSupplier(SupplierDto iMSDto)
    {
        Supplier creditor = new Supplier();
        //creditor.Id = Guid.NewGuid();
        creditor.CompanyName = iMSDto.CompanyName;
        creditor.CompanyNameTA = iMSDto.CompanyNameTA;
        creditor.AccountNo = iMSDto.AccountNo;
        creditor.ClientVatRegNo = iMSDto.ClientVatRegNo;
        creditor.CompanyRegNo = iMSDto.CompanyRegNo;
        creditor.VendorNo = iMSDto.VendorNo;
        creditor.RepName = iMSDto.RepName;
        creditor.CreatedBy = iMSDto.CreatedBy.Value;
        creditor.LastModifiedBy = iMSDto.CreatedBy.Value;
        //creditor.CreatedOn = DateTime.Now;


        _db.Supplier.Add(creditor);
        _db.SaveChanges();
        iMSDto.SupplierId = creditor.Id;

        SupplierBankDetails bank = new SupplierBankDetails();
        //bank.Id = Guid.NewGuid();
        bank.SupplierId = creditor.Id;
        bank.BankName = iMSDto.BankName;
        bank.AccountNumber = iMSDto.AccountNumber;
        bank.BranchCode = iMSDto.BranchCode;
        bank.AccountType = iMSDto.AccountType;
        bank.CreatedBy = iMSDto.CreatedBy.Value;
        bank.LastModifiedBy = iMSDto.CreatedBy.Value;
        //bank.CreatedOn = DateTime.Now;

        _db.SupplierBankDetails.Add(bank);
        _db.SaveChanges();
        iMSDto.CreditorBankingId = bank.Id;

        SupplierContactDetails contact = new SupplierContactDetails();
       // contact.Id = Guid.NewGuid();
        contact.SupplierId = creditor.Id;
        contact.AddressLine1 = iMSDto.AddressLine1;
        contact.AddressLine2 = iMSDto.AddressLine2;
        contact.PostalCode = iMSDto.PostalCode;
        contact.Suburb = iMSDto.Suburb;
        contact.City = iMSDto.City;
        contact.Province = iMSDto.Province;
        contact.AlternativeContactNo = iMSDto.AlternativeContactNo;
        contact.AlternativeContactNo2 = iMSDto.AlternativeContactNo2;
        contact.EmailAddress = iMSDto.EmailAddress;
        contact.CreatedBy = iMSDto.CreatedBy.Value;
        contact.LastModifiedBy = iMSDto.CreatedBy.Value;
       // contact.CreatedOn = DateTime.Now;
        contact.ContactNo = iMSDto.ContactNo;

        _db.SupplierContactDetails.Add(contact);
        _db.SaveChanges();
        iMSDto.CreditorContactId = contact.Id;

        return Task.FromResult(iMSDto);
    }

    [HttpPut("{id:guid}")]
    [MustHavePermission(FSHAction.Update, FSHResource.Supplier)]
    [OpenApiOperation("Update a supplier.", "")]
    public async Task<ActionResult<Guid>> UpdateSupplierAsync(SupplierDto iMSDto, Guid id)
    {
        var exCreditor = _db.Supplier.Where(y => y.Id == id).FirstOrDefault();



        exCreditor.CompanyName = iMSDto.CompanyName;
        exCreditor.CompanyNameTA = iMSDto.CompanyNameTA;
        exCreditor.AccountNo = iMSDto.AccountNo;
        exCreditor.ClientVatRegNo = iMSDto.ClientVatRegNo;
        exCreditor.CompanyRegNo = iMSDto.CompanyRegNo;
        exCreditor.VendorNo = iMSDto.VendorNo;
        exCreditor.RepName = iMSDto.RepName;
        exCreditor.LastModifiedBy = iMSDto.LastModifiedBy.Value;
        exCreditor.LastModifiedOn = DateTime.Now;

        _db.Supplier.Update(exCreditor);
        _db.SaveChanges();


        var exbank = _db.SupplierBankDetails.Where(z => z.SupplierId == exCreditor.Id).FirstOrDefault();

        exbank.BankName = iMSDto.BankName;
        exbank.AccountNumber = iMSDto.AccountNumber;
        exbank.BranchCode = iMSDto.BranchCode;
        exbank.AccountType = iMSDto.AccountType;
        exbank.LastModifiedBy = iMSDto.LastModifiedBy.Value;
        exbank.LastModifiedOn = DateTime.Now;

        _db.SupplierBankDetails.Update(exbank);
        _db.SaveChanges();


        var excontact = _db.SupplierContactDetails.Where(t => t.SupplierId == exCreditor.Id).FirstOrDefault();
        //excontact.CreditorID = iMSDto.CreditorID;
        excontact.AddressLine1 = iMSDto.AddressLine1;
        excontact.AddressLine2 = iMSDto.AddressLine2;
        excontact.PostalCode = iMSDto.PostalCode;
        excontact.Suburb = iMSDto.Suburb;
        excontact.City = iMSDto.City;
        excontact.Province = iMSDto.Province;
        excontact.ContactNo = iMSDto.ContactNo;
        excontact.AlternativeContactNo = iMSDto.AlternativeContactNo;
        excontact.AlternativeContactNo2 = iMSDto.AlternativeContactNo2;
        excontact.EmailAddress = iMSDto.EmailAddress;
        excontact.LastModifiedBy = iMSDto.LastModifiedBy.Value;
        excontact.LastModifiedOn = DateTime.Now;

        _db.SupplierContactDetails.Update(excontact);
        _db.SaveChanges();

        return exCreditor.Id;

    }

    [HttpDelete("{id:guid}")]
    [MustHavePermission(FSHAction.Delete, FSHResource.Supplier)]
    [OpenApiOperation("Delete a supplier.", "")]
    public async Task DeleteSupplierAsync(Guid id)
    {


        var excontact = _db.SupplierContactDetails.Where(x => x.SupplierId == id).FirstOrDefault();

        _db.SupplierContactDetails.Remove(excontact);
        _db.SaveChanges(true);


        var exbank = _db.SupplierBankDetails.Where(x => x.SupplierId == id).FirstOrDefault();
        _db.SupplierBankDetails.Remove(exbank);
        _db.SaveChanges(true);

        var excred = _db.Supplier.Where(x => x.Id == id).FirstOrDefault();
        _db.Supplier.Remove(excred);
        _db.SaveChanges(true);
    }
}
