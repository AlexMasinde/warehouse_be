using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
   public interface IShipmentPurchaseOrder :IUserAudit
    {
        int ID { get; set; }
        int PurchaseOrderID { get; set; }
        int ShipmentID { get; set; }
        
    }
}
