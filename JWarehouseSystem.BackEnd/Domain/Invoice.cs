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
    public class Invoice : IInvoice
    {
        public int ID { get; set;}
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime PaymentDueDate { get; set; }
        public string PaymentMode1 { get; set; }
        public string PaymentMode2 { get; set; }
        public string PaymentMode3 { get; set; }
        [ForeignKey("SupplierID")]
        public int SellerID { get; set; }
        public Supplier Supplier { get; set; }
        [ForeignKey("CustomerID")]
        public int BuyerID { get; set; }
        public Customer Customer { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal TotalTax { get; set; }

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
