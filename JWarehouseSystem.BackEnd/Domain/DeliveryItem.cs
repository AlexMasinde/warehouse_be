using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common.Domain;

namespace JWarehouseSystem.BackEnd.Domain
{
    public class DeliveryItem : IDeliveryItem
    {
        [Key]
        public int ID {get; set; }
             
        [ForeignKey("Delivery")]
        public int DeliveryID {get; set; }
        public virtual Delivery Delivery {get; set; }
        [ForeignKey("Product")]
        public int ProductID {get; set; }
        public virtual Product Product {get; set; }
        public int Quantity { get; set; }
        public int CreatedByID { get; set; }
        [ForeignKey("CreatedByID")]
        public User CreatedBy { get; set; }
        public DateTime CreateOn { get; set; }
        public int ModifiedByID { get; set; }
        [ForeignKey("ModifiedByID")]
        public User ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public bool IsRemoved { get; set; }
        public Boolean IsAdded { get; set; }
    }
}
