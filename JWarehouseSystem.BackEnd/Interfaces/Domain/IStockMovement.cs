using JWarehouseSystem.Common;
using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
   public interface IStockMovement :IUserAudit
    {
        int ID { get; set; }
        int RequestTransferID { get; set; }
        DateTime MovementDate { get; set; }
        int BatchNo { get; set; }

        int FromLocationID { get; set; }
        int ToLocationID { get; set; }
      
        int FromWarehouseID { get; set; }
        int ToWarehouseID { get; set; }
       MovementType MovementType { get; set; }
       MovementStatus Status { get; set; }
        int PreparedByID { get; set; }
        int AuthorizedByID { get; set; }
        string Comments { get; set; }
        bool IsDeleted { get; set; }
    }
}
