using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading;
using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common.Interfaces;

namespace JWarehouseSystem.BackEnd.Service
{
    public class OrderService : IOrderService
    {
       private static int batchNum = 101;
        public void Delete(IOrder t)
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

        public IOrder Get(IUser user, int ID)
        {
            throw new NotImplementedException();
        }

        public IOrder Get(IUser user, int[] IDs)
        {
            throw new NotImplementedException();
        }

        public DataTable Get(IOrder t)
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

        public int Save(IOrder t)
        {
            throw new NotImplementedException();
        }

        public IList<string> Validate(IOrder t)
        {
            throw new NotImplementedException();
        }
         public static string GenerateOrderItemBatchNo() {
            Interlocked.Increment(ref batchNum);
            return String.Concat("B", batchNum.ToString()); ;
        }

        public ICollection<IOrderItem> GetOrderItems(int orderID)
        {
            throw new NotImplementedException();
        }

        public void AddItem(IOrderItem item, ICollection<IOrderItem> collection)
        {
            throw new NotImplementedException();
        }

        public void AddItems(ICollection items, ICollection<IOrderItem> collection)
        {
            throw new NotImplementedException();
        }

        public void RemoveItem(IOrderItem item, ICollection<IOrderItem> collection)
        {
            throw new NotImplementedException();
        }

        public void RemoveItems(ICollection items, ICollection<IOrderItem> collection)
        {
            throw new NotImplementedException();
        }
    }
}
