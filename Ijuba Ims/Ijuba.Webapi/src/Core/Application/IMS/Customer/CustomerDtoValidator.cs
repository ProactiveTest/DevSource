using Ijuba.Webapi.Domain.IMS.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ijuba.Webapi.Application.IMS.Customer;
public class CustomerDtoValidator : CustomValidator<CustomerDto>
{
    public CustomerDtoValidator(IReadRepository<Ijuba.Webapi.Domain.IMS.Customer.Customer> customerRepo, IStringLocalizer<CustomerDtoValidator> T)
    {
        RuleFor(p => p.CompanyName)
            .NotEmpty()
            .MaximumLength(75)
            .MustAsync(async (CompanyName, ct) => await customerRepo.FirstOrDefaultAsync(new CustomerByNameSpec(CompanyName), ct) is null)
                .WithMessage((_, CompanyName) => T["CompanyName {0} already Exists.", CompanyName]);

        RuleFor(p => p.CompanyNameTA)
           .NotEmpty();

        RuleFor(p => p.AccountNo)
            .NotEmpty();

        RuleFor(p => p.CustomerVatRegNo)
            .NotEmpty();

        RuleFor(p => p.CompanyRegNo)
            .NotEmpty();

        RuleFor(p => p.CustomerNo)
            .NotEmpty();

        RuleFor(p => p.CustomerContactName)
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

public class CustomerByNameSpec : Specification<Ijuba.Webapi.Domain.IMS.Customer.Customer>, ISingleResultSpecification
{
    //private readonly ApplicationDbContext _db;
    //fIND A WAY TO CONNECT THE DB or BRING IN A LIST OF OBJECT TO ITERATE OVER
    public CustomerByNameSpec(string name) =>
        Query.Where(p => p.CompanyName == name);
}
