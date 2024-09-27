using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
   public interface ICustomer:IUserAudit
    {
        int ID { get; set; }
        [Required]
        string FirstName { get; set; }
        [Required]
        string LastName { get; set; }
        [Required]
        string Identity { get; set; }
           
        string Telephone { get; set; }
        string Email { get; set; }
       string Website { get; set; }

    }
}
