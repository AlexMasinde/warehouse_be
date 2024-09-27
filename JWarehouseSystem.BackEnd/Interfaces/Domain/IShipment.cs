using JWarehouseSystem.Common;
using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
   public interface IShipment :IUserAudit
    {
        int ID { get; set; }
        ShipmentType Type { get; set; }
        int CarrierID { get; set; }
        string TrackingNumber { get; set; }
        string OtherDetails { get; set; }
        int StartLegLocationID { get; set; }
        int EndLegLocationID { get; set; }
        int DockID { get; set; }
        DateTime StartDateExpected { get; set; }
        DateTime StartDateActual { get; set; }
        DateTime EndDateExpected { get; set; }
        DateTime EndDateActual { get; set; }
        
       
        

    }
   
}
