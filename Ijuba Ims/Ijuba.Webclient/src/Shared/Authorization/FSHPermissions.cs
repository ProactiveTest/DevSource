using System.Collections.ObjectModel;

namespace FSH.WebApi.Shared.Authorization;

public static class FSHAction
{
    public const string View = nameof(View);
    public const string Search = nameof(Search);
    public const string Create = nameof(Create);
    public const string Update = nameof(Update);
    public const string Delete = nameof(Delete);
    public const string Export = nameof(Export);
    public const string Generate = nameof(Generate);
    public const string Clean = nameof(Clean);
    public const string UpgradeSubscription = nameof(UpgradeSubscription);
}

public static class FSHResource
{
    public const string Tenants = nameof(Tenants);
    public const string Dashboard = nameof(Dashboard);
    public const string Hangfire = nameof(Hangfire);
    public const string Users = nameof(Users);
    public const string UserRoles = nameof(UserRoles);
    public const string Roles = nameof(Roles);
    public const string RoleClaims = nameof(RoleClaims);
    public const string Products = nameof(Products);
    public const string Brands = nameof(Brands);
    public const string PDF = nameof(PDF);
    public const string Stock = nameof(Stock);
    public const string Supplier = nameof(Supplier);
    public const string Invoice = nameof(Invoice);
    public const string Customer = nameof(Customer);
    public const string StockAdjustment = nameof(StockAdjustment);
}

