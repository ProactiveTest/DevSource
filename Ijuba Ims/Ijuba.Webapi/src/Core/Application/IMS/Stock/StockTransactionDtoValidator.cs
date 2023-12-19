using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Application.IMS.Stock;
public class StockTransactionDtoValidator : CustomValidator<StockTransactionDto>
{

    public StockTransactionDtoValidator(IStringLocalizer<StockTransactionDto> T)
    { 
        RuleFor(p => p.Quantity)
            .NotEmpty()
            .GreaterThanOrEqualTo(1);

        RuleFor(p => p.StockCode)
           .NotEmpty();

        RuleFor(p => p.StockCode)
            .NotEmpty();

    }
}
