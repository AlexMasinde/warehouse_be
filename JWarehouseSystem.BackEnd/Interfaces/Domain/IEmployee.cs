using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
  public  interface IEmployee :IUserAudit
    {
        int ID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Identity { get; set; }
        string Telephone { get; set; }
        string Email { get; set; }
        byte[] Photo { get; set; }
        string Number { get; set; }
        string Department { get; set; }
        string Designation { get; set; }



    }
}
