using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Domain.Menu;
public class MenuHeading : AuditableEntity, IAggregateRoot
{
    public string Name { get; set; }
    public int? Order { get; set; } 
}
