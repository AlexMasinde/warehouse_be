using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace JWarehouseSystem.Common.Service
{
    public class PermissionService : IBaseService<IPermission>
    {
        IPermissionDAL _dal;
        public PermissionService(IPermissionDAL dal)
        {
            this._dal = dal;
        }

        public void Delete(IPermission permission)
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

        public IPermission Get(IUser user, int ID)
        {
            throw new NotImplementedException();
        }

        public IPermission Get(IUser user, int[] IDs)
        {
            throw new NotImplementedException();
        }

        public DataTable Get(IPermission permission)
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

        public int Save(IPermission t)
        {
            throw new NotImplementedException();
        }

        public IList<string> Validate(IPermission permission)
        {
            throw new NotImplementedException();
        }
    }
}
