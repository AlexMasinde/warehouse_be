using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common.Domain;
using JWarehouseSystem.Common.Interfaces;

namespace JWarehouseSystem.BackEnd.Domain
{
    public class ReceiptLine : IReceiptLine
    {
        public int ID { get; set;}
        public string PONumber { get; set;}
        //The number of Purchase Order Lines included in a Purchase Order
        //is equal to the number of different items being ordered
        //(e.g., if Sears issues a Purchase Order for 300 units of item 12345
        //and 220 units of item 56789,
        //then the Purchase Order contains two Purchase Order Lines).
        public string POLineNumber { get; set;}
        public int ProductID { get; set;}
        public virtual Product Product { get; set; }
        public string ReceiptNumber { get; set;}
        public int QuantityOrdered { get; set;}
        public int PreviousReceipts { get; set;}
       
        public int Quantity { get; set;}
        public bool AddToInventory { get; set;}
        public string LineStatus { get; set;}
        public int CreatedByID { get; set; }
        public DateTime CreateOn { get; set; }
        public int ModifiedByID { get; set; }
         public DateTime ModifiedOn { get; set; }
    }
}
