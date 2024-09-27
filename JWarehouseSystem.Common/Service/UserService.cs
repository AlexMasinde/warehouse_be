
using JWarehouseSystem.Common.Dal;
using JWarehouseSystem.Common.Domain;
using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace JWarehouseSystem.Common.Service
{
   public class UserService : IBaseService<IUser>
    {
        IUserDAL _Dal;

        public UserService()
        {
            _Dal=new UserDAL();
           
        }

        public UserService(IUserDAL userDAL)
        {
            this._Dal = userDAL;
        }


        public IUser LoginWithEmail(string email, string password)
        {
            IUser user = new User();
            return  user;
        }
        public IUser Login(string username, string password)
        {
            IUser user = new User();
            return user;
        }
        public void Delete(IUser t)
        {
            _Dal.Delete(t);
        }

        public void Delete(IUser audit, int ID)
        {
            _Dal.Delete(audit, ID);
        }

        public void Delete(IUser audit, int[] IDs)
        {
            throw new NotImplementedException();
        }

        public IUser Get(IUser audit, int ID)
        {
            IUser user = new User();
            _Dal.Get(ref user);

            return user;
          
        }

        public IUser Get(IUser audit, int[] IDs)
        {
            throw new NotImplementedException();
        }

        public DataTable Get(IUser user)
        {
            return _Dal.Get(user);
        }

        public DataTable GetListData(IUser audit,int ID)
        {
            return _Dal.GetListData(audit, ID);
        }

        public DataTable GetListData(IUser audit, int[] IDs)
        {
            throw new NotImplementedException();
        }

        public DataTable GetUIDataPaged(IUser audit, object[] args)
        {
            throw new NotImplementedException();
        }

        public int Save(IUser user)
        {
           return _Dal.Save(user);
        }

        public IList<string> Validate(IUser t)
        {
            throw new NotImplementedException();
        }
    }
}
