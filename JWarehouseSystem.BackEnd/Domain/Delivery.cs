using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common.Domain;

namespace JWarehouseSystem.BackEnd.Domain
{
    public class Delivery : IDelivery
    {
        [Key]
        public int ID {get; set; }
        public string DeliveryNumber
        {
            get {
                if (ID <= 0) { return "DEL##"; }

                return String.Format("DEL{0}", ID.ToString("00000")); 
            }

            }
        public DateTime DeliveryDateFrom {get; set; }
        public DateTime DeliveryDateTo {get; set; }
        public string ReceiptNo {get; set; }
        public DateTime ReceivedDate {get; set; }
        [ForeignKey("Address")]
        public int DeliverToAddressID {get; set; }
        public virtual CustomerAddress DeliverToAddress {get; set; }
        public int PackingSlipNo {get; set; }
        [ForeignKey("Supplier")]
        public int SupplierID {get; set; }
        public virtual Supplier Supplier {get; set; }
        [ForeignKey("Employee")]
        public int ReceivedByID {get; set; }
        public virtual Employee ReceivedBy {get; set; }
        public int CartonCount {get; set; }
        public string TrackingNumber {get; set; }
        public string SourceDocument {get; set; }
        [ForeignKey("Customer")]
        public int CustomerID {get; set; }
        public virtual Customer Customer {get; set; }
        [ForeignKey("Company")]
        public int CompanyID {get; set; }
        public virtual Company Company {get; set; }
       
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
