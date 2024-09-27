using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
   public interface ICurrency :IUserAudit
    {
        int ID { get; set; }
        string Name { get; set; }
        string Code { get; set; }
        public int Number { get; set; }
    }
}
