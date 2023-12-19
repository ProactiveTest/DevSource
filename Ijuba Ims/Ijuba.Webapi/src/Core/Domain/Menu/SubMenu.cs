using Ijuba.Webapi.Domain.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Domain.Menu;
public class SubMenu : AuditableEntity, IAggregateRoot
{
    public string Name { get;set; }
    public Guid MenuHeadingId { get; set; }
    public string Href { get; set; }
    public string? Icon { get;  set;}
    public int? Order { get; set; }
}
