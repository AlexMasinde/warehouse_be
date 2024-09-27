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
    public class Inventory : IInventory
    {
        public int ID { get; set;}
        public int ProductID { get; set;}
        public virtual Product Product { get; set;}
        public int CurrentStock { get; set;}
        public int DamagedStock { get; set;}
        public int StockLimit { get; set;}
        public int ThreshHold { get; set;}
        public string Comment { get; set;}
        [ForeignKey("PurchaseOrder")]
        public int LastPurchaseOrderID { get; set;}
        public virtual PurchaseOrder LastPurchaseOrder { get; set;}
        public int WarehouseID { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public decimal RecentCost { get; set; }
        public DateTime LastStockUpdate { get; set; }
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
