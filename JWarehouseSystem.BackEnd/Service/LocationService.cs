using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common.Interfaces;

namespace JWarehouseSystem.BackEnd.Service
{
    public class LocationService : IBaseService<ILocation>
    {
        public void Delete(ILocation t)
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

        public ILocation Get(IUser user, int ID)
        {
            throw new NotImplementedException();
        }

        public ILocation Get(IUser user, int[] IDs)
        {
            throw new NotImplementedException();
        }

        public DataTable Get(ILocation t)
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

        public int Save(ILocation t)
        {
            throw new NotImplementedException();
        }

        public IList<string> Validate(ILocation t)
        {
            throw new NotImplementedException();
        }
    }
}
