using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace JWarehouseSystem.Common.Dal
{
  
    public class PermissionGroupDAL : IBaseDAL<IPermissionGroup>
    {
        SqlConnection _conn = Common.SQLConnection;
        public PermissionGroupDAL()
        {
        }

        public void Delete(IPermissionGroup t)
        {
            throw new NotImplementedException();
        }

        public void Delete(IUser user, int ID)
        {
            throw new NotImplementedException();
        }

        public IPermissionGroup Get(ref IPermissionGroup t)
        {
            throw new NotImplementedException();
        }

        public DataTable Get(IPermissionGroup t)
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

        public int Save(IPermissionGroup t)
        {
            throw new NotImplementedException();
        }
    }
}
