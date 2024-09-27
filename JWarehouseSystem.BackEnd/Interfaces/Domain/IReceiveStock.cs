using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
   public interface IReceiveStock:IUserAudit
    {
        int ID { get; set; }
        //int AreaID { get; set; }
        int ReceiverID { get; set; }
        string ReceiptNumber { get; set; }
        string BatchNo { get; set; }
        string Description { get; set; }
        DateTime ReceiptDate { get; set; }
        int CustomerID { get; set; }
        int WarehouseID { get; set; }
        int RequestID { get; set; }
        int RequestTransferID { get; set; }
        


    }
}
