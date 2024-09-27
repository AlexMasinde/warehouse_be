using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
   public interface IInventory : IUserAudit
    {
        int ID { get; set; }
        int ProductID { get; set; }
        int WarehouseID { get; set; }
        int CurrentStock { get; set; }
        int DamagedStock { get; set; }
        int StockLimit { get; set; }
        int ThreshHold { get; set; }
        string Comment { get; set; }
        decimal RecentCost { get; set; }
        DateTime LastStockUpdate { get; set; }
        

    }
}
