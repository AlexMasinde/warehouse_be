using JWarehouseSystem.BackEnd.Domain;
using JWarehouseSystem.Common;
using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
   
    public interface ICargoSort : IUserAudit
    {
        int ID { get; set; }
       int SortBucketID { get; set; }
        int ReceptionID { get; set; }
        int ProductID { get; set; } 
        int BatchNumber { get; set; }
        Decimal Count { get; set; }
        DateTime SortedDate { get; set; }
        DateTime SortedTime { get; set; }   
        bool IsClosed { get; set; }
        string Remarks { get; set; }

    }

}
