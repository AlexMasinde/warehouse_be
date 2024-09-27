using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common.Dal;
using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace JWarehouseSystem.BackEnd.Dal
{
    public class ReceiveStockDAL : BaseDAL, IReceiveStockDAL
    {
        public void Delete(IReceiveStock t)
        {
            throw new NotImplementedException();
        }

        public void Delete(IUser audit, int ID)
        {
            throw new NotImplementedException();
        }

        public IReceiveStock Get(ref IReceiveStock t)
        {
            throw new NotImplementedException();
        }

        public DataTable Get(IReceiveStock t)
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

        public int Save(IReceiveStock t)
        {
            throw new NotImplementedException();
        }
    }
}
