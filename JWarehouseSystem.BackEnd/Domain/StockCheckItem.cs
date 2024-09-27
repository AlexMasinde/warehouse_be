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
    public class StockCheckItem : IStockCheckItem
    {
        public int ID { get; set;}
        public int StockCheckID {get; set; }
        public virtual StockCheck StockCheck { get; set; }
        public int ProductID {get; set; }
        public virtual Product Product { get; set; }
        public int PhysicalCount {get; set; }
        public int InventoryCount {get; set; }
        public int WarehouseLocationID {get; set; }
        public WarehouseLocation WarehouseLocation { get; set; }

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
