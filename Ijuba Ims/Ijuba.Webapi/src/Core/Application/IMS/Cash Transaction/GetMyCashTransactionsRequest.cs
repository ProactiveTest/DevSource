using Ijuba.Webapi.Application.Auditing;
using Ijuba.Webapi.Application.IMS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Application.IMS.Cash_Transaction;

public class GetMyCashTransactionsRequest : IRequest<List<CashTransactionDto>>
{
}

public class GetMyCashTransactionsRequestHandler : IRequestHandler<GetMyCashTransactionsRequest, List<CashTransactionDto>>
{
    private readonly ICurrentUser _currentUser;
    private readonly ICashTransactionAudit _auditService;

    public GetMyCashTransactionsRequestHandler(ICurrentUser currentUser, ICashTransactionAudit auditService) =>
        (_currentUser, _auditService) = (currentUser, auditService);

    public Task<List<CashTransactionDto>> Handle(GetMyCashTransactionsRequest request, CancellationToken cancellationToken) =>
        _auditService.GetUserTrailsAsync(_currentUser.GetUserId());
}
