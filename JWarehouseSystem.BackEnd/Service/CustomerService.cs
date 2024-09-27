using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common.Interfaces;

namespace JWarehouseSystem.BackEnd.Service
{
    public class CustomerService : IBaseService<ICustomer>
    {
        ICustomerDAL _Dal;
        public CustomerService(ICustomerDAL customerDAL) => this._Dal = customerDAL;

        public CustomerService()
        {
            this._Dal = new CustomerDAL();
        }
        public void Delete(ICustomer t)
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

        public ICustomer Get(IUser user, int ID)
        {
            throw new NotImplementedException();
        }

        public ICustomer Get(IUser user, int[] IDs)
        {
            throw new NotImplementedException();
        }

        public DataTable Get(ICustomer t)
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

        public int Save(ICustomer t)
        {
            throw new NotImplementedException();
        }

        public IList<string> Validate(ICustomer t)
        {
            throw new NotImplementedException();
        }
    }
}
