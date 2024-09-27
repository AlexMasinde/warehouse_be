using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
  public  interface IPurchaseItem:IUserAudit
    {
        int ID { get; set; }
        int PurchaseOrderID { get; set; }
        int ProductID { get; set; }
        int Quantity { get; set; }
        bool IsRemoved { get; set; }
        bool IsAdded { get; set; }
    }

   
}
