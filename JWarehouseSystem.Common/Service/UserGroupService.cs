using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace JWarehouseSystem.Common.Service
{
   public class UserGroupService: IBaseService<IUserGroup>
    {
        IUserGroupDAL _dal;
        public UserGroupService(IUserGroupDAL dal)
        {
            this._dal = dal;
        }

        public void Delete(IUserGroup t)
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

        public IUserGroup Get(IUser user, int ID)
        {
            throw new NotImplementedException();
        }

        public IUserGroup Get(IUser user, int[] IDs)
        {
            throw new NotImplementedException();
        }

        public DataTable Get(IUserGroup t)
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

        public int Save(IUserGroup t)
        {
            throw new NotImplementedException();
        }

        public IList<string> Validate(IUserGroup t)
        {
            throw new NotImplementedException();
        }
    }
}
