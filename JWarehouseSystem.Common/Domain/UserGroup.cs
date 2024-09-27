using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.Common.Domain
{
    public class UserGroup : IUserGroup
    {
        int IUserGroup.UserGroupID { get; set; }
        string IUserGroup.GroupName { get; set; }
        int IUserAudit.CreatedByID { get; set; }
        DateTime IUserAudit.CreateOn { get; set; }
        int IUserAudit.ModifiedByID { get; set; }
        DateTime IUserAudit.ModifiedOn { get; set; }
    }
}
