using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
   public interface IAddress:IUserAudit
    {
        int ID { get; set; }
        string Address { get; set; }
        int CountryID { get; set; }
        string Code { get; set; }
        int CityID { get; set; }
        
        string Contact { get; set; }

    }
}
