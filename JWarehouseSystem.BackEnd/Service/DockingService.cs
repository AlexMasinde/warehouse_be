using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using JWarehouseSystem.BackEnd.Dal;
using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common.Interfaces;

namespace JWarehouseSystem.BackEnd.Service
{
   public class DockingService: IBaseService<IDocking>
    {
        IDockingDAL _Dal;
        public DockingService(IDockingDAL dockingDAL) => this._Dal = dockingDAL;

        public DockingService()
        {
            this._Dal = new DockingDAL();
        }

        public int Save(IDocking t)
        {
            throw new NotImplementedException();
        }

        public IDocking Get(IUser user, int ID)
        {
            throw new NotImplementedException();
        }

        public IDocking Get(IUser user, int[] IDs)
        {
            throw new NotImplementedException();
        }

        public void Delete(IDocking t)
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

        public DataTable Get(IDocking t)
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

        public IList<string> Validate(IDocking t)
        {
            throw new NotImplementedException();
        }
    }
}
