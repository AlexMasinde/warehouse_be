using JWarehouseSystem.BackEnd.Domain;
using JWarehouseSystem.Common;
using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
    public interface IStockCheckDiscrepancy : IUserAudit
    {
        int ID { get; set; }
        int StockCheckID { get; set; }
        int AssigneeID { get; set; }
        string Description { get; set; }
        string RootCause { get; set; }
        string CorrectiveMeasure { get; set; }
        bool Resolved { get; set; }
        DateTime ResolutionTime { get; set; }
        string ResolutionComment { get; set; }


    }
   

}
