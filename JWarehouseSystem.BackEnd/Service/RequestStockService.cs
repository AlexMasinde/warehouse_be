﻿using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace JWarehouseSystem.BackEnd.Service
{
    public class RequestStockService : IBaseService<IRequestStock>
    {
        public void Delete(IRequestStock t)
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

        public IRequestStock Get(IUser user, int ID)
        {
            throw new NotImplementedException();
        }

        public IRequestStock Get(IUser user, int[] IDs)
        {
            throw new NotImplementedException();
        }

        public DataTable Get(IRequestStock t)
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

        public int Save(IRequestStock t)
        {
            throw new NotImplementedException();
        }

        public IList<string> Validate(IRequestStock t)
        {
            throw new NotImplementedException();
        }
    }
}
