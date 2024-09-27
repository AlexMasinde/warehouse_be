using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
   public interface IPurchaseOrder:IUserAudit 
    {
        int ID { get; set; }
        string Number { get; set; }
        string PurchaseCode { get; set; }
        string PurchaseName { get; set; }
        string BatchNo { get; set; }
        string BatchDescription { get; set; }
        string VendorCode { get; set; }
        string Vendor { get; set; }
        string VendorReference { get; set; }
        DateTime PurchaseOrderDate { get; set; }
        DateTime ExpiryDate { get; set; }
        int CurrencyID { get; set; }
        int ShipToAddressID { get; set; }
        decimal TotalCost { get; set; }
        decimal Discount { get; set; }
        int StatusID { get; set; }
       

    }
}
