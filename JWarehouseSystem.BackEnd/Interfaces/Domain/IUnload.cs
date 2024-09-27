using JWarehouseSystem.Common;
using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
    public interface IUnload:IUserAudit
    {
        int ID { get; set; }
        int ShipmentID { get; set; }
        int DockID { get; set; }
        DateTime Date { get; set; }
        DateTime Time { get; set; }
        int OfficerInChargeID { get; set; }
        int UnloadingAreaID { get; set; }
        bool HasBeenReceived { get; set; }
        UnloadingStatus Status { get; set; }
        string Remarks { get; set; }
    }
}
