using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common;
using JWarehouseSystem.Common.Domain;
using JWarehouseSystem.Common.Interfaces;

namespace JWarehouseSystem.BackEnd.Domain
{
    public class RequestTransfer : IRequestTransfer
    {
        public int ID { get; set;}
        public string RequestNumber { get; set;}
        public RequestTransferStatus Status { get; set;}
        public int FromWarehouseID { get; set;}
        public virtual Warehouse FromWarehouse { get; set; }
        public int ToWarehouseID { get; set;}
        public virtual Warehouse ToWarehouse { get; set; }
        public string Reason { get; set;}
        public DateTime DeliveryDate { get; set;}
        public int CreatedByID { get; set; }
      
        public DateTime CreateOn { get; set; }
        public int ModifiedByID { get; set; }
     
        public DateTime ModifiedOn { get; set; }
    }
}
