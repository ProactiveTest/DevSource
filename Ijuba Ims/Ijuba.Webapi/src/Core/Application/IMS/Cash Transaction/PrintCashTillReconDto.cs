using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Application.IMS.Cash_Transaction;
public class PrintCashTillReconDto :IDto
{
    public DateTime? startdate { get; set; }
    public DateTime? enddate { get; set; }
    
}
