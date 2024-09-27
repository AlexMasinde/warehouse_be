using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common;
using JWarehouseSystem.Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JWarehouseSystem.BackEnd.Domain
{
   
    public class Unload : IUnload
    {
        public int ID { get; set; }
        public int ShipmentID { get; set; }
        public Shipment Shipment { get; set; }
        public int DockID { get; set; }
        public Dock Dock { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        [ForeignKey("EmployeeID")]
        public int OfficerInChargeID { get; set; }
        public Employee OfficerInCharge { get; set; }
        public int UnloadingAreaID { get; set; }
       
        public bool HasBeenReceived { get; set; }
      
        public string Remarks { get; set; }
        public UnloadingStatus Status { get; set; }

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
