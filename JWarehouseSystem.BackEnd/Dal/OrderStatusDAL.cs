using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common.Dal;
using JWarehouseSystem.Common.Interfaces;

namespace JWarehouseSystem.BackEnd.Dal
{
    public class OrderStatusDAL : BaseDAL, IOrderStatusDAL
    {
        public void Delete(IOrderStatus t)
        {
            throw new NotImplementedException();
        }

        public void Delete(IUser audit, int ID)
        {
            throw new NotImplementedException();
        }

        public IOrderStatus Get(ref IOrderStatus t)
        {
            throw new NotImplementedException();
        }

        public DataTable Get(IOrderStatus t)
        {
            throw new NotImplementedException();
        }

        public DataTable GetListData(IUser audit, int ID)
        {
            throw new NotImplementedException();
        }

        public DataTable GetUIDataPaged(IUser audit, object[] args)
        {
            throw new NotImplementedException();
        }

        public int Save(IOrderStatus t)
        {
            throw new NotImplementedException();
        }
    }
}
