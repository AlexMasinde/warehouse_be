using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common;
using JWarehouseSystem.Common.Domain;
using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JWarehouseSystem.BackEnd.Domain
{
    public class Shipment : IShipment
    {
        [Key]
        public int ID { get; set;}
        public int PurchaseOrderID { get; set;}
        public virtual PurchaseOrder PurchaseOrder { get; set; }
        public int CarrierID { get; set;}
        [ForeignKey("CarrierID")]
        public virtual Carrier Ship { get; set; }
        public ShipmentType Type { get; set;}
        public int DockID { get; set; }
        public Dock Dock { get; set; }
             
        [ForeignKey("LocationID")]
        public int StartLegLocationID { get; set;}
        public virtual Location StartLegLocation { get; set; }
        [ForeignKey("LocationID")]
        public int EndLegLocationID { get; set;}
        public virtual Location EndLegLocation { get; set; }
        public DateTime StartDateExpected { get; set;}
        public DateTime StartDateActual { get; set;}
        public DateTime EndDateExpected { get; set;}
        public DateTime EndDateActual { get; set;}
        public string OtherDetails { get; set;}
        public string TrackingNumber { get; set; }
       
        public int CreatedByID { get; set; }
        [ForeignKey("CreatedByID")]
        public User CreatedBy { get; set; }
        public int ModifiedByID { get; set; }
        [ForeignKey("ModifiedByID")]
        public User ModifiedBy { get; set; }
       
      
        [Timestamp]
        public DateTime CreateOn { get => createOn; set => createOn = value; }
        [Timestamp]
        public DateTime ModifiedOn { get => modifiedOn; set => modifiedOn = value; }
        
        private DateTime modifiedOn = DateTime.Now;
        private DateTime createOn = DateTime.Now;
    }
}
