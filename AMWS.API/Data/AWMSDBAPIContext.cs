using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JWarehouseSystem.BackEnd.Domain;
using JWarehouseSystem.BackEnd.Interfaces;
using System.Reflection;
using System.Data.Entity.ModelConfiguration.Conventions;
using JWarehouseSystem.Common.Domain;
using AWMS.API.Models;
using System.Data.Entity.Infrastructure;

namespace AWMS.API.Data
{
    public class AWMSAPIDBContext : DbContext
    {
        public AWMSAPIDBContext(DbContextOptions<AWMSAPIDBContext> options)
            : base(options)
        {
        }

        public DbSet<Order> Order { get; set; }
        public DbSet<CustomerAddress> CustomerAddress { get; set; }
        public DbSet<CompanyAddress> CompanyAddress { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<SupplierAddress> SupplierAddress { get; set; }
        public DbSet<Currency> Currency { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Delivery> Delivery { get; set; }
        public DbSet<Dock> Dock { get; set; }
        public DbSet<Docking> Docking { get; set; }
        public DbSet<DockStatus> DockStatus { get; set; }
        public DbSet<Driver> Driver { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Notification> Notification { get; set; }
        public DbSet<NotificationType> NotificationType { get; set; }
        public DbSet<OrderStatus> OrderStatus { get; set; }
        public DbSet<Packing> Packing { get; set; }
        public DbSet<Picking> Picking { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<ProductCode> ProductCodes { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrder { get; set; }
        public DbSet<PurchaseOrderStatus> PurchaseOrderStatus { get; set; }
        public DbSet<Receipt> Receipt { get; set; }
        public DbSet<ReceiptLine> ReceiptLine { get; set; }
        public DbSet<ReceiveStock> ReceiveStock { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<RequestStock> RequestStock { get; set; }
        public DbSet<RequestTransfer> RequestTransfer { get; set; }
        public DbSet<SendStock> SendStock { get; set; }
        public DbSet<Carrier> Carrier { get; set; }
        public DbSet<Shipment> Shipment { get; set; }
        public DbSet<StockMovement> StockMovement { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<Warehouse> Warehouse { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Country> Country { get; set; }
        // public DbSet<LookupDataView> LookupDataView { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Designation> Designation { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<DeliveryItem> DeliveryItem { get; set; }
        public DbSet<Area> Area { get; set; }
        public DbSet<AreaPurpose> AreaPurpose { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<JWarehouseSystem.Common.Domain.UserAudit>()
             .HasNoKey();
            modelBuilder.Entity<JWarehouseSystem.Common.Domain.User>(u =>
            {
                u.HasKey(e => e.ID);
                // u.OwnsOne<User>(u1 => u1.ModifiedBy);
                u.HasOne<User>(u1 => u1.ModifiedBy).WithOne().HasForeignKey<User>(e => e.ID);

            });

            //  modelBuilder.Entity<Area>().HasMany(p => p.Purposes);

            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
      .SelectMany(t => t.GetForeignKeys())
      .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.NoAction;

            modelBuilder.Entity<Product>()
            .HasMany(p => p.ProductCodes)
            .WithOne()
            .HasForeignKey(p => p.ProductId);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
