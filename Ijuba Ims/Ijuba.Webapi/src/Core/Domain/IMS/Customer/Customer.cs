using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Domain.IMS.Customer;
public class Customer : AuditableEntity, IAggregateRoot
{
    public string CompanyName { get; set; }
    public string CompanyNameTA { get; set; }
    public string AccountNo { get; set; }
    public string CustomerVatRegNo { get; set; }
    public string CompanyRegNo { get; set; }
    public string CustomerNo { get; set; }
    public string CustomerContactName { get; set; }

}