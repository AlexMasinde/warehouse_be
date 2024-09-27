using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
    public interface ICity:IUserAudit
    {
        int ID { get; set; }
        string City { get; set; }
        string ZipCode { get; set; }
    }
}
