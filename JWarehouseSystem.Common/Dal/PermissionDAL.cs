using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace JWarehouseSystem.Common.Dal
{
  
    public class PermissionDAL : IPermissionDAL
    {
        SqlConnection _conn = Common.SQLConnection;
        public PermissionDAL()
        {
        }

        public void Delete(IPermission t)
        {
            throw new NotImplementedException();
        }

        public void Delete(IUser user, int ID)
        {
            throw new NotImplementedException();
        }

        public IPermission Get(ref IPermission t)
        {
            throw new NotImplementedException();
        }

        public DataTable Get(IPermission t)
        {
            throw new NotImplementedException();
        }

        public DataTable GetListData(IUser user, int ID)
        {
            throw new NotImplementedException();
        }

        public DataTable GetUIDataPaged(IUser user, object[] args)
        {
            throw new NotImplementedException();
        }

        public int Save(IPermission t)
        {
            throw new NotImplementedException();
        }
    }
}
