﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common.Interfaces;

namespace JWarehouseSystem.BackEnd.Service
{
    public class ProductService : IBaseService<IProduct>
    {
        public void Delete(IProduct t)
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

        public IProduct Get(IUser user, int ID)
        {
            throw new NotImplementedException();
        }

        public IProduct Get(IUser user, int[] IDs)
        {
            throw new NotImplementedException();
        }

        public DataTable Get(IProduct t)
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

        public int Save(IProduct t)
        {
            throw new NotImplementedException();
        }

        public IList<string> Validate(IProduct t)
        {
            throw new NotImplementedException();
        }
    }
}
