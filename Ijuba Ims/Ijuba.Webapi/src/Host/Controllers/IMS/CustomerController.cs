using Ijuba.Webapi.Application.IMS.Cash_Transaction;
using Ijuba.Webapi.Application.IMS.Customer;
using Ijuba.Webapi.Application.IMS.Interfaces;
using Ijuba.Webapi.Application.IMS.Stock;
using Ijuba.Webapi.Application.IMS.Supplier;
using Ijuba.Webapi.Domain.IMS.Customer;
using Ijuba.Webapi.Domain.IMS.Stock;
using Ijuba.Webapi.Domain.IMS.Supplier;
using Ijuba.Webapi.Infrastructure.Persistence.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ijuba.Webapi.Host.Controllers.IMS;
[Route("api/[controller]")]
[ApiController]
public class CustomerController : VersionNeutralApiController
{
    private readonly ApplicationDbContext _db;

    private readonly ICustomerService _imsService;

    public CustomerController(ApplicationDbContext db, ICustomerService imsService)
    {
        _db = db;
        _imsService = imsService;
    }


    [HttpPost("SearchCustomerAsync")]
    [MustHavePermission(FSHAction.Search, FSHResource.Customer)]
    [OpenApiOperation("Search suppliers using available filters.", "")]
    public Task<PaginationResponse<CustomerDto>> SearchCustomerAsync()
    {

        var response = _imsService.GetAllCustomers();

        //var cus = response.Result;

        return response;

    }




    [HttpPost("CreateCustomer")]
    [MustHavePermission(FSHAction.Create, FSHResource.Customer)]
    [OpenApiOperation("Create a new Customer ", "")]
    public Task<CustomerDto> CreateCustomer(CustomerDto iMSDto)
    {
        Customer customer = new Customer();
        //creditor.Id = Guid.NewGuid();
        customer.CompanyName = iMSDto.CompanyName;
        customer.CompanyNameTA = iMSDto.CompanyNameTA;
        customer.AccountNo = iMSDto.AccountNo;
        customer.CustomerVatRegNo = iMSDto.CustomerVatRegNo;
        customer.CompanyRegNo = iMSDto.CompanyRegNo;
        customer.CustomerNo = iMSDto.CustomerNo;
        customer.CustomerContactName = iMSDto.CustomerContactName;
        customer.CreatedBy = iMSDto.CreatedBy.Value;
        customer.LastModifiedBy = iMSDto.CreatedBy.Value;
        //customer.CreatedOn = DateTime.Now;


        _db.Customer.Add(customer);
        _db.SaveChanges();
        iMSDto.CustomerID = customer.Id;

        CustomerBankingDetails bank = new CustomerBankingDetails();
        bank.CustomerID = customer.Id;
        bank.BankName = iMSDto.BankName;
        bank.AccountNumber = iMSDto.AccountNumber;
        bank.BranchCode = iMSDto.BranchCode;
        bank.AccountType = iMSDto.AccountType;
        bank.CreatedBy = iMSDto.CreatedBy.Value;
        bank.LastModifiedBy = iMSDto.CreatedBy.Value;
        //bank.CreatedOn = DateTime.Now;

        _db.CustomerBankingDetail.Add(bank);
        _db.SaveChanges();
        iMSDto.CustomerBankingId = bank.Id;

        CustomerContactDetails contact = new CustomerContactDetails();
        // contact.Id = Guid.NewGuid();
        contact.CustomerID = customer.Id;
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

        _db.CustomerContactDetail.Add(contact);
        _db.SaveChanges();
        iMSDto.CustomerContactId = contact.Id;

        return Task.FromResult(iMSDto);
    }

    [HttpPut]
    [MustHavePermission(FSHAction.Update, FSHResource.Customer)]
    [OpenApiOperation("Update a customer.", "")]
    public async Task<ActionResult<Guid>> UpdateCustomerAsync(CustomerDto iMSDto)
    {
        var exCustomer = _db.Customer.Where(y => y.Id == iMSDto.CustomerID).FirstOrDefault();



        exCustomer.CompanyName = iMSDto.CompanyName;
        exCustomer.CompanyNameTA = iMSDto.CompanyNameTA;
        exCustomer.AccountNo = iMSDto.AccountNo;
        exCustomer.CustomerVatRegNo = iMSDto.CustomerVatRegNo;
        exCustomer.CompanyRegNo = iMSDto.CompanyRegNo;
        exCustomer.CustomerNo = iMSDto.CustomerNo;
        exCustomer.CustomerContactName = iMSDto.CustomerContactName;
        exCustomer.LastModifiedBy = iMSDto.LastModifiedBy.Value;
        exCustomer.LastModifiedOn = DateTime.Now;

        _db.Customer.Update(exCustomer);
        _db.SaveChanges();


        var exbank = _db.CustomerBankingDetail.Where(z => z.CustomerID == exCustomer.Id).FirstOrDefault();

        exbank.BankName = iMSDto.BankName;
        exbank.AccountNumber = iMSDto.AccountNumber;
        exbank.BranchCode = iMSDto.BranchCode;
        exbank.AccountType = iMSDto.AccountType;
        exbank.LastModifiedBy = iMSDto.LastModifiedBy.Value;
        exbank.LastModifiedOn = DateTime.Now;

        _db.CustomerBankingDetail.Update(exbank);
        _db.SaveChanges();


        var excontact = _db.CustomerContactDetail.Where(t => t.CustomerID == exCustomer.Id).FirstOrDefault();
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

        _db.CustomerContactDetail.Update(excontact);
        _db.SaveChanges();

        return exCustomer.Id;

    }

    [HttpDelete("{id:guid}")]
    [MustHavePermission(FSHAction.Delete, FSHResource.Customer)]
    [OpenApiOperation("Delete a customer.", "")]
    public async Task DeleteCustomerAsync(Guid id)
    {


        var excustomer = _db.CustomerContactDetail.Where(x => x.CustomerID == id).FirstOrDefault();

        _db.CustomerContactDetail.Remove(excustomer);
        _db.SaveChanges(true);


        var exbank = _db.CustomerBankingDetail.Where(x => x.CustomerID == id).FirstOrDefault();
        _db.CustomerBankingDetail.Remove(exbank);
        _db.SaveChanges(true);

        var excred = _db.Customer.Where(x => x.Id == id).FirstOrDefault();
        _db.Customer.Remove(excred);
        _db.SaveChanges(true);
    }


    
}
