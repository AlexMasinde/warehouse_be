using JWarehouseSystem.Common;
using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
  public  interface IPacking :IUserAudit
    {
        int ID { get; set; }
        int ProductID { get; set; }
        int PackingAreaID { get; set; }
        DateTime BegunAt { get; set; }
        DateTime CompletedAt { get; set; }
        string BatchNo { get; set; }
        int DoneByID { get; set; }
           int DockID { get; set; }
       
       

    }
}
