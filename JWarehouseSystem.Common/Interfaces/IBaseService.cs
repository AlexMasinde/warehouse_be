using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace JWarehouseSystem.Common.Interfaces
{
   public interface IBaseService<T>
    {
       
        int Save(T t);
        T Get(IUser user ,int ID);
        T Get(IUser user, int[] IDs);
        void Delete(T t);
        void Delete(IUser audit, int ID);
        void Delete(IUser audit, int[] IDs);
        DataTable Get(T t);
        DataTable GetListData(IUser audit,int ID);
        DataTable GetListData(IUser audit, int[] IDs);
        DataTable GetUIDataPaged(IUser audit, object[] args);
        IList<string> Validate(T t);
    }
}
