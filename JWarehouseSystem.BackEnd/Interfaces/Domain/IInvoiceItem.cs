using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
  public  interface IInvoiceItem:IUserAudit
    {
        int ID { get; set; }
        int InvoiceID { get; set; }
        int ProductID { get; set; }
        int Quantity { get; set; }
        decimal UnitPrice { get; set; }
        bool IsRemoved { get; set; }
        bool IsAdded { get; set; }
    }

   
}
