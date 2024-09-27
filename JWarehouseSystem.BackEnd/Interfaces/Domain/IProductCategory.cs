using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
  public interface IProductCategory : IUserAudit
  {
    int ID { get; set; }
    string Name { get; set; }
    string Description { get; set; }
  }
}
