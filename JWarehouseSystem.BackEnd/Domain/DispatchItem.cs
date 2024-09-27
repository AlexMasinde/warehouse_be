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
    public class DispatchItem : IDispatchItem
    {
        public int ID { get; set;}
        public int DispatchID {get; set; }
        public Dispatch Dispatch { get; set; }
        public int ProductID {get; set; }
        public Product Product { get; set; }
        public int Quantity {get; set; }
        public GoodsStatus Status {get; set; }
        public bool IsEdited {get; set; }
        public bool IsRemoved {get; set; }
        public bool IsAdded {get; set; }

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
