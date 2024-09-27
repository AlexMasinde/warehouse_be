using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
  public  interface IContact :IUserAudit
    {
        int ID { get; set; }
        string Identity { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Telephone { get; set; }
        string Email { get; set; }
        string Description { get; set; }
        Boolean IsActive { get; set; }

    }
}
