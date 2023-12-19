using Ijuba.Webapi.Application.IMS.Interfaces;
using Ijuba.Webapi.Application.IMS.Stock;
using Ijuba.Webapi.Application.IMS.Supplier;
using Ijuba.Webapi.Application.Menu;
using Ijuba.Webapi.Application.Menu.Interfaces;
using Ijuba.Webapi.Domain.IMS.Supplier;
using Ijuba.Webapi.Domain.Menu;
using Ijuba.Webapi.Infrastructure.Persistence.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ijuba.Webapi.Host.Controllers.Menu;
[Route("api/[controller]")]
[ApiController]
public class MenuController : VersionNeutralApiController
{
    private readonly ApplicationDbContext _db;
    private readonly IMenuService _imsService;
    public MenuController(ApplicationDbContext db, IMenuService serv)
    {
        _db = db;
        _imsService = serv;
    }

    [HttpGet("GetAllMenuHeadings")]
    [MustHavePermission(FSHAction.Search, FSHResource.Stock)]
    [OpenApiOperation("Gets a list of Menus", "")]
    public async Task<List<MenuHeadingDto>> GetAllMenuHeadings()
    {
        var MenuHeadinglist = _db.MenuHeading.ToList();
        List<MenuHeadingDto> result = new List<MenuHeadingDto>();

        foreach (var menu in MenuHeadinglist)
        {
            MenuHeadingDto dto = new MenuHeadingDto()
            {
                Id = menu.Id,
                Name = menu.Name,
                Order = menu.Order.Value
            };
            result.Add(dto);

        }

        return result;
    }

    [HttpGet("GetAllSubMenuHeadings")]
    [MustHavePermission(FSHAction.Search, FSHResource.Stock)]
    [OpenApiOperation("Gets a list of GetAllSubMenus", "")]
    public async Task<List<SubMenuDto>> GetAllSubMenuHeadings()
    {
        var MenuHeadinglist = _db.SubMenu.ToList();
        List<SubMenuDto> result = new List<SubMenuDto>();

        foreach (var menu in MenuHeadinglist)
        {
            SubMenuDto dto = new SubMenuDto()
            {
                Id = menu.Id,
                Name = menu.Name,
                MenuHeadingId = menu.MenuHeadingId, 
                Href = menu.Href, 
                Icon = menu.Icon,
                Order = menu.Order.Value
            };
         result.Add(dto);

        }
 
        return result;
    }


    [HttpGet("GetAllMenusandSubMenus")]
    [MustHavePermission(FSHAction.Search, FSHResource.Stock)]
    [OpenApiOperation("Gets a list of GetAllMenusandSubMenus", "")]
    public async Task<List<SubMenuDto>> GetAllMenusandSubMenus()
    {
        var SubHeadinglist = _db.SubMenu.ToList();
        var MenuHeadlist = _db.MenuHeading.ToList();

        List<SubMenuDto> result = new List<SubMenuDto>();

        foreach (var subMenu in SubHeadinglist)
        {
            SubMenuDto dto = new SubMenuDto()
            {
                Id = subMenu.Id,
                Name = subMenu.Name,
                MenuHeadingId = subMenu.MenuHeadingId,
                MenuHeadingName = MenuHeadlist.Where(x => x.Id == subMenu.MenuHeadingId).Select(x => x.Name).FirstOrDefault(),
                Href = subMenu.Href,
                Icon = subMenu.Icon,
                Order = subMenu.Order.Value 
            };
            result.Add(dto);

        }

        return result;
    }


    [HttpPost("SearchMenuHeadingAsync")]
    [MustHavePermission(FSHAction.Search, FSHResource.Supplier)]
    [OpenApiOperation("Search MenuHeading using available filters.", "")]
    public Task<PaginationResponse<MenuHeadingDto>> SearchMenuHeadingAsync()
    {

        var response = _imsService.GetAllMenuHeadings();

        return response;

    }

    [HttpPost("SearchSubMenuAsync")]
    [MustHavePermission(FSHAction.Search, FSHResource.Supplier)]
    [OpenApiOperation("Search submenus using available filters.", "")]
    public Task<PaginationResponse<SubMenuDto>> SearchSubMenuAsync()
    {

        var response = _imsService.GetAllSubMenus();

        return response;

    }

