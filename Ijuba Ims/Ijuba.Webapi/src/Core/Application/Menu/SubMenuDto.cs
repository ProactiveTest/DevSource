using Ijuba.Webapi.Domain.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Application.Menu;
public class SubMenuDto : IDto
{
    public Guid Id { get; set; }
    public string Name { get;  set; }
    public Guid MenuHeadingId { get; set; }
    public string MenuHeadingName { get; set; }
    public string Href { get; set; }
    public string? Icon { get; set; }
    public int Order { get; set; }
    public Guid? CreatedBy { get; set; }
    public Guid? LastModifiedBy { get; set; }

}
