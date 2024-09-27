using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common;
using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JWarehouseSystem.BackEnd.Domain
{
    public class PackingArea : IPackPickArea
    {
        public int ID { get; set;}
        public int WarehouseID { get; set;}
        public virtual Warehouse Warehouse { get; set; }
        public int AreaID { get; set; }
        [ForeignKey("AreaID")]
        public virtual Area Area { get; set;}
        public string Description { get; set;}
        public AreaStatus Status { get; set;}
        public string Name { get; set; }
        public string Zone { get; set; }
       
        public bool IsActive { get; set; }
        public int CreatedByID { get; set;}
        public DateTime CreateOn { get; set;}
        public int ModifiedByID { get; set;}
        public DateTime ModifiedOn { get; set;}
        public string Type { get; set; } = "Packing Area";
    }
}
