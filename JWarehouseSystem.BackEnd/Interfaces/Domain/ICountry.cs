using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
  public  interface ICountry:IUserAudit
    {
        int ID { get; set; }
        string Name { get; set; }
        string Code { get; set; }
        string NumericCode { get; set; }
    }
}
