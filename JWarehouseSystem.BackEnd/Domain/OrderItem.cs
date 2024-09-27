using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common.Domain;
using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JWarehouseSystem.BackEnd.Domain
{
    public class OrderItem : IOrderItem
    {
       public int ID { get;set; }
        public string BatchNo { get;
            set;
        }
        public Product Product { get;set; }
        public int ProductID { get;set; }
        public int OrderID { get;set; }
        public Order Order { get;set; }
        public int WarehouseID { get;set; }
        public Warehouse Warehouse { get;set; }
        public int Quantity { get;set; }
        public int CreatedByID { get; set; }
        [ForeignKey("CreatedByID")]
        public User CreatedBy { get; set; }
        public DateTime CreateOn { get; set; }
        public int ModifiedByID { get; set; }
        [ForeignKey("ModifiedByID")]
        public User ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public bool IsRemoved { get; set; }
    }
}
