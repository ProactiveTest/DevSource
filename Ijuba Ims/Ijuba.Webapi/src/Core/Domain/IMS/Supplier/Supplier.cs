using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Domain.IMS.Supplier;
public class Supplier : AuditableEntity, IAggregateRoot
{
    public string CompanyName { get; set; }
    public string CompanyNameTA { get; set; }
    public string AccountNo { get; set; }
    public string ClientVatRegNo { get; set; }
    public string CompanyRegNo { get; set; }
    public string VendorNo { get; set; }
    public string RepName { get; set; }
}
