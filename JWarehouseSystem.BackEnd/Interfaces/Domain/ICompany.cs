using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces

{
   public interface ICompany :IUserAudit
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ContactID { get; set; }
      
    }
}
