using JWarehouseSystem.BackEnd.Domain;
using JWarehouseSystem.Common.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace AWMS.API.Data
{
    public static class DBInitializer
    {
        public static void Initialize(AWMSAPIDBContext context)
        {

            context.Database.EnsureCreated();
            context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT AreaPurpose ON");



            InitialDataPeople.Initialize(context);
            InitialDataStatuses.Initialize(context);
            InitialDataLocations.Initialize(context);
            InitialDataWarehouse.Initialize(context);
            InitialDataProducts.Initialize(context);
            InitialDataAddresses.Initialize(context);
            InitialDataArea.Initialize(context);
            InitialDataAreaPurpose.Initialize(context);
            InitialDataContact.Initialize(context);
            InitialDataCompany.Initialize(context);
            InitialDataDelivery.Initialize(context);
            InitialDataCompanyAddress.Initialize(context);
            InitialDataPurchaseOrder.Initialize(context);
            InitialDataReceiptLine.Initialize(context);
            InitialDataReceipt.Initialize(context);

            //Look for any Orders then create
            if (!context.Order.Any())
            {
                var orders = new Order[]
                {
                 new Order{ Number = "ORD001",
                    OrderType = "External",
                    AuthorizedByID = 1,
                    CustomerPO = "PO00012",
                    CustomerID = 1,
                    SalesPerson = "Josphat Irungu",
                    OrderDate = DateTime.Now.AddDays(-2),
                    QuoteNumber = "Qa00223",
                    ShipToAddressID = 1,
                    InvoiceToAddressID = 1,
                    CreditCardNumber = "KENX02278855",
                    OrderStatusID = 5,
                    CustomerNumber = "0002",
                    Price = 2500000,
                    ModifiedByID = 1,
                    CreatedByID = 1,
                    CreateOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                },

                 new Order{ Number = "ORD002",
                    OrderType = "Special",
                    AuthorizedByID = 1,
                    CustomerPO = "PO00014",
                    CustomerID = 1,
                    SalesPerson = "Linda Sango",
                    OrderDate = DateTime.Now,
                    QuoteNumber = "Qa00224",
                    ShipToAddressID = 1,
                    InvoiceToAddressID = 1,
                    CreditCardNumber = "EQX066445558",
                    OrderStatusID = 2,
                    CustomerNumber = "0002",
                    Price = 3600000,
                    ModifiedByID = 1,
                    CreatedByID = 1,
                    CreateOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                }

                };
                context.Order.AddRange(orders);
                context.SaveChanges();
            }


        }



    }
}
