using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
   public interface IShipmentDispatch :IUserAudit
    {
       int ID { get; set; }
       int DispatchID { get; set; } 
       int ShipmentID { get; set; }
       
        
    }
}
