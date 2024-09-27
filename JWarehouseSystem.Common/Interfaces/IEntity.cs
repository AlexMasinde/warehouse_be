using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.Common.Interfaces
{
  public  interface IEntity : IUserAudit
    {

        int ID { get; set; }
       // EntityType EntityType { get; set; }
        String FirstName { get; set; }
        String LastName { get; set; }
        String MiddleName { get; set; }
        String Title { get; set; }
        Boolean Enabled { get; set; }
        String Telephone { get; set;}
        String Email { get; set; }
        String Website { get; set; }
        String Other { get; set; }
     
    }

 
}
