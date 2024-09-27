using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common;
using JWarehouseSystem.Common.Domain;
using JWarehouseSystem.Common.Interfaces;

namespace JWarehouseSystem.BackEnd.Domain
{
    public class Area : IArea
    {
         public int ID { get; set; }
        public string Name { get; set; }
        public string Zone { get; set; }
        public AreaStatus Status { get; set; }
        public string Description { get; set; }
       
        public Collection<AreaPurpose> Purposes { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByID { get; set; }
         [ForeignKey("CreatedByID")]
        public User CreatedBy { get; set; }
        public DateTime CreateOn { get; set; }
        public int ModifiedByID { get; set; }
        [ForeignKey("ModifiedByID")]
        public User ModifiedBy { get; set; }

        public DateTime ModifiedOn { get; set; }
      
    }
    public class AreaPurpose : IAreaPurpose
    {
        
        public int ID { get; set; }
        public int AreaID { get; set; }
        [ForeignKey("AreaID")]
        public Area Area { get; set; }
        public string Purpose { get; set; }
        public int CreatedByID { get; set; }
        public DateTime CreateOn { get; set; }
        public int ModifiedByID { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
