using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using JWarehouseSystem.BackEnd.Dal;
using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common.Interfaces;

namespace JWarehouseSystem.BackEnd.Service
{
  public class AddressService : IBaseService<IAddress>
    {
        IAddressDAL _Dal;
        public AddressService(IAddressDAL addressDAL) => this._Dal = addressDAL;

        public AddressService()
        {
            this._Dal = new AddressDAL();
        }

        public void Delete(IAddress address)
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

        public IAddress Get(IUser user, int ID)
        {
            throw new NotImplementedException();
        }

        public IAddress Get(IUser user, int[] IDs)
        {
            throw new NotImplementedException();
        }

        public DataTable Get(IAddress address)
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

        public int Save(IAddress address)
        {
            throw new NotImplementedException();
        }

        public IList<string> Validate(IAddress address)
        {
            throw new NotImplementedException();
        }
    }
}
