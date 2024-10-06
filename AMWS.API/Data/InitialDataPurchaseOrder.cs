using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using JWarehouseSystem.BackEnd.Domain;
using JWarehouseSystem.Common.Domain;

namespace AWMS.API.Data
{
    public static class InitialDataPurchaseOrder
    {
        public static void Initialize(AWMSAPIDBContext context)
        {
            if (!context.PurchaseOrder.Any())
            {
                using (IDbContextTransaction transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var purchaseOrders = new PurchaseOrder[]
                        {
                            new PurchaseOrder
                            {
                                Number = "PO001",
                                PurchaseCode = "PC001",
                                PurchaseName = "Order for Electronics",
                                BatchNo = "B001",
                                BatchDescription = "Batch 001 for Electronics",
                                VendorCode = "V001",
                                Vendor = "Vendor A",
                                VendorReference = "VR001",
                                PurchaseOrderDate = DateTime.Now.AddDays(-10),
                                ExpiryDate = DateTime.Now.AddDays(30),
                                CurrencyID = 1,
                                ShipToAddressID = 5,
                                TotalCost = 10000.00M,
                                Discount = 500.00M,
                                StatusID = 1,
                                CreatedByID = 1,
                                CreateOn = DateTime.Now.AddDays(-10),
                                ModifiedByID = 1,
                                ModifiedOn = DateTime.Now.AddDays(-5)
                            },
                            new PurchaseOrder
                            {
                                Number = "PO002",
                                PurchaseCode = "PC002",
                                PurchaseName = "Order for Office Supplies",
                                BatchNo = "B002",
                                BatchDescription = "Batch 002 for Office Supplies",
                                VendorCode = "V002",
                                Vendor = "Vendor B",
                                VendorReference = "VR002",
                                PurchaseOrderDate = DateTime.Now.AddDays(-8),
                                ExpiryDate = DateTime.Now.AddDays(40),
                                CurrencyID = 1,
                                ShipToAddressID = 5,
                                TotalCost = 5000.00M,
                                Discount = 200.00M,
                                StatusID = 1,
                                CreatedByID = 1,
                                CreateOn = DateTime.Now.AddDays(-8),
                                ModifiedByID = 1,
                                ModifiedOn = DateTime.Now.AddDays(-4)
                            }
                        };

                        context.PurchaseOrder.AddRange(purchaseOrders);
                        context.SaveChanges();

                        // Commit the transaction
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        // Rollback the transaction if something goes wrong
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}
