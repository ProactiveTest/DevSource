using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ijuba.Webapi.Application.IMS.Interfaces;
using Ijuba.Webapi.Application.IMS.Supplier;
using Ijuba.Webapi.Infrastructure.Persistence.Context;
using Ijuba.Webapi.Application.Common.Models;
using Ardalis.Specification.EntityFrameworkCore;

namespace Ijuba.Webapi.Infrastructure.IMS;
public class SupplierService: PaginationFilter, ISupplierService
{
    private readonly ApplicationDbContext _db;
    private int count;

    public SupplierService(ApplicationDbContext db)
    {
        _db = db;
    }
    public async Task<PaginationResponse<SupplierDto>> GetAllCreditors()
    {
        List<SupplierDto> ims = new List<SupplierDto>();

        var creditorlist = _db.Supplier.ToList();
        foreach (var item in creditorlist)
        {
            SupplierDto dto = new SupplierDto();
            dto.SupplierId= item.Id;
            dto.CompanyName = item.CompanyName;
            dto.CompanyNameTA = item.CompanyNameTA;
            dto.AccountNo = item.AccountNo;
            dto.ClientVatRegNo = item.ClientVatRegNo;
            dto.CompanyRegNo = item.CompanyRegNo;
            dto.VendorNo = item.VendorNo;
            dto.RepName = item.RepName;
            dto.CreatedBy = item.CreatedBy;


            var bankingdetails = _db.SupplierBankDetails.Where(x => x.SupplierId == item.Id).SingleOrDefault();
            
            dto.CreditorBankingId = bankingdetails.Id;
            dto.BankName = bankingdetails.BankName;
            dto.AccountNumber = bankingdetails.AccountNumber;
            dto.BranchCode = bankingdetails.BranchCode;
            dto.AccountType = bankingdetails.AccountType;

            //dto.BankingDetails = bankingdto;


            var contactdetails = _db.SupplierContactDetails.Where(x => x.SupplierId == item.Id).SingleOrDefault();
           
            dto.CreditorContactId = contactdetails.Id;
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

        var response = new PaginationResponse<SupplierDto>(ims, count, PageNumber, PageSize);

        return response;
    }
}
