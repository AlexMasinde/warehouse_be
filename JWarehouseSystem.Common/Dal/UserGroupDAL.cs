using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace JWarehouseSystem.Common.Dal
{
    public class UserGroupDAL : IBaseDAL<IUserGroup>
    {
        public void Delete(IUserGroup t)
        {
            throw new NotImplementedException();
        }

        public void Delete(IUser user, int ID)
        {
            throw new NotImplementedException();
        }

        public IUserGroup Get(ref IUserGroup t)
        {
            throw new NotImplementedException();
        }

        public DataTable Get(IUserGroup t)
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

        public int Save(IUserGroup t)
        {
            throw new NotImplementedException();
        }
    }
}
