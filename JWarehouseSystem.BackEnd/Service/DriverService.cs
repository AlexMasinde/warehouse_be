using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using JWarehouseSystem.BackEnd.Dal;
using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common.Interfaces;

namespace JWarehouseSystem.BackEnd.Service
{
    public class DriverService : IBaseService<IDriver>
    {
        IDriverDAL _Dal;
        public DriverService(IDriverDAL driverDAL) => this._Dal = driverDAL;

        public DriverService()
        {
            this._Dal = new DriverDAL();
        }
        public void Delete(IDriver t)
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

        public IDriver Get(IUser user, int ID)
        {
            throw new NotImplementedException();
        }

        public IDriver Get(IUser user, int[] IDs)
        {
            throw new NotImplementedException();
        }

        public DataTable Get(IDriver t)
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

        public int Save(IDriver t)
        {
            throw new NotImplementedException();
        }

        public IList<string> Validate(IDriver t)
        {
            throw new NotImplementedException();
        }
    }
}
