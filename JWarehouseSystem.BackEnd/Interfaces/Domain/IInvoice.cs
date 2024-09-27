using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
    public interface IInvoice:IUserAudit
    {
        int ID { get; set; }
        string InvoiceNumber { get; set; }
        DateTime InvoiceDate { get; set; }
        DateTime DeliveryDate { get; set; }
        DateTime PaymentDueDate { get; set; }
        string PaymentMode1 { get; set; }
        string PaymentMode2 { get; set; }
        string PaymentMode3 { get; set; }
        int SellerID { get; set; }
        int BuyerID { get; set; }
        decimal TotalAmount { get; set; }
        decimal TotalDiscount { get; set; }
        decimal TotalTax { get; set; }
       
    }
}
