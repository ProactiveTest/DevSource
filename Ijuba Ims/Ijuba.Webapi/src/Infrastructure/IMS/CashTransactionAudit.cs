using Ijuba.Webapi.Application.Auditing;
using Ijuba.Webapi.Application.IMS.Cash_Transaction;
using Ijuba.Webapi.Application.IMS.Interfaces;
using Ijuba.Webapi.Infrastructure.Persistence.Context;
using Mapster;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Infrastructure.IMS;
public class CashTransactionAudit : ICashTransactionAudit
{
    private readonly ApplicationDbContext _context;

    public CashTransactionAudit(ApplicationDbContext context) => _context = context;

    public async Task<List<CashTransactionDto>> GetUserTrailsAsync(Guid userId)
    {
        var trails = await _context.CashTransaction
            .OrderByDescending(a => a.TransactionDate)
            .Take(250)
            .ToListAsync();

        return trails.Adapt<List<CashTransactionDto>>();
    }
}
