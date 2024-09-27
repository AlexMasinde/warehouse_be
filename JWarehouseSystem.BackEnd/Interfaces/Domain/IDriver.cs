using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
   public interface IDriver :IEntity
    {
      
        string Identity { get; set; }
        byte[] Photo { get; set; }
      
    }
}
