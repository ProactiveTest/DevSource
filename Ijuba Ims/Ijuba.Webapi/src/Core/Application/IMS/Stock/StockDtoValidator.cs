using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Application.IMS.Stock;
public class StockDtoValidator :CustomValidator<StockDto>
{
    public StockDtoValidator(IStringLocalizer<StockDto> T)
    {
        RuleFor(p => p.Quantity)
            .NotEmpty()
            .GreaterThanOrEqualTo(1)
           ;

        RuleFor(p => p.CostPrice)
           .NotEmpty()
           .GreaterThanOrEqualTo(1);

        RuleFor(p => p.StockCode)
           .NotEmpty();

        RuleFor(p => p.Description)
            .NotEmpty();

        RuleFor(p => p.RetailPrice)
          .NotEmpty()
          .GreaterThanOrEqualTo(1)
          .GreaterThan(p => p.CostPrice);

                    

    }
}
