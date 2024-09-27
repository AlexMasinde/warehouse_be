using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
    public interface ISendStock:IUserAudit
    {
        int ID { get; set; }
        int RequestTransferID { get; set; }
        DateTime SendStockDate { get; set; }
        DateTime ReleaseDate { get; set; }
        int SentByID { get; set; }
        string Notes { get; set; }
       

    }
}
