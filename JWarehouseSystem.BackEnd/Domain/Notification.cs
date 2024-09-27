using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common;
using JWarehouseSystem.Common.Domain;
using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JWarehouseSystem.BackEnd.Domain
{
    public class Notification : INotification
    {
        public int ID { get; set;}
        public string Message { get; set;}
        public DateTime DateTimeSent { get; set;}
        public Common.NotificationType MessageType { get; set;}
        // public virtual UserAudit Audit { get; set;}
        public int CreatedByID { get; set; }
        public DateTime CreateOn { get; set; }
        public int ModifiedByID { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
