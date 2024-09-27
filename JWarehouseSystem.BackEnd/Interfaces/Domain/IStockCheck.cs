using JWarehouseSystem.BackEnd.Domain;
using JWarehouseSystem.Common;
using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
   public interface IStockCheck :IUserAudit
    {
       int ID { get; set; }
       int OfficerInChargeID { get; set; } 
       string UnitOfMeasure { get; set; }
        int NumberOfUnits { get; set; }
        Frequency Frequency { get; set; }
        StockCheckStatus Status { get; set; }
       string Remarks { get; set; }
      
        
    }
   

}
