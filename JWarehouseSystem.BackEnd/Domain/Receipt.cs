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
    public class Receipt : IReceipt
    {
        public int ID { get; set; }
        [ForeignKey("PurchaseOrder")] 
        public int PurchaseOrderID { get; set; }
        public virtual PurchaseOrder PurchaseOrder { get; set; }
        public int Quantity { get; set; }
        public string GoodsStatus { get; set; }
        [ForeignKey("Employee")]
        public int ReceivedByID { get; set; }
        public virtual Employee ReceivedBy { get; set; }
        public string Comments { get; set; }
        public int ReceiptLine { get; set; }
        public int SupplierID { get; set; }
        public virtual Supplier Supplier {get;set;}
        public DateTime ReceiptDate { get; set;}
   
        public int CreatedByID { get; set; }
       public DateTime CreateOn { get; set; }
        public int ModifiedByID { get; set; }
         public DateTime ModifiedOn { get; set; }
    }
}
