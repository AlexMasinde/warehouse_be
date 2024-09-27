using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace JWarehouseSystem.Common.Interfaces
{
    public interface IBaseDAL<T>
    {
        int Save(T t);
        T Get(ref T t);
        void Delete(T t);
        void Delete(IUser audit, int ID);
       DataTable Get(T t);
       DataTable GetListData(IUser audit, int ID);
       DataTable GetUIDataPaged(IUser audit, object[] args);
    }
}
