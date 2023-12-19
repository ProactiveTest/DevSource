using Ijuba.Webapi.Application.IMS.Supplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Application.Menu.Interfaces;
public interface  IMenuService : ITransientService
{
    Task<PaginationResponse<MenuHeadingDto>> GetAllMenuHeadings();

    Task<PaginationResponse<SubMenuDto>> GetAllSubMenus();
}
