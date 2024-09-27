using JWarehouseSystem.BackEnd.Domain;
using JWarehouseSystem.Common;
using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
   public interface IEvent :IUserAudit
    {
       int ID { get; set; }
       string Title { get; set; }
        int EventTypeID { get; set; }
        string Description { get; set; }
        string Source { get; set; }
        int ReporterID { get; set; }
        int AssigneeID { get; set; }
        bool IsResolved { get; set; }
        string ActionTaken { get; set; }
        string Comments { get; set; }
        DateTime ResolutionTime { get; set; }
        DateTime CreationDate { get; }
        EventStatus Status { get; set; }



    }
   

}
