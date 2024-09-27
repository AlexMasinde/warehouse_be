using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
  public  interface IDelivery:IUserAudit
    {
        int ID { get; set; }
        string DeliveryNumber { get; }
        DateTime DeliveryDateFrom { get; set; }
        DateTime DeliveryDateTo { get; set; }
        string ReceiptNo { get; set; }
        DateTime ReceivedDate { get; set; }
        int DeliverToAddressID { get; set; }
       int PackingSlipNo { get; set; }
        int SupplierID { get; set; }
        int ReceivedByID { get; set; }
        int CartonCount { get; set; }
        string TrackingNumber { get; set; }
        string SourceDocument { get; set; }
        int CustomerID { get; set; }
        int CompanyID { get; set; }
       
    }

   
}
