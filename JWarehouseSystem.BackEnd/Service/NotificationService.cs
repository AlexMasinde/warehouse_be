using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace JWarehouseSystem.BackEnd.Service
{
    public class NotificationService : IBaseService<INotification>
    {
        public void Delete(INotification t)
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

        public INotification Get(IUser user, int ID)
        {
            throw new NotImplementedException();
        }

        public INotification Get(IUser user, int[] IDs)
        {
            throw new NotImplementedException();
        }

        public DataTable Get(INotification t)
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

        public int Save(INotification t)
        {
            throw new NotImplementedException();
        }

        public IList<string> Validate(INotification t)
        {
            throw new NotImplementedException();
        }
    }
}
