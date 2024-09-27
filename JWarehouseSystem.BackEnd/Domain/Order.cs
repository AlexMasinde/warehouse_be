using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common.Domain;
using JWarehouseSystem.Common.Interfaces;

namespace JWarehouseSystem.BackEnd.Domain
{
    public class Order : IOrder
    {
        public int ID { get; set; }
        [Required]
        public string Number { get; set; }
        public string OrderType { get; set; }
        public int AuthorizedByID {get; set; }
        public Employee AuthorizedBy { get; set; }
        public string CustomerPO {get; set; }
        [Required]
        public int CustomerID {get; set; }
        public Customer Customer { get; set; }

        public string SalesPerson {get; set; }
        public DateTime OrderDate {get; set; }
        public string QuoteNumber {get; set; }
        public string CreditCardNumber {get; set; }
        public int ShipToAddressID {get; set; }
        public CustomerAddress ShipToAddress { get; set; }
       
        public int InvoiceToAddressID {get; set; }
        public CustomerAddress InvoiceToAddress { get; set; }

        public int OrderStatusID {get; set; }
        public OrderStatus OrderStatus { get; set; }

        public string CustomerNumber {get; set; }
        
        public decimal Price {get; set; }

        public int CreatedByID { get; set; }
        [ForeignKey("CreatedByID")]
        public User CreatedBy { get; set; }
        public DateTime CreateOn { get; set; }
        public int ModifiedByID { get; set; }
        [ForeignKey("ModifiedByID")]
        public User ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
                              
    }
}
