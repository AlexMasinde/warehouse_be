using JWarehouseSystem.Common;
using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
  public interface IDock:IUserAudit
    {
        int ID { get; set; }
        string DockName { get; set; }
        DockType DockType { get; set; }
        int WarehouseID { get; set; }
        string Location { get; set; }
        Position Position { get; set; }
        string Description { get; set; }
        string Size { get; set; }
        Boolean IsActive { get; set; }
       
    }
}
