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
    public class CargoSort : ICargoSort
    {
        public int ID { get; set;}
        public string Code { get; set;}
        public string Name { get; set;}
        public string Description { get; set;}
        public string Capacity { get; set;}
      
       
        public int SortBucketID { get; set; }
        public int ReceptionID { get; set; }
        public int ProductID { get; set; }
        public int BatchNumber { get; set; }
        public decimal Count { get; set; }
        public DateTime SortedDate { get; set; }
        public DateTime SortedTime { get; set; }
        public bool IsClosed { get; set; }
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
