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
    public class Docking : IDocking
    {
        [Key]
        public int ID {get; set; }
        [ForeignKey("Warehouse")]
        public int WarehouseID { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        [ForeignKey("Dock")]
        public int DockID {get; set; }
        public virtual Dock Dock {get; set; }
        public string SlotLocation {get; set; }
        public string Description {get; set; }
        public virtual DockingType Type {get; set; }
      //  public virtual UserAudit Audit {get; set; }
        public int DockStatusID {get; set; }
        public virtual DockStatus DockStatus {get; set; }
        public int CreatedByID {get; set; }
      
        public DateTime CreateOn {get; set; }
        public int ModifiedByID {get; set; }
      
        public DateTime ModifiedOn {get; set; }
    }
}
