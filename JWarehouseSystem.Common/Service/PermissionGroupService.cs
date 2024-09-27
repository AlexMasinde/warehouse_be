using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace JWarehouseSystem.Common.Service
{
    public class PermissionGroupService :IBaseService<IPermissionGroup>
    {
        IPermissionGroupDAL _dal;
        public PermissionGroupService(IPermissionGroupDAL dal)
        {
            this._dal = dal;
        }

        public void Delete(IPermissionGroup group)
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

        public IPermissionGroup Get(IUser user, int ID)
        {
            throw new NotImplementedException();
        }

        public IPermissionGroup Get(IUser user, int[] IDs)
        {
            throw new NotImplementedException();
        }

        public DataTable Get(IPermissionGroup group)
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

        public int Save(IPermissionGroup group)
        {
            throw new NotImplementedException();
        }

        public IList<string> Validate(IPermissionGroup group)
        {
            throw new NotImplementedException();
        }
    }
}
