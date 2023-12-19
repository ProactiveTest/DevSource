using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Application.IMS.Customer;
public class CustomerDto : IDto
{
    public Guid CustomerID { get; set; }
    public string CompanyName { get; set; }
    public string CompanyNameTA { get; set; }
    public string AccountNo { get; set; }
    public string CustomerVatRegNo { get; set; }
    public string CompanyRegNo { get; set; }
    public string CustomerNo { get; set; }
    public string CustomerContactName { get; set; }

   
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


    public string BankName { get; set; }

    public string BranchCode { get; set; }

    public string AccountType { get; set; }

    public string AccountNumber { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? CustomerBankingId { get; set; }

    public Guid? CustomerContactId { get; set; }

    public Guid? LastModifiedBy { get; set; }
}
