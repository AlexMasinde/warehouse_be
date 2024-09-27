using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common.Domain;
using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JWarehouseSystem.BackEnd.Domain
{
    public class ReceiveStock : IReceiveStock
    {
        public int ID { get; set; }
        // public int AreaID { get; set;}

        public int ReceiverID { get; set; }
        public virtual Employee Receiver { get; set; }
        public string ReceiptNumber { get; set; }
        public string BatchNo { get; set; }
        public string Description { get; set; }
        public DateTime ReceiptDate { get; set; }
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }
        public int WarehouseID { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public int RequestID { get; set; }
        public virtual RequestStock Request { get; set; }
        public int RequestTransferID { get; set; }
        public virtual RequestTransfer RequestTransfer{get;set;}
        public int CreatedByID { get; set; }
      
        public DateTime CreateOn { get; set; }
        public int ModifiedByID { get; set; }
      
        public DateTime ModifiedOn { get; set; }
    }
}
