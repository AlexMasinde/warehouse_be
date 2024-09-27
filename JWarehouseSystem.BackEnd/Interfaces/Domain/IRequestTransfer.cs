using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using JWarehouseSystem.Common;
namespace JWarehouseSystem.BackEnd.Interfaces
{
   public interface IRequestTransfer:IUserAudit
    {
        int ID { get; set; }
        string RequestNumber { get; set; }
        RequestTransferStatus Status { get; set; }
        int FromWarehouseID { get; set; }
        int ToWarehouseID { get; set; }
        string Reason { get; set; }
        DateTime DeliveryDate { get; set; }
        
    }

  
}
