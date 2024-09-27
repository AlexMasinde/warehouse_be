using JWarehouseSystem.BackEnd.Domain;
using JWarehouseSystem.Common;
using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
    public interface IEquipment : IUserAudit
    {
        int ID { get; set; }
        string Name { get; set; }
        string MachineCode { get; set; }
        string Description { get; set; }
        string IsDecommissioned { get; set; }
    }

}
