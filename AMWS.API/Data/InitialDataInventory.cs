using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using JWarehouseSystem.BackEnd.Domain;
using JWarehouseSystem.Common.Domain;

namespace AWMS.API.Data
{
    public static class InitialDataInventory
    {
        public static void Initialize(AWMSAPIDBContext context)
        {
            if (!context.Inventory.Any())
            {
                using (IDbContextTransaction transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var inventories = new Inventory[]
                        {
                            new Inventory
                            {
                                ProductID = 1,
                                CurrentStock = 500,
                                DamagedStock = 10,
                                StockLimit = 1000,
                                ThreshHold = 100,
                                Comment = "Initial stock",
                                LastPurchaseOrderID = 3,
                                WarehouseID = 1,
                                RecentCost = 50.00m,
                                LastStockUpdate = DateTime.Now.AddDays(-5),
                                CreatedByID = 1,
                                CreateOn = DateTime.Now.AddDays(-5),
                                ModifiedByID = 1,
                                ModifiedOn = DateTime.Now.AddDays(-4)
                            },
                            new Inventory
                            {
                                ProductID = 1,
                                CurrentStock = 300,
                                DamagedStock = 5,
                                StockLimit = 800,
                                ThreshHold = 50,
                                Comment = "Second batch",
                                LastPurchaseOrderID = 3,
                                WarehouseID = 1,
                                RecentCost = 30.00m,
                                LastStockUpdate = DateTime.Now.AddDays(-3),
                                CreatedByID = 1,
                                CreateOn = DateTime.Now.AddDays(-3),
                                ModifiedByID = 1,
                                ModifiedOn = DateTime.Now.AddDays(-2)
                            }
                        };

                        context.Inventory.AddRange(inventories);
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