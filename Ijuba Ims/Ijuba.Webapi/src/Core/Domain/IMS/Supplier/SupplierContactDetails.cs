using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Domain.IMS.Supplier;
public class SupplierContactDetails : AuditableEntity, IAggregateRoot
{
    public Guid SupplierId { get; set; }
    public string AddressLine1 { get; set; }
    public string AddressLine2 { get; set; }

    public string PostalCode { get; set; }

    public string Suburb { get; set; }

    public string City { get; set; }

    public string Province { get; set; }

    public string ContactNo { get; set; }

    public string AlternativeContactNo { get; set; }

    public string AlternativeContactNo2 { get; set; }

    public string EmailAddress { get; set; }
}
