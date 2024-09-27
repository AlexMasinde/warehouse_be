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
    public class Event : IEvent
    {
        public int ID { get; set;}
        public string Title { get; set; }
        public int EventTypeID { get; set; }
        public virtual EventType EventType { get; set; }
        public string Description { get; set; }
        public string Source { get; set; }
        [ForeignKey("EmployeeID")]
        public int ReporterID { get; set; }
        public virtual Employee Reporter { get; set; }
        [ForeignKey("EmployeeID")]
        public int AssigneeID { get; set; }
        public virtual Employee Assignee { get; set; }
        public bool IsResolved { get; set; }
        public string ActionTaken { get; set; }
        public string Comments { get; set; }
        public DateTime ResolutionTime { get; set; }

        public DateTime CreationDate { get; }

        public EventStatus Status { get; set; }

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