public static class FSHPermissions
{
    private static readonly FSHPermission[] _all = new FSHPermission[]
    {
        new("View Dashboard", FSHAction.View, FSHResource.Dashboard),
        new("View Hangfire", FSHAction.View, FSHResource.Hangfire),
        new("View Users", FSHAction.View, FSHResource.Users),
        new("Search Users", FSHAction.Search, FSHResource.Users),
        new("Create Users", FSHAction.Create, FSHResource.Users),
        new("Update Users", FSHAction.Update, FSHResource.Users),
        new("Delete Users", FSHAction.Delete, FSHResource.Users),
        new("Export Users", FSHAction.Export, FSHResource.Users),
        new("View UserRoles", FSHAction.View, FSHResource.UserRoles),
        new("Update UserRoles", FSHAction.Update, FSHResource.UserRoles),
        new("View Roles", FSHAction.View, FSHResource.Roles),
        new("Create Roles", FSHAction.Create, FSHResource.Roles),
        new("Update Roles", FSHAction.Update, FSHResource.Roles),
        new("Delete Roles", FSHAction.Delete, FSHResource.Roles),
        new("View RoleClaims", FSHAction.View, FSHResource.RoleClaims),
        new("Update RoleClaims", FSHAction.Update, FSHResource.RoleClaims),
        new("View Products", FSHAction.View, FSHResource.Products, IsBasic: true),
        new("Search Products", FSHAction.Search, FSHResource.Products, IsBasic: true),
        new("Create Products", FSHAction.Create, FSHResource.Products),
        new("Update Products", FSHAction.Update, FSHResource.Products),
        new("Delete Products", FSHAction.Delete, FSHResource.Products),
        new("Export Products", FSHAction.Export, FSHResource.Products),
        new("View Brands", FSHAction.View, FSHResource.Brands, IsBasic: true),
        new("Search Brands", FSHAction.Search, FSHResource.Brands, IsBasic: true),
        new("Create Brands", FSHAction.Create, FSHResource.Brands),
        new("Update Brands", FSHAction.Update, FSHResource.Brands),
        new("Delete Brands", FSHAction.Delete, FSHResource.Brands),
        new("Generate Brands", FSHAction.Generate, FSHResource.Brands),
        new("Clean Brands", FSHAction.Clean, FSHResource.Brands),
        new("View Tenants", FSHAction.View, FSHResource.Tenants, IsRoot: true),
        new("Create Tenants", FSHAction.Create, FSHResource.Tenants, IsRoot: true),
        new("Update Tenants", FSHAction.Update, FSHResource.Tenants, IsRoot: true),
        new("Upgrade Tenant Subscription", FSHAction.UpgradeSubscription, FSHResource.Tenants, IsRoot: true),
        new("View Stock", FSHAction.View, FSHResource.Stock, IsBasic: true),
        new("Search Stock", FSHAction.Search, FSHResource.Stock, IsBasic: true),
        new("Create Stock", FSHAction.Create, FSHResource.Stock),
        new("Update Stock", FSHAction.Update, FSHResource.Stock),
        new("Delete Stock", FSHAction.Delete, FSHResource.Stock),
        new("Export Stock", FSHAction.Export, FSHResource.Stock),
        new("View Supplier", FSHAction.View, FSHResource.Supplier, IsBasic: true),
        new("Search Supplier", FSHAction.Search, FSHResource.Supplier, IsBasic: true),
        new("Create Supplier", FSHAction.Create, FSHResource.Supplier),
        new("Update Supplier", FSHAction.Update, FSHResource.Supplier),
        new("Delete Supplier", FSHAction.Delete, FSHResource.Supplier),
        new("Export Supplier", FSHAction.Export, FSHResource.Supplier),
        new("View PDF", FSHAction.View, FSHResource.PDF, IsBasic: true),
        new("Search PDF", FSHAction.Search, FSHResource.PDF, IsBasic: true),
        new("Create PDF", FSHAction.Create, FSHResource.PDF),
        new("Update PDF", FSHAction.Update, FSHResource.PDF),
        new("Delete PDF", FSHAction.Delete, FSHResource.PDF),
        new("Export PDF", FSHAction.Export, FSHResource.PDF),

        new("View Invoice", FSHAction.View, FSHResource.Invoice, IsBasic: true),
        new("Search Invoice", FSHAction.Search, FSHResource.Invoice, IsBasic: true),
        new("Create Invoice", FSHAction.Create, FSHResource.Invoice),
        new("Update Invoice", FSHAction.Update, FSHResource.Invoice),
        new("Delete Invoice", FSHAction.Delete, FSHResource.Invoice),
        new("Export Invoice", FSHAction.Export, FSHResource.Invoice),

        new("View Customer", FSHAction.View, FSHResource.Customer, IsBasic: true),
        new("Search Customer", FSHAction.Search, FSHResource.Customer, IsBasic: true),
        new("Create Customer", FSHAction.Create, FSHResource.Customer),
        new("Update Customer", FSHAction.Update, FSHResource.Customer),
        new("Delete Customer", FSHAction.Delete, FSHResource.Customer),
        new("Export Customer", FSHAction.Export, FSHResource.Customer),

        new("View StockAdjument", FSHAction.View, FSHResource.StockAdjustment, IsBasic: true),
        new("Search StockAdjument", FSHAction.Search, FSHResource.StockAdjustment, IsBasic: true),
        new("Create StockAdjument", FSHAction.Create, FSHResource.StockAdjustment),
        new("Update StockAdjument", FSHAction.Update, FSHResource.StockAdjustment),
        new("Delete StockAdjument", FSHAction.Delete, FSHResource.StockAdjustment),
        new("Export StockAdjument", FSHAction.Export, FSHResource.StockAdjustment)
    };

    public static IReadOnlyList<FSHPermission> All { get; } = new ReadOnlyCollection<FSHPermission>(_all);
    public static IReadOnlyList<FSHPermission> Root { get; } = new ReadOnlyCollection<FSHPermission>(_all.Where(p => p.IsRoot).ToArray());
    public static IReadOnlyList<FSHPermission> Admin { get; } = new ReadOnlyCollection<FSHPermission>(_all.Where(p => !p.IsRoot).ToArray());
    public static IReadOnlyList<FSHPermission> Basic { get; } = new ReadOnlyCollection<FSHPermission>(_all.Where(p => p.IsBasic).ToArray());
}

public record FSHPermission(string Description, string Action, string Resource, bool IsBasic = false, bool IsRoot = false)
{
    public string Name => NameFor(Action, Resource);
    public static string NameFor(string action, string resource) => $"Permissions.{resource}.{action}";
}