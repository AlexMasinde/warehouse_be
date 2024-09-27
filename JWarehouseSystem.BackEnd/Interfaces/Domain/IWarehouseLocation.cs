using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
    public interface IWarehouseLocation : IUserAudit
    {
        int ID { get; set; }
        string Name { get; set; }
        string Code { get; set; }
        string Zone { get; set; }
        string GPS { get; set; }
        string Description { get; set; }

    }
}
