using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.Common.Interfaces
{
   public interface IUserGroup:IUserAudit
    {
       int UserGroupID { get; set; }
       string GroupName { get; set; }
    }
}