    [HttpPost("CreateMenuHeading")]
    [MustHavePermission(FSHAction.Search, FSHResource.Supplier)]
    [OpenApiOperation("Create a new Menu Heading ", "")]
    public Task<MenuHeadingDto> CreateMenuHeading(MenuHeadingDto iMSDto)
    {
        MenuHeading menu = new MenuHeading();

        menu.Name =  iMSDto.Name;
        menu.Order = iMSDto.Order;
        menu.CreatedBy = iMSDto.CreatedBy.Value;
        menu.LastModifiedBy = iMSDto.CreatedBy.Value;
   
        _db.MenuHeading.Add(menu);
        _db.SaveChanges();
        iMSDto.Id = menu.Id;

        return Task.FromResult(iMSDto);
    }


    [HttpPost("CreateSubMenuHeading")]
    [MustHavePermission(FSHAction.Search, FSHResource.Supplier)]
    [OpenApiOperation("Create a new Menu Heading ", "")]
    public Task<SubMenuDto> CreateSubMenuHeading(SubMenuDto iMSDto)
    {
        SubMenu menu = new SubMenu();

        menu.Name = iMSDto.Name;
        menu.MenuHeadingId = iMSDto.MenuHeadingId;
        menu.Href = iMSDto.Href;
        menu.Order = iMSDto.Order;
        menu.CreatedBy = iMSDto.CreatedBy.Value;
        menu.LastModifiedBy = iMSDto.CreatedBy.Value;

        _db.SubMenu.Add(menu);
        _db.SaveChanges();
        iMSDto.Id = menu.Id;

        return Task.FromResult(iMSDto);
    }


    [HttpPut("UpdateMenuHeadingAsync")]
    [MustHavePermission(FSHAction.Update, FSHResource.Supplier)]
    [OpenApiOperation("Update a MenuHeading.", "")]
    public async Task<ActionResult<Guid>> UpdateMenuHeadingAsync(MenuHeadingDto iMSDto, Guid id)
    {
        var exmenu = _db.MenuHeading.Where(y => y.Id == id).FirstOrDefault();

        exmenu.Name = iMSDto.Name;
        exmenu.Order = iMSDto.Order;
        exmenu.LastModifiedBy = iMSDto.LastModifiedBy.Value;
        exmenu.LastModifiedOn = System.DateTime.Now;

        _db.MenuHeading.Update(exmenu);
        _db.SaveChanges();

        return exmenu.Id;

    }

    [HttpPut("UpdateSubMenuAsync")]
    [MustHavePermission(FSHAction.Update, FSHResource.Supplier)]
    [OpenApiOperation("Update a MenuHeading.", "")]
    public async Task<ActionResult<Guid>> UpdateSubMenuAsync(SubMenuDto iMSDto, Guid id)
    {
        var exmenu = _db.SubMenu.Where(y => y.Id == id).FirstOrDefault();

        exmenu.Name = iMSDto.Name;
        exmenu.Order = iMSDto.Order;
        exmenu.MenuHeadingId = iMSDto.MenuHeadingId;
        exmenu.Href = iMSDto.Href;
        exmenu.LastModifiedBy = iMSDto.LastModifiedBy.Value;
        exmenu.LastModifiedOn = System.DateTime.Now;

        _db.SubMenu.Update(exmenu);
        _db.SaveChanges();

        return exmenu.Id;

    }

    [HttpDelete("DeleteSubMenuAsync")]
    [MustHavePermission(FSHAction.Delete, FSHResource.Supplier)]
    [OpenApiOperation("Delete a submenu.", "")]
    public async Task DeleteSubMenuAsync(Guid id)
    {


        var exsubmenu = _db.SubMenu.Where(x => x.Id == id).FirstOrDefault();

        _db.SubMenu.Remove(exsubmenu);
        _db.SaveChanges(true);

    }


    [HttpDelete("DeleteMenuHeadingAsync")]
    [MustHavePermission(FSHAction.Delete, FSHResource.Supplier)]
    [OpenApiOperation("Delete a MenuHeading.", "")]
    public async Task DeleteMenuHeadingAsync(Guid id)
    {

        var exsubmenus = _db.SubMenu.Where(x => x.MenuHeadingId == id).ToList();

        foreach(var submenu in exsubmenus)
        {
            _db.SubMenu.Remove(submenu);
        }

        var exmenu = _db.MenuHeading.Where(x => x.Id == id).FirstOrDefault();
        _db.MenuHeading.Remove(exmenu);
        _db.SaveChanges(true);

    }

}

