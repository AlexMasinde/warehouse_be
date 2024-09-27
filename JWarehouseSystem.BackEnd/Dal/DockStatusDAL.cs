using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common.Dal;
using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace JWarehouseSystem.BackEnd.Dal
{
    public class DockStatusDAL : BaseDAL, IDockStatusDAL
    {
        public void Delete(IDockStatus t)
        {
            throw new NotImplementedException();
        }

        public void Delete(IUser audit, int ID)
        {
            throw new NotImplementedException();
        }

        public IDockStatus Get(ref IDockStatus t)
        {
            throw new NotImplementedException();
        }

        public DataTable Get(IDockStatus t)
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

        public int Save(IDockStatus t)
        {
            throw new NotImplementedException();
        }
    }
}
