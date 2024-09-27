using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using JWarehouseSystem.BackEnd.Dal;
using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common.Interfaces;

namespace JWarehouseSystem.BackEnd.Domain
{
   public class DockService: IBaseService<IDock>
    {
        IDockDAL _Dal;
        public DockService(IDockDAL dockDAL) => this._Dal = dockDAL;

        public DockService()
        {
            this._Dal = new DockDAL();
        }

        public int Save(IDock t)
        {
            throw new NotImplementedException();
        }

        public IDock Get(IUser user, int ID)
        {
            throw new NotImplementedException();
        }

        public IDock Get(IUser user, int[] IDs)
        {
            throw new NotImplementedException();
        }

        public void Delete(IDock t)
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

        public DataTable Get(IDock t)
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

        public IList<string> Validate(IDock t)
        {
            throw new NotImplementedException();
        }
    }
}
