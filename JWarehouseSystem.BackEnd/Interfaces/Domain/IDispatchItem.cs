using JWarehouseSystem.BackEnd.Domain;
using JWarehouseSystem.Common;
using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
      public interface IDispatchItem : IUserAudit
    {
        int ID { get; set; }
        int DispatchID { get; set; }
        int ProductID { get; set; }
        int Quantity { get; set; }
        GoodsStatus Status { get; set; }
        bool IsEdited { get; set; }
        bool IsRemoved { get; set; }
         bool IsAdded { get; set; }

    }
}
