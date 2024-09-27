using JWarehouseSystem.BackEnd.Domain;
using JWarehouseSystem.Common;
using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
   
    public interface IStockCheckItem : IUserAudit
    {
        int ID { get; set; }
        int StockCheckID { get; set; }
        int ProductID { get; set; }
        int PhysicalCount { get; set; }
        int InventoryCount { get; set; }
        int WarehouseLocationID { get; set; }


    }

}
