using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
    public interface IOrderItem :IUserAudit
    {
        int ID { get; set; }
       string BatchNo { get; set; }
        int ProductID { get; set; }
        int OrderID { get; set; }
        int WarehouseID { get; set; }
        int Quantity { get; set; }
        bool IsRemoved { get; set; }
        
       

                                                
    }
}
