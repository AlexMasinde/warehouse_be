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
    public class StockMovement : IStockMovement
    {
        public int ID { get; set; }
        public int RequestTransferID { get; set; }
        public virtual RequestTransfer RequestTransfer {get;set;}
        public DateTime MovementDate { get; set;}
        public int BatchNo { get; set;}
        public int FromLocationID { get; set;}
        public virtual Location FromLocation { get; set; }
        public int ToLocationID { get; set;}
        public virtual Location ToLocation { get; set; }
       
        public int FromWarehouseID { get; set;}
        public virtual Warehouse FromWarehouse { get; set; }
        public int ToWarehouseID { get; set;}
        public virtual Warehouse ToWarehouse { get; set; }
        public MovementType MovementType { get; set;}
        public MovementStatus Status { get; set;}
        public int PreparedByID { get; set;}
        public virtual Employee PreparedBy { get; set; }
        public int AuthorizedByID { get; set;}
        public virtual Employee AuthorizedBy { get; set; }
        public string Comments { get; set;}
        public bool IsDeleted { get; set;}
        public int CreatedByID { get; set; }
        public DateTime CreateOn { get; set; }
        public int ModifiedByID { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
