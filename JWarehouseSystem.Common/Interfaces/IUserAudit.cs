using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.Common.Interfaces
{
    public interface IUserAudit
    {
        int CreatedByID { get; set; }
        DateTime CreateOn { get; set; }
        int ModifiedByID { get; set; }
        DateTime ModifiedOn { get; set; }

    }
}
