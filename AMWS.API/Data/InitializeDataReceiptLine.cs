using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using JWarehouseSystem.BackEnd.Domain;
using JWarehouseSystem.Common.Domain;

namespace AWMS.API.Data
{
    public static class InitialDataReceiptLine
    {
        public static void Initialize(AWMSAPIDBContext context)
        {
            if (!context.ReceiptLine.Any())
            {
                using (IDbContextTransaction transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var receiptLines = new ReceiptLine[]
                        {
                            new ReceiptLine
                            {
                                PONumber = "PO12345",
                                POLineNumber = "POL001",
                                ProductID = 1, // Ensure this Product exists
                                ReceiptNumber = "RC001",
                                QuantityOrdered = 300,
                                PreviousReceipts = 150,
                                Quantity = 100,
                                AddToInventory = true,
                                LineStatus = "Received",
                                CreatedByID = 1,
                                CreateOn = DateTime.Now.AddDays(-5),
                                ModifiedByID = 1,
                                ModifiedOn = DateTime.Now.AddDays(-3)
                            },
                            new ReceiptLine
                            {
                                PONumber = "PO12345",
                                POLineNumber = "POL002",
                                ProductID = 1, // Ensure this Product exists
                                ReceiptNumber = "RC002",
                                QuantityOrdered = 220,
                                PreviousReceipts = 50,
                                Quantity = 100,
                                AddToInventory = true,
                                LineStatus = "Pending",
                                CreatedByID = 1,
                                CreateOn = DateTime.Now.AddDays(-4),
                                ModifiedByID = 1,
                                ModifiedOn = DateTime.Now.AddDays(-2)
                            }
                        };

                        context.ReceiptLine.AddRange(receiptLines);
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
