using JWarehouseSystem.Common;
using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
    public interface IDocking:IUserAudit
    {
        int ID { get; set; }
        int WarehouseID { get; set; }
        int DockID { get; set; }
        string SlotLocation { get; set; }
       string Description { get; set; }
       int DockStatusID { get; set; }

       

    }
}
