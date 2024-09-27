using JWarehouseSystem.Common;
using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
   public interface IPicking:IUserAudit
    {
        int ID { get; set; }
        int ProductID { get; set; }
        int PickingAreaID { get; set; }
      
        DateTime BegunAt { get; set; }
        DateTime CompletedAt { get; set; }
        string BatchNo { get; set; }
        int DoneByID { get; set; }
      
        PickPackStatus Status { get; set; }
       

    }
}
