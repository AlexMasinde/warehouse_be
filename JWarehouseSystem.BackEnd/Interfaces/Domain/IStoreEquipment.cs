using JWarehouseSystem.BackEnd.Domain;
using JWarehouseSystem.Common;
using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
  
    public interface IStoreEquipment : IUserAudit
    {
        int ID { get; set; }
        int StoreID { get; set; }
        int EquipmentID { get; set; }
        int ResponsibleID { get; set; }
        DateTime DateAssigned { get; set; }
        DateTime TimeAssigned { get; set; }

    }


}
