using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common.Dal;
using JWarehouseSystem.Common.Interfaces;

namespace JWarehouseSystem.BackEnd.Dal
{
    public class PurchaseOrderStatusDAL : BaseDAL, IPurchaseOrderStatusDAL
    {
        public void Delete(IPurchaseOrderStatus t)
        {
            throw new NotImplementedException();
        }

        public void Delete(IUser audit, int ID)
        {
            throw new NotImplementedException();
        }

        public IPurchaseOrderStatus Get(ref IPurchaseOrderStatus t)
        {
            throw new NotImplementedException();
        }

        public DataTable Get(IPurchaseOrderStatus t)
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

        public int Save(IPurchaseOrderStatus t)
        {
            throw new NotImplementedException();
        }
    }
}
