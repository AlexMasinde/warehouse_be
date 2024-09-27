using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
    public interface IProduct : IUserAudit
    {
        int ID { get; set; }
        string Name { get; set; }
        Guid GUID { get; set; }
        decimal Price { get; set; }
        string Brand { get; set; }
        string Description { get; set; }
        string SKU { get; set; }
        int ProductCategoryID { get; set; }

    }
}
