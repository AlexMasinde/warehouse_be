using JWarehouseSystem.Common;
using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
  public  interface INotification: IUserAudit
    {
        int ID { get; set; }
        string Message { get; set; }
        DateTime DateTimeSent { get; set; }
        NotificationType MessageType { get; set; }
       
    }
}
