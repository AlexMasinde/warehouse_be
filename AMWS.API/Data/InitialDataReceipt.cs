using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using JWarehouseSystem.BackEnd.Domain;
using JWarehouseSystem.Common.Domain;

namespace AWMS.API.Data
{
    public static class InitialDataReceipt
    {
        public static void Initialize(AWMSAPIDBContext context)
        {
            if (!context.Receipt.Any())
            {
                using (IDbContextTransaction transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var receipts = new Receipt[]
                        {
                            new Receipt
                            {
                                PurchaseOrderID = 2,  // Ensure this exists in the PurchaseOrder table
                                Quantity = 100,
                                GoodsStatus = "Accepted",
                                ReceivedByID = 1, // Ensure this Employee exists
                                Comments = "First batch received",
                                ReceiptLine = 1,
                                SupplierID = 1,  // Ensure this Supplier exists
                                ReceiptDate = DateTime.Now.AddDays(-2),
                                CreatedByID = 1,
                                CreateOn = DateTime.Now.AddDays(-2),
                                ModifiedByID = 1,
                                ModifiedOn = DateTime.Now.AddDays(-1)
                            },
                            new Receipt
                            {
                                PurchaseOrderID = 3,  // Ensure this exists in the PurchaseOrder table
                                Quantity = 50,
                                GoodsStatus = "Rejected",
                                ReceivedByID = 1, // Ensure this Employee exists
                                Comments = "Second batch rejected",
                                ReceiptLine = 1,
                                SupplierID = 1,  // Ensure this Supplier exists
                                ReceiptDate = DateTime.Now.AddDays(-1),
                                CreatedByID = 1,
                                CreateOn = DateTime.Now.AddDays(-1),
                                ModifiedByID = 1,
                                ModifiedOn = DateTime.Now
                            }
                        };

                        context.Receipt.AddRange(receipts);
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
