using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common;
using JWarehouseSystem.Common.Domain;
using JWarehouseSystem.Common.Interfaces;

namespace JWarehouseSystem.BackEnd.Domain
{
    public class Packing : IPacking
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
        public int PackingAreaID { get; set; }
        public virtual PackingArea PackingArea { get; set;}
        public DateTime BegunAt { get; set;}
        public DateTime CompletedAt { get; set;}
        public string BatchNo { get; set;}
        public int DoneByID { get; set;}
        public virtual Employee DoneBy { get; set;}
        public int DockID { get; set;}
        public virtual Dock Dock { get; set;}
        public virtual PickPackStatus Status { get; set;}
        public int CreatedByID { get; set; }
        public DateTime CreateOn { get; set; }
        public int ModifiedByID { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
