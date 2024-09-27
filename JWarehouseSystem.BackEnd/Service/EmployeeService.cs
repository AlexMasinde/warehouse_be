using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using JWarehouseSystem.BackEnd.Dal;
using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common.Interfaces;

namespace JWarehouseSystem.BackEnd.Service
{
   public class EmployeeService : IBaseService<IEmployee>
    {
        IEmployeeDAL _Dal;
        public EmployeeService(IEmployeeDAL employeeDAL) => this._Dal = employeeDAL;

        public EmployeeService()
        {
            this._Dal = new EmployeeDAL();
        }

        public int Save(IEmployee t)
        {
            throw new NotImplementedException();
        }

        public IEmployee Get(IUser user, int ID)
        {
            throw new NotImplementedException();
        }

        public IEmployee Get(IUser user, int[] IDs)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEmployee t)
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

        public DataTable Get(IEmployee t)
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

        public IList<string> Validate(IEmployee t)
        {
            throw new NotImplementedException();
        }
    }
}
