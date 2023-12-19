using Ijuba.Webapi.Application.IMS.Stock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Application.IMS.Interfaces;
public interface IStockService : ITransientService
{
    public Task<PaginationResponse<StockDto>> GetAllStock();
}
