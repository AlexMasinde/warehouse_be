using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
    public interface IReceiptLine :IUserAudit 
    {
        int ID { get; set; }
        string PONumber { get; set; }
        string POLineNumber { get; set; }
        int ProductID { get; set; }
        string ReceiptNumber { get; set; }
        int QuantityOrdered { get; set; }
        int PreviousReceipts { get; set; }
         int Quantity { get; set; }
        Boolean AddToInventory { get; set; }
        string LineStatus { get; set; }

    }
}
