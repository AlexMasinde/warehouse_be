using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
    public interface IOrder :IUserAudit
    {
        int ID { get; set; }
        string Number { get; set; }
        string OrderType { get; set; }
        int AuthorizedByID { get; set; }
        string CustomerPO { get; set; }
        int CustomerID { get; set; }
       
        string SalesPerson { get; set; }
        DateTime OrderDate { get; set; }
        string QuoteNumber { get; set; }
        string CreditCardNumber { get; set; }
        int ShipToAddressID { get; set; }
       
        int InvoiceToAddressID { get; set; }
       
        int OrderStatusID { get; set; }
     
        string CustomerNumber { get; set; }
        decimal Price { get; set; }

        
       

                                                
    }
}
