using JWarehouseSystem.BackEnd.Domain;
using JWarehouseSystem.Common;
using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
   public interface IDispatch :IUserAudit
    {
       int ID { get; set; }
       int CustomerOrderID { get; set; } 
       int DockID { get; set; }
       string PickingInfo { get; set; }
       string PackingInfo { get; set; }
        DateTime IssueDate { get; set; }

        int SellerID{ get; set; }
        string DeliveryAddress { get; set; }
      
        
    }

}
