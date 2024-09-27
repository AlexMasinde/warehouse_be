using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using JWarehouseSystem.BackEnd.Dal;
using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common.Interfaces;

namespace JWarehouseSystem.BackEnd.Service
{
    public class DeliveryService : IBaseService<IDelivery>
    {
        IDeliveryDAL _Dal;
        public DeliveryService(IDeliveryDAL deliveryDAL) => this._Dal = deliveryDAL;

        public DeliveryService()
        {
            this._Dal = new DeliveryDAL();
        }
        public void Delete(IDelivery t)
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

        public IDelivery Get(IUser user, int ID)
        {
            throw new NotImplementedException();
        }

        public IDelivery Get(IUser user, int[] IDs)
        {
            throw new NotImplementedException();
        }

        public DataTable Get(IDelivery t)
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

        public int Save(IDelivery t)
        {
            throw new NotImplementedException();
        }

        public IList<string> Validate(IDelivery t)
        {
            throw new NotImplementedException();
        }
    }
}
