﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common.Dal;
using JWarehouseSystem.Common.Interfaces;

namespace JWarehouseSystem.BackEnd.Dal
{
    public class PurchaseOrderDAL : BaseDAL, IPurchaseOrderDAL
    {
        public void Delete(IPurchaseOrder t)
        {
            throw new NotImplementedException();
        }

        public void Delete(IUser audit, int ID)
        {
            throw new NotImplementedException();
        }

        public IPurchaseOrder Get(ref IPurchaseOrder t)
        {
            throw new NotImplementedException();
        }

        public DataTable Get(IPurchaseOrder t)
        {
            throw new NotImplementedException();
        }

        public DataTable GetListData(IUser audit, int ID)
        {
            throw new NotImplementedException();
        }

        public DataTable GetUIDataPaged(IUser audit, object[] args)
        {
            throw new NotImplementedException();
        }

        public int Save(IPurchaseOrder t)
        {
            throw new NotImplementedException();
        }
    }
}
