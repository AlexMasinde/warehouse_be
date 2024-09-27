using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common.Domain;
using JWarehouseSystem.Common.Interfaces;

namespace JWarehouseSystem.BackEnd.Domain
{
    public class StockCheckDiscrepancy : IStockCheckDiscrepancy
    {
        public int ID { get; set; }
        public int StockCheckID { get; set; }
        public virtual StockCheck StockCheck {get;set;}
        [ForeignKey("EmployeeID")]
        public int AssigneeID { get; set; }
        public virtual Employee Assignee { get; set; }
        public string Description { get; set; }
        public string RootCause { get; set; }
        public string CorrectiveMeasure { get; set; }
        public bool Resolved { get; set; }
        public DateTime ResolutionTime { get; set; }
        public string ResolutionComment { get; set; }

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
