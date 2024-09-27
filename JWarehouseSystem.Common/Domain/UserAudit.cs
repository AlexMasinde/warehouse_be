using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace JWarehouseSystem.Common.Domain
{

    public class UserAudit : IUserAudit
    {
        public UserAudit(int createdBy, DateTime createOn, int modifiedBy, DateTime modifiedOn)
        {
            CreatedByID = createdBy;
            CreateOn = createOn;
            ModifiedByID = modifiedBy;
            ModifiedOn = modifiedOn;
        }
        public UserAudit(int createdBy, int modifiedBy)
        {
            CreatedByID = createdBy;
            CreateOn = DateTime.Now;
            ModifiedByID = modifiedBy;
            ModifiedOn = DateTime.Now; 
        }
        public UserAudit()
        {
           CreateOn = DateTime.Now;
            ModifiedOn = DateTime.Now;
        }

        public int CreatedByID { get; set; }
        public DateTime CreateOn { get; set; }
        public int ModifiedByID { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
