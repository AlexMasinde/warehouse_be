using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common;
using JWarehouseSystem.Common.Domain;
using JWarehouseSystem.Common.Interfaces;

namespace JWarehouseSystem.BackEnd.Domain
{
    public class StockCheck : IStockCheck
    {
        public int ID { get; set;}
        [ForeignKey("EmployeeID")]
        public int OfficerInChargeID { get; set; }
        public virtual Employee OfficerInCharge { get; set; }
        public string UnitOfMeasure { get; set; }
        public int NumberOfUnits { get; set; }
        public Frequency Frequency { get; set; }
        public StockCheckStatus Status { get; set; }
        public string Remarks { get; set; }

        public int CreatedByID { get; set; }
         [ForeignKey("CreatedByID")]
        public User CreatedBy { get; set; }
        public DateTime CreateOn { get; set; }
        public int ModifiedByID { get; set; }
        [ForeignKey("ModifiedByID")]
        public User ModifiedBy { get; set; }

        public DateTime ModifiedOn { get; set; }
       
    }
}
