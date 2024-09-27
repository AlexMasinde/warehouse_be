using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
  public  interface IReceipt :IUserAudit
    {
        int ID { get; set; }
        int PurchaseOrderID { get; set; }
        int Quantity { get; set; }
        string GoodsStatus { get; set; }
        int ReceivedByID { get; set; }
        string Comments { get; set; }
        int ReceiptLine { get; set; }
        int SupplierID { get; set; }
        DateTime ReceiptDate { get; set; }
       // int CustomerID { get; set; }
       
    }
}
