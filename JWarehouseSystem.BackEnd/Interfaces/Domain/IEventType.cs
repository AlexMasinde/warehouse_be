using JWarehouseSystem.BackEnd.Domain;
using JWarehouseSystem.Common;
using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
   public interface IEventType :IUserAudit
    {
       int ID { get; set; }
        /// <summary>
        /// Excess Items, Damaged Items, Missing Items, Theft,Loss, Wrong Items, Task
        /// </summary>
       string Name { get; set; }
     
      
        
    }
   

}
