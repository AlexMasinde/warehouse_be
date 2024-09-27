using JWarehouseSystem.Common;
using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
    public interface IUnloadedGood:IUserAudit
    {
        int ID { get; set; }
        int UnloadID { get; set; }
        int ProductID { get; set; }
        int PurchaseOrderID { get; set; }
        GoodsStatus Status { get; set; }
        string Remarks { get; set; }
        bool Edited { get; set; }
        bool Deleted { get; set; }
    }
}
