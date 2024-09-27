using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
    public interface ISupplier :IUserAudit
    {
        int ID { get; set; }
        string Name { get; set; }
        string Identity { get; set; }
        string Telephone { get; set; }
        string Email { get; set; }
        string Website { get; set; }
       
    }
}
