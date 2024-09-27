using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
   public interface IBaseDAL<T>
    {
        int Save(T t);
        T Get(ref T t);
        void Delete(T t);
        void Delete(IUserAudit audit, int ID);
        DataTable Get(T t);
        DataTable GetListData(IUserAudit audit, int ID);
        DataTable GetUIDataPaged(IUserAudit audit, object[] args);
    }
}
