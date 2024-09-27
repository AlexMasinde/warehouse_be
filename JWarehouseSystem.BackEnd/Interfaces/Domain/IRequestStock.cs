using JWarehouseSystem.Common;
using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
   public interface IRequestStock :IUserAudit
    {
        int ID { get; set; }
        int RequesterID { get; set; }
        string BatchNumber { get; set; }
        bool IsCancelled { get; set; }
        string CancellationReason { get; set; }
        StockRequestType Type { get; set; }
        int FromWarehouseID { get; set; }
        int PackingAreaID { get; set; }
        int ConfirmedByID { get; set; }
        string Notes { get; set; }
      

    }
}
