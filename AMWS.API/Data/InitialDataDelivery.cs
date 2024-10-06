using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using JWarehouseSystem.BackEnd.Domain;
using JWarehouseSystem.Common.Domain;

namespace AWMS.API.Data
{
    public static class InitialDataDelivery
    {
        public static void Initialize(AWMSAPIDBContext context)
        {
            if (!context.Delivery.Any())
            {
                using (IDbContextTransaction transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var deliveries = new Delivery[]
                        {
                            new Delivery
                            {
                                DeliveryDateFrom = DateTime.Now.AddDays(-5),
                                DeliveryDateTo = DateTime.Now.AddDays(-2),
                                ReceiptNo = "R001",
                                ReceivedDate = DateTime.Now.AddDays(-1),
                                DeliverToAddressID = 1,
                                PackingSlipNo = 10001,
                                SupplierID = 1,
                                ReceivedByID = 1,
                                CartonCount = 10,
                                TrackingNumber = "TRK12345",
                                SourceDocument = "PO0001",
                                CustomerID = 1,
                                CompanyID = 1,
                                CreatedByID = 1,
                                CreateOn = DateTime.Now.AddDays(-5),
                                ModifiedByID = 1,
                                ModifiedOn = DateTime.Now.AddDays(-2)
                            },
                            new Delivery
                            {
                                DeliveryDateFrom = DateTime.Now.AddDays(-7),
                                DeliveryDateTo = DateTime.Now.AddDays(-4),
                                ReceiptNo = "R002",
                                ReceivedDate = DateTime.Now.AddDays(-3),
                                DeliverToAddressID = 1,
                                PackingSlipNo = 10002,
                                SupplierID = 1,
                                ReceivedByID = 1,
                                CartonCount = 20,
                                TrackingNumber = "TRK54321",
                                SourceDocument = "PO0002",
                                CustomerID = 1,
                                CompanyID = 1,
                                CreatedByID = 1,
                                CreateOn = DateTime.Now.AddDays(-7),
                                ModifiedByID = 1,
                                ModifiedOn = DateTime.Now.AddDays(-4)
                            }
                        };

                        context.Delivery.AddRange(deliveries);
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
