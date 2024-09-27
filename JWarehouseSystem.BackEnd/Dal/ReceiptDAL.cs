using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common.Dal;
using JWarehouseSystem.Common.Interfaces;

namespace JWarehouseSystem.BackEnd.Dal
{
    public class ReceiptDAL : BaseDAL, IReceiptDAL
    {
        public void Delete(IReceipt t)
        {
            throw new NotImplementedException();
        }

        public void Delete(IUser audit, int ID)
        {
            throw new NotImplementedException();
        }

        public IReceipt Get(ref IReceipt t)
        {
            throw new NotImplementedException();
        }

        public DataTable Get(IReceipt t)
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

        public int Save(IReceipt t)
        {
            throw new NotImplementedException();
        }
    }
}
