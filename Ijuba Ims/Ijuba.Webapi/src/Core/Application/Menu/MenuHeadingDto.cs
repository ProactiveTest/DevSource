using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Application.Menu;
public class MenuHeadingDto : IDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public int Order { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? LastModifiedBy { get; set; }
}
