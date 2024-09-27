using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
   public interface IInventoryService : IBaseService<IInventory>
    {
        void IncreaseStockQuantity(ref IInventory inventory,int quantity );
        void DecreaseStockQuantity(ref IInventory inventory, int quantity);
        void ReportBadStock(ref IInventory inventory, int quantity);
        int GetRemainingStock(int productid);
        int GetStockLimit(int productid);
        void UpdateStockLimit(ref IInventory inventory, int limit);
    }
}
