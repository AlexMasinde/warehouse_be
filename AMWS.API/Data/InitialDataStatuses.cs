using JWarehouseSystem.BackEnd.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWMS.API.Data
{
    public static class InitialDataStatuses
    {
        public static void Initialize(AWMSAPIDBContext context)
        {
            //Look for any Dock Status then create
            if (!context.DockStatus.Any())
            {
                var statuses = new DockStatus[]
                {
                   new DockStatus{ Status="Active",CreatedByID = 1,ModifiedByID = 1,ModifiedOn = DateTime.Now,CreateOn = DateTime.Now },
                   new DockStatus{ Status="InActive",CreatedByID = 1,ModifiedByID = 1,ModifiedOn = DateTime.Now,CreateOn = DateTime.Now },
                   new DockStatus{ Status="Full",CreatedByID = 1,ModifiedByID = 1,ModifiedOn = DateTime.Now,CreateOn = DateTime.Now },
                   new DockStatus{ Status="Under Repair",CreatedByID = 1,ModifiedByID = 1,ModifiedOn = DateTime.Now,CreateOn = DateTime.Now },
                   new DockStatus{ Status="Decommissioned",CreatedByID = 1,ModifiedByID = 1,ModifiedOn = DateTime.Now,CreateOn = DateTime.Now }
                };

                context.DockStatus.AddRange(statuses);
                context.SaveChanges();
            }

            //Look for any Order Status then create
            if (!context.OrderStatus.Any())
            {
                var statuses = new OrderStatus[]
                {
                new OrderStatus{ Status="Pending",CreatedByID = 1,ModifiedByID = 1,ModifiedOn = DateTime.Now,CreateOn = DateTime.Now },
                new OrderStatus{ Status="Confirmed",CreatedByID = 1,ModifiedByID = 1,ModifiedOn = DateTime.Now,CreateOn = DateTime.Now },
                new OrderStatus{ Status="Processing",CreatedByID = 1,ModifiedByID = 1,ModifiedOn = DateTime.Now,CreateOn = DateTime.Now },
                new OrderStatus{ Status="Shipped",CreatedByID = 1,ModifiedByID = 1,ModifiedOn = DateTime.Now,CreateOn = DateTime.Now },
                new OrderStatus{ Status="Traceable",CreatedByID = 1,ModifiedByID = 1,ModifiedOn = DateTime.Now,CreateOn = DateTime.Now },
                new OrderStatus{ Status="Waiting",CreatedByID = 1,ModifiedByID = 1,ModifiedOn = DateTime.Now,CreateOn = DateTime.Now },
                new OrderStatus{ Status="In Production",CreatedByID = 1,ModifiedByID = 1,ModifiedOn = DateTime.Now,CreateOn = DateTime.Now },
                new OrderStatus{ Status="Cancelled",CreatedByID = 1,ModifiedByID = 1,ModifiedOn = DateTime.Now,CreateOn = DateTime.Now }
                };

                context.OrderStatus.AddRange(statuses);
                context.SaveChanges();
            }

            //Look for any Order Status then create
            if (!context.PurchaseOrderStatus.Any())
            {
                var statuses = new PurchaseOrderStatus[]
                {
                new PurchaseOrderStatus{ Status="PO Request",CreatedByID = 1,ModifiedByID = 1,ModifiedOn = DateTime.Now,CreateOn = DateTime.Now },
                new PurchaseOrderStatus{ Status="Waiting for Authorization",CreatedByID = 1,ModifiedByID = 1,ModifiedOn = DateTime.Now,CreateOn = DateTime.Now },
                new PurchaseOrderStatus{ Status="Authorized",CreatedByID = 1,ModifiedByID = 1,ModifiedOn = DateTime.Now,CreateOn = DateTime.Now },
                new PurchaseOrderStatus{ Status="On Order",CreatedByID = 1,ModifiedByID = 1,ModifiedOn = DateTime.Now,CreateOn = DateTime.Now }
               
                };

                context.PurchaseOrderStatus.AddRange(statuses);
                context.SaveChanges();
            }
        }
    }
}
