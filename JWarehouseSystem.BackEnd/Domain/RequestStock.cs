using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common;
using JWarehouseSystem.Common.Domain;
using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JWarehouseSystem.BackEnd.Domain
{
    public class RequestStock : IRequestStock
    {
        public int ID { get; set;}
        public int RequesterID { get; set;}
        public virtual Employee Requester { get; set; }
        public string BatchNumber { get; set;}
        public bool IsCancelled { get; set;}
        public string CancellationReason { get; set;}
        public StockRequestType Type { get; set;}
        public int FromWarehouseID { get; set;}
        public virtual Warehouse FromWarehouse { get; set; }
        public int PackingAreaID { get; set;}
        public virtual PackingArea PackingArea { get; set; }
        public int ConfirmedByID { get; set;}
        public virtual Employee ConfirmedBy { get; set; }
        public string Notes { get; set;}
        public int CreatedByID { get; set; }
        public DateTime CreateOn { get; set; }
        public int ModifiedByID { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
