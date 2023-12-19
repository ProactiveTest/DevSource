using Ijuba.Webapi.Application.IMS.Stock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Application.IMS.Invoice;
public class InvoiceDtoValidator : CustomValidator<InvoiceDto>
{
    public InvoiceDtoValidator(IStringLocalizer<InvoiceDto> T)
    {
        RuleFor(p => p.TotalsAmount)
            .NotEmpty()
            .GreaterThanOrEqualTo(1);

        RuleFor(p => p.TotalsVat)
           .NotEmpty()
           .GreaterThanOrEqualTo(1);

        RuleFor(p => p.TotalsDiscount)
            .NotEmpty();

        RuleFor(p => p.Freight)
            .NotEmpty();

        RuleFor(p => p.TotalDue)
            .NotEmpty()
            .GreaterThanOrEqualTo(1);


    }
}
