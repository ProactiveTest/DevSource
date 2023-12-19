using Ijuba.Webapi.Application.Common.Models;
using Ijuba.Webapi.Application.IMS.Customer;
using Ijuba.Webapi.Application.IMS.Interfaces;
using Ijuba.Webapi.Application.IMS.Supplier;
using Ijuba.Webapi.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Infrastructure.IMS;
public class CustomerService : PaginationFilter, ICustomerService
{
    private readonly ApplicationDbContext _db;
    private int count;

    public CustomerService(ApplicationDbContext db)
    {
        _db = db;
    }
    public async Task<PaginationResponse<CustomerDto>> GetAllCustomers()
    {
        List<CustomerDto> ims = new List<CustomerDto>();

        var customerlist = _db.Customer.ToList();

        foreach (var item in customerlist)
        {
            CustomerDto dto = new CustomerDto();
            dto.CustomerID = item.Id;
            dto.CompanyName = item.CompanyName;
            dto.CompanyNameTA = item.CompanyNameTA;
            dto.AccountNo = item.AccountNo;
            dto.CustomerVatRegNo = item.CustomerVatRegNo;
            dto.CompanyRegNo = item.CompanyRegNo;
            dto.CustomerNo = item.CustomerNo;
            dto.CustomerContactName = item.CustomerContactName;
            dto.CreatedBy = item.CreatedBy;


            var bankingdetails = _db.CustomerBankingDetail.Where(x => x.CustomerID == item.Id).SingleOrDefault();

            dto.CustomerBankingId = bankingdetails.Id;
            dto.BankName = bankingdetails.BankName;
            dto.AccountNumber = bankingdetails.AccountNumber;
            dto.BranchCode = bankingdetails.BranchCode;
            dto.AccountType = bankingdetails.AccountType;

            //dto.BankingDetails = bankingdto;


            var contactdetails = _db.CustomerContactDetail.Where(x => x.CustomerID == item.Id).SingleOrDefault();

            dto.CustomerContactId = contactdetails.Id;
            dto.AddressLine1 = contactdetails.AddressLine1;
            dto.AddressLine2 = contactdetails.AddressLine2;
            dto.PostalCode = contactdetails.PostalCode;
            dto.Suburb = contactdetails.Suburb;
            dto.City = contactdetails.City;
            dto.AlternativeContactNo = contactdetails.AlternativeContactNo;
            dto.AlternativeContactNo2 = contactdetails.AlternativeContactNo2;
            dto.EmailAddress = contactdetails.EmailAddress;
            dto.Province = contactdetails.Province;
            dto.ContactNo = contactdetails.ContactNo;


            //dto.ContactDetails = contactdto;


            ims.Add(dto);

        }

        var response = new PaginationResponse<CustomerDto>(ims, count, PageNumber, PageSize);

        return response;
    }
}
