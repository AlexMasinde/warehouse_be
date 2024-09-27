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
    public class Location : ILocation
    {
        public int ID { get; set;}
        public string Name { get; set;}
        public string Description { get; set;}
        [ForeignKey("Region")]
        public int RegionID { get; set;}
        public virtual Region Region { get; set;}
        public int CreatedByID { get; set;}
         [ForeignKey("CreatedByID")]
        public User CreatedBy { get; set; }
        public DateTime CreateOn { get; set;}
        public int ModifiedByID { get; set;}
        [ForeignKey("ModifiedByID")]
        public User ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set;}
        // public virtual UserAudit Audit { get; set;}
    }
}
