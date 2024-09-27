using JWarehouseSystem.Common;
using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
    public interface IPackPickArea
    {
        int ID { get; set; }
        int WarehouseID { get; set; }
        int AreaID { get; set; }
        string Description { get; set; }
        AreaStatus Status { get; set; }
        string Name { get; set; }
        string Zone { get; set; }
        bool IsActive { get; set; }
        string Type { get; set; }
    }
}
