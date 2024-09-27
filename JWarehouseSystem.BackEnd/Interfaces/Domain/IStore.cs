using JWarehouseSystem.BackEnd.Domain;
using JWarehouseSystem.Common;
using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
    public interface IStore : IUserAudit
    {
        int ID { get; set; }
        int WarehouseID { get; set; }
        string Name { get; set; }
        string Zone { get; set; }
        string Size { get; set; }
        StoreLayout Layout { get; set; }

    }

   


}
