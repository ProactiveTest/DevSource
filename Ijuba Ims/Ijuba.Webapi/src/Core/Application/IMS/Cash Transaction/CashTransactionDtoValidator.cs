using FluentValidation.Validators;
using Ijuba.Webapi.Application.IMS.Supplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Application.IMS.Cash_Transaction;
public class CashTransactionDtoValidator : CustomValidator<CashTransactionDto>
{
    public CashTransactionDtoValidator(IStringLocalizer<CashTransactionDtoValidator> T)
    {

        RuleFor(p => p.CashTransactionName)
           .NotEmpty();


        RuleFor(p => p.TransactionDate)
           .NotEmpty();

        RuleFor(p => p.Amount)
            .GreaterThanOrEqualTo(1)
            .NotEmpty();

        
    }
}
