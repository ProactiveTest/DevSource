using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Application.IMS.Stock;
public class StockTransactionValueDto : IDto
{
    public Guid Id { get; set; }
    public Guid StockTransactionTypeId { get; set; }

    public string Code { get; set; }

    public string Value { get; set; }

    public Guid UserId { get; set; }
}
