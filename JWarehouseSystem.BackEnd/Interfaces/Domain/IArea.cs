using JWarehouseSystem.Common;
using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
   public interface IArea :IUserAudit
    {
        int ID { get; set; }
        string Name { get; set; }
        string Zone { get; set; }
        string Description { get; set; }
        AreaStatus Status { get; set; }
      //  Collection<IAreaPurpose> Purposes { get; set; }
       bool IsActive { get; set; }
    }

    public interface IAreaPurpose : IUserAudit
    {
       
        int ID { get; set; }
        int AreaID { get; set; }
        /// <summary>
        ///   Loading = 1, Unloading = 2, Reception = 3, Picking = 4, Packing = 5 
        /// </summary>
        string Purpose { get; set; }
       

    }
}
