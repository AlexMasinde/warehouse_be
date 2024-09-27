﻿using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
    public interface IPurchaseOrderStatus :IUserAudit
    {
        int ID { get; set; }
        string Status { get; set; }
        string Description { get; set; }
       
    }
}
