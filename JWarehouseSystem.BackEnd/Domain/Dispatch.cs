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
    public class Dispatch : IDispatch
    {
        public int ID { get; set;}
        [ForeignKey("OrderID")]
        public int CustomerOrderID {get; set; }
        public Order Order { get; set; }
        public int DockID {get; set; }
        public Dock Dock { get; set; }
        public string PickingInfo {get; set; }
        public string PackingInfo {get; set; }
        public DateTime IssueDate {get; set; }
        [ForeignKey("SupplierID")]
        public int SellerID {get; set; }
        public Supplier Supplier { get; set; }
        public string DeliveryAddress {get; set; }

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
