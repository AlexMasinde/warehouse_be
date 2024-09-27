using JWarehouseSystem.BackEnd.Domain;
using JWarehouseSystem.Common;
using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
   
    public interface ISortBucket : IUserAudit
    {
        int ID { get; set; }
       
        string Code { get; set; }
        string Description { get; set; }
        SortCriteria Criteria { get; set; }
        string SortValue { get; set; }
    }

}
