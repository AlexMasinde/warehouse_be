using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using JWarehouseSystem.BackEnd.Dal;
using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common.Interfaces;

namespace JWarehouseSystem.BackEnd.Service
{
   public class InventoryService : IInventoryService
    {
        InventoryDAL _Dal;
        public InventoryService(InventoryDAL inventoryDAL) => this._Dal = inventoryDAL;

        public InventoryService()
        {
            this._Dal = new InventoryDAL();

        }

        public int Save(IInventory t)
        {
            throw new NotImplementedException();
        }

        public IInventory Get(IUser user, int ID)
        {
            throw new NotImplementedException();
        }

        public IInventory Get(IUser user, int[] IDs)
        {
            throw new NotImplementedException();
        }

        public void Delete(IInventory t)
        {
            throw new NotImplementedException();
        }

        public void Delete(IUser audit, int ID)
        {
            throw new NotImplementedException();
        }

        public void Delete(IUser audit, int[] IDs)
        {
            throw new NotImplementedException();
        }

        public DataTable Get(IInventory t)
        {
            throw new NotImplementedException();
        }

        public DataTable GetListData(IUser audit, int ID)
        {
            throw new NotImplementedException();
        }

        public DataTable GetListData(IUser audit, int[] IDs)
        {
            throw new NotImplementedException();
        }

        public DataTable GetUIDataPaged(IUser audit, object[] args)
        {
            throw new NotImplementedException();
        }

        public IList<string> Validate(IInventory t)
        {
            throw new NotImplementedException();
        }

        public void IncreaseStockQuantity(ref IInventory inventory, int quantity)
        {
            throw new NotImplementedException();
        }

        public void DecreaseStockQuantity(ref IInventory inventory, int quantity)
        {
            throw new NotImplementedException();
        }

        public void ReportBadStock(ref IInventory inventory, int quantity)
        {
            throw new NotImplementedException();
        }

        public int GetRemainingStock(int productid)
        {
            throw new NotImplementedException();
        }

        public int GetStockLimit(int productid)
        {
            throw new NotImplementedException();
        }

        public void UpdateStockLimit(ref IInventory inventory, int limit)
        {
            throw new NotImplementedException();
        }
    }
}
