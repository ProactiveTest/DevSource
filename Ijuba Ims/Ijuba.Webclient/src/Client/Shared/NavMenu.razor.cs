using Ijuba.Webclient.Client.Infrastructure.Auth;
using Ijuba.Webclient.Client.Infrastructure.Common;
using FSH.WebApi.Shared.Authorization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Ijuba.Webclient.Client.Infrastructure.ApiClient;

namespace Ijuba.Webclient.Client.Shared;

public partial class NavMenu
{
    [CascadingParameter]
    protected Task<AuthenticationState> AuthState { get; set; } = default!;
    [Inject]
    protected IAuthorizationService AuthService { get; set; } = default!;

    [Inject]
    protected IMenuClient MenuClient { get; set; } = default!;

    private string? _hangfireUrl;
    private bool _canViewHangfire;
    private bool _canViewDashboard;
    private bool _canViewRoles;
    private bool _canViewUsers;
    private bool _canViewProducts;
    private bool _canViewBrands;
    private bool _canViewTenants;
    private bool _canViewSupplier;
    private bool _canViewStock;
    private bool _canViewPDF;
    private bool CanViewAdministrationGroup => _canViewUsers || _canViewRoles || _canViewTenants;

     List<SubMenuDto> Menus  = new List<SubMenuDto>();

    private Guid HeadingID = new Guid(); 

    protected override async Task OnParametersSetAsync()
    {
        _hangfireUrl = Config[ConfigNames.ApiBaseUrl] + "jobs";
        var user = (await AuthState).User;
        _canViewHangfire = await AuthService.HasPermissionAsync(user, FSHAction.View, FSHResource.Hangfire);
        _canViewDashboard = await AuthService.HasPermissionAsync(user, FSHAction.View, FSHResource.Dashboard);
        _canViewRoles = await AuthService.HasPermissionAsync(user, FSHAction.View, FSHResource.Roles);
        _canViewUsers = await AuthService.HasPermissionAsync(user, FSHAction.View, FSHResource.Users);
        _canViewProducts = await AuthService.HasPermissionAsync(user, FSHAction.View, FSHResource.Products);
        _canViewBrands = await AuthService.HasPermissionAsync(user, FSHAction.View, FSHResource.Brands);
        _canViewTenants = await AuthService.HasPermissionAsync(user, FSHAction.View, FSHResource.Tenants);
        _canViewStock = await AuthService.HasPermissionAsync(user, FSHAction.View, FSHResource.Stock);
        _canViewSupplier = await AuthService.HasPermissionAsync(user, FSHAction.View, FSHResource.Supplier);
        _canViewPDF = await AuthService.HasPermissionAsync(user, FSHAction.View, FSHResource.PDF);
    }

    protected override async Task OnInitializedAsync()
    {
        base.OnInitialized();

        var men = await MenuClient.GetAllMenusandSubMenusAsync();

        Menus = men.OrderBy (x => x.Order).ToList();
    }

}