using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common.Domain;
using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JWarehouseSystem.BackEnd.Domain
{
    public class NotificationType : INotificationType
    {
        public int ID { get; set; }
        public string Name { get; set;}
        // public virtual UserAudit Audit { get; set;}
        public int CreatedByID { get; set; }
        public DateTime CreateOn { get; set; }
        public int ModifiedByID { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
