using Ijuba.Webapi.Application.Common.Models;
using Ijuba.Webapi.Application.IMS.Interfaces;
using Ijuba.Webapi.Application.IMS.Supplier;
using Ijuba.Webapi.Application.Menu;
using Ijuba.Webapi.Application.Menu.Interfaces;
using Ijuba.Webapi.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijuba.Webapi.Infrastructure.Menu;
public class MenuService : PaginationFilter, IMenuService
{
    private readonly ApplicationDbContext _db;
    private int count;

    public MenuService(ApplicationDbContext db)
    {
        _db = db;
    }

    public async Task<PaginationResponse<MenuHeadingDto>> GetAllMenuHeadings()
    {
        List<MenuHeadingDto> ims = new List<MenuHeadingDto>();

        var menuHeadinglist = _db.MenuHeading.ToList();

        foreach (var item in menuHeadinglist)
        {
            MenuHeadingDto dto = new MenuHeadingDto();
            dto.Id = item.Id;
            dto.Name = item.Name;
            dto.Order = item.Order.Value;
            ims.Add(dto);

        }

        var response = new PaginationResponse<MenuHeadingDto>(ims, count, PageNumber, PageSize);

        return response;
    }

    public async Task<PaginationResponse<SubMenuDto>> GetAllSubMenus()
    {
        List<SubMenuDto> ims = new List<SubMenuDto>();

        var submenulist = _db.SubMenu.ToList();

        foreach (var item in submenulist)
        {
            SubMenuDto dto = new SubMenuDto();
            dto.Id = item.Id;
            dto.Name = item.Name;
            dto.Order = item.Order.Value;
            ims.Add(dto);

        }

        var response = new PaginationResponse<SubMenuDto>(ims, count, PageNumber, PageSize);

        return response;
    }
}
