using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Application.IMS.Supplier;
public class SupplierDto : IDto
{
    public Guid SupplierId { get; set; }
    public string CompanyName { get; set; }
    public string CompanyNameTA { get; set; }
    public string AccountNo { get; set; }
    public string ClientVatRegNo { get; set; }
    public string CompanyRegNo { get; set; }
    public string VendorNo { get; set; }
    public string RepName { get; set; }

    public Guid CreditorContactId { get; set; }
    public string AddressLine1 { get; set; }
    public string AddressLine2 { get; set; }
    public string PostalCode { get; set; }
    public string Suburb { get; set; }
    public string City { get; set; }
    public string Province { get; set; }
    public string ContactNo { get; set; }
    public string AlternativeContactNo { get; set; }
    public string AlternativeContactNo2 { get; set; }
    public string EmailAddress { get; set; }

    public Guid CreditorBankingId { get; set; }
    public string BankName { get; set; }
    public string BranchCode { get; set; }
    public string AccountType { get; set; }
    public string AccountNumber { get; set; }
    public Guid? CreatedBy { get; set; }
    public Guid? LastModifiedBy { get; set; }

    //public CreditorBankingDetailsDto BankingDetails { get; set; } = new CreditorBankingDetailsDto();
    //public CreditorContactDetailsDto ContactDetails { get; set; } = new CreditorContactDetailsDto();
}
