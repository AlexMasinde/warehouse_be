using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common.Domain;
using JWarehouseSystem.Common.Interfaces;

namespace JWarehouseSystem.BackEnd.Domain
{
    public class PurchaseOrder : IPurchaseOrder
    {
        public int ID { get; set;}
        public string Number { get; set;}
        public string PurchaseCode { get; set;}
        public string PurchaseName { get; set;}
        public string BatchNo { get; set;}
        public string BatchDescription { get; set;}
        public string VendorCode { get; set;}
        public string Vendor { get; set;}
        public string VendorReference { get; set;}
        public DateTime PurchaseOrderDate { get; set;}
        public DateTime ExpiryDate { get; set;}
        public int CurrencyID { get; set;}
        public virtual Currency Currency { get; set; }
        [ForeignKey("CompanyAddress")]
        public int ShipToAddressID { get; set;}
        public virtual CompanyAddress ShipToAddress { get; set;}
        public decimal TotalCost { get; set;}
        public decimal Discount { get; set;}
        public int StatusID { get; set;}
        public virtual PurchaseOrderStatus Status { get; set;}
        public int CreatedByID { get; set; }
       
        public DateTime CreateOn { get; set; }
        public int ModifiedByID { get; set; }
      
        public DateTime ModifiedOn { get; set; }
    }
}
