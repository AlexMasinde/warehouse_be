using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common;
using JWarehouseSystem.Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JWarehouseSystem.BackEnd.Domain
{
    public class UnloadedGood : IUnloadedGood
    {
        public int ID { get; set; }
        public int UnloadID { get; set; }
        [ForeignKey("UnloadID")]
        public Unload Unloading { get; set; }
        public int ProductID { get; set; }
        [ForeignKey("ProductID")]
        public Product Product { get; set; }
        public int PurchaseOrderID { get; set; }
        [ForeignKey("PurchaseOrderID")]
        public PurchaseOrder   PurchaseOrder { get;set; } 
        public GoodsStatus Status { get; set; }
        public string Remarks { get; set; }
        public bool Edited { get; set; }
        public bool Deleted { get; set; }
        public int CreatedByID { get; set; }
        [ForeignKey("CreatedByID")]
        public User CreatedBy { get; set; }
        public DateTime CreateOn {  get; set; }
        [ForeignKey("ModifiedByID")]
        public User ModifiedBy { get; set; }
        public int ModifiedByID { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
