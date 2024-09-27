using JWarehouseSystem.BackEnd.Dal;
using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace JWarehouseSystem.BackEnd.Service
{
    public class DockStatusService : IBaseService<IDockStatus>
    {
        IDockStatusDAL _Dal;
        public DockStatusService(IDockStatusDAL dockStatusDAL) => this._Dal = dockStatusDAL;

        public DockStatusService()
        {
            this._Dal = new DockStatusDAL();
        }
        public void Delete(IDockStatus t)
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

        public IDockStatus Get(IUser user, int ID)
        {
            throw new NotImplementedException();
        }

        public IDockStatus Get(IUser user, int[] IDs)
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

        public DataTable GetListData(IUser audit, int[] IDs)
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

        public IList<string> Validate(IDockStatus t)
        {
            throw new NotImplementedException();
        }
    }
}
