using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace JWarehouseSystem.BackEnd.Service
{
    public class SendStockService : IBaseService<ISendStock>
    {
        public void Delete(ISendStock t)
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

        public ISendStock Get(IUser user, int ID)
        {
            throw new NotImplementedException();
        }

        public ISendStock Get(IUser user, int[] IDs)
        {
            throw new NotImplementedException();
        }

        public DataTable Get(ISendStock t)
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

        public int Save(ISendStock t)
        {
            throw new NotImplementedException();
        }

        public IList<string> Validate(ISendStock t)
        {
            throw new NotImplementedException();
        }
    }
}
