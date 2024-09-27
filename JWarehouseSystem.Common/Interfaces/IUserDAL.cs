using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.Common.Interfaces
{
    public interface IUserDAL : IBaseDAL<IUser>
    {
        IUser GetFromEmail(string email,string password);
        IUser GetFromUsername(string email, string password);
    }
}
