using Finbuckle.MultiTenant;
using Ijuba.Webapi.Application.Common.Events;
using Ijuba.Webapi.Application.Common.Interfaces;
using Ijuba.Webapi.Domain.Catalog;
using Ijuba.Webapi.Domain.IMS.Cash_Transaction;
using Ijuba.Webapi.Domain.IMS.Customer;
using Ijuba.Webapi.Domain.IMS.Invoice;
using Ijuba.Webapi.Domain.IMS.Stock;
using Ijuba.Webapi.Domain.IMS.Supplier;
using Ijuba.Webapi.Domain.Menu;
using Ijuba.Webapi.Infrastructure.Persistence.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Ijuba.Webapi.Infrastructure.Persistence.Context;

public class ApplicationDbContext : BaseDbContext
{
    public ApplicationDbContext(ITenantInfo currentTenant, DbContextOptions options, ICurrentUser currentUser, ISerializerService serializer, IOptions<DatabaseSettings> dbSettings, IEventPublisher events)
        : base(currentTenant, options, currentUser, serializer, dbSettings, events)
    {
    }

    public DbSet<Product> Products => Set<Product>();
    public DbSet<Brand> Brands => Set<Brand>();

    public DbSet<Customer> Customer => Set<Customer>();
    public DbSet<CustomerBankingDetails> CustomerBankingDetail => Set<CustomerBankingDetails>();
    public DbSet<CustomerContactDetails> CustomerContactDetail => Set<CustomerContactDetails>();

    public DbSet<SupplierBankDetails> SupplierBankDetails => Set<SupplierBankDetails>();
    public DbSet<SupplierContactDetails> SupplierContactDetails => Set<SupplierContactDetails>();
    public DbSet<Supplier> Supplier => Set<Supplier>();

    public DbSet<Stock> Stock => Set<Stock>();
    public DbSet<StockTransaction> StockTransaction => Set<StockTransaction>();
    public DbSet<StockTransactionType> StockTransactionType => Set<StockTransactionType>();
    public DbSet<StockTransactionValue> StockTransactionValue => Set<StockTransactionValue>();
    public DbSet<MenuHeading> MenuHeading => Set<MenuHeading>();
    public DbSet<SubMenu> SubMenu => Set<SubMenu>();
    public DbSet<Invoice> Invoice => Set<Invoice>();
    public DbSet<InvoiceLineItems> InvoiceLineItems => Set<InvoiceLineItems>();
    public DbSet<CashTransactionType> CashTransactionType => Set<CashTransactionType>();
    public DbSet<CashTransaction> CashTransaction => Set<CashTransaction>();


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.HasDefaultSchema(SchemaNames.IMS);

        modelBuilder.Entity<CustomerBankingDetails>()
        .ToTable("CustomerBankingDetails", "IMS");

        modelBuilder.Entity<CustomerContactDetails>()
        .ToTable("CustomerContactDetails", "IMS");

        modelBuilder.Entity<Customer>()
        .ToTable("Customer", "IMS");

        modelBuilder.Entity<SupplierBankDetails>()
        .ToTable("SupplierBankDetails", "IMS");

        modelBuilder.Entity<SupplierContactDetails>()
       .ToTable("SupplierContactDetails", "IMS");

        modelBuilder.Entity<Supplier>()
       .ToTable("Supplier", "IMS");

        modelBuilder.Entity<SubMenu>()
       .ToTable("SubMenu", "IMS");

        modelBuilder.Entity<MenuHeading>()
       .ToTable("MenuHeading", "IMS");

        modelBuilder.Entity<Stock>()
      .ToTable("Stock", "IMS");

        modelBuilder.Entity<StockTransactionType>()
     .ToTable("StockTransactionType", "IMS");

        modelBuilder.Entity<StockTransactionValue>()
      .ToTable("StockTransactionValue", "IMS");

        modelBuilder.Entity<StockTransaction>()
      .ToTable("StockTransaction", "IMS");

        modelBuilder.Entity<Invoice>()
       .ToTable("Invoice", "IMS");

        modelBuilder.Entity<InvoiceLineItems>()
       .ToTable("InvoiceLineItems", "IMS");

        modelBuilder.Entity<CashTransactionType>()
       .ToTable("CashTransactionType", "IMS");

        modelBuilder.Entity<CashTransaction>()
       .ToTable("CashTransaction", "IMS");


    }
}