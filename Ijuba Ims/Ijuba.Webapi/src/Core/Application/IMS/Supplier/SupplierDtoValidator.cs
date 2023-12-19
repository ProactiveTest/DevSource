using Ijuba.Webapi.Application.IMS.Customer;
using Ijuba.Webapi.Application.IMS.Supplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Application.IMS.Supplier;
public class SupplierDtoValidator : CustomValidator<SupplierDto>
{
    public SupplierDtoValidator(IStringLocalizer<SupplierDtoValidator> T)
    {
        RuleFor(p => p.CompanyName)
            .NotEmpty()
            .MaximumLength(75);
            

        RuleFor(p => p.CompanyNameTA)
           .NotEmpty();

        RuleFor(p => p.AccountNo)
            .NotEmpty();

        RuleFor(p => p.ClientVatRegNo)
            .NotEmpty();

        RuleFor(p => p.CompanyRegNo)
            .NotEmpty();

        RuleFor(p => p.VendorNo)
            .NotEmpty();

        RuleFor(p => p.RepName)
            .NotEmpty();

        RuleFor(p => p.AddressLine1)
            .NotEmpty();

        RuleFor(p => p.AddressLine2)
            .NotEmpty();

        RuleFor(p => p.PostalCode)
            .NotEmpty();


        RuleFor(p => p.Suburb)
            .NotEmpty();

        RuleFor(p => p.City)
            .NotEmpty();

        RuleFor(p => p.Province)
            .NotEmpty();

        RuleFor(p => p.ContactNo)
            .NotEmpty()
            .MaximumLength(10);

        RuleFor(p => p.AlternativeContactNo)
            .NotEmpty()
            .MaximumLength(10);

        RuleFor(p => p.AlternativeContactNo2)
            .NotEmpty()
            .MaximumLength(10);

        RuleFor(p => p.EmailAddress)
            .EmailAddress()
            .NotEmpty();

        RuleFor(p => p.BankName)
            .NotEmpty();

        RuleFor(p => p.BranchCode)
            .NotEmpty();

        RuleFor(p => p.AccountType)
            .NotEmpty();

        RuleFor(p => p.AccountNumber)
            .NotEmpty();
    }
}
