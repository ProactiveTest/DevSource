using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Application.IMS.Stock;
public class StockTransactionTypeDto : IDto
{
    public Guid Id { get; set; }
    public string Description { get; set; }

    public Guid UserId { get; set; }
}
