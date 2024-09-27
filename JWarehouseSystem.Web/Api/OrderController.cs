using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using JWarehouseSystem.BackEnd.Domain;
using Microsoft.AspNetCore.Mvc;

namespace JWarehouseSystem.Web.Api
{
    [System.Web.Http.RoutePrefix("Api/Order")]
    public class OrderController : Controller
    {
        [HttpGet()]
        public DataTable GetOrders()
        {
            
            DataTable tb = ordersDatatable();

            return tb;
        }
        [HttpGet()]
        [Route("Detail")]
        public IActionResult GetOrder([FromRouteAttribute] int Id)
        {
            Order[] orders = new Order[] {new Order() };

            orders.Append(
                new Order
                {
                    ID = 1,
                    Number = "XX005",
                    OrderType = "Bulk",
                    AuthorizedByID = 22,
                    CustomerPO = "POXX006",
                    CustomerID = 1,
                    SalesPerson = "John Kamau",
                    OrderDate = DateTime.Now,
                    QuoteNumber = "Quote5555",
                    CreditCardNumber = "Cred9000",
                    ShipToAddressID = 2,
                    InvoiceToAddressID = 3,
                    StatusID = 1,
                    CustomerNumber = "CUS001",
                    Price = 1500
                } );

            orders.Append(
              new Order
              {
                    ID= 2,
                    Number= "XX001E",
                    OrderType= "Standard",
                    AuthorizedByID= 21,
                    CustomerPO= "POXX001E",
                    CustomerID= 1,
                    SalesPerson= "James Mwaniki E",
                    OrderDate= new DateTime(2019,12,8),
                    QuoteNumber= "Quote22334E",
                    CreditCardNumber= "Cred9000E",
                    ShipToAddressID= 1,
                    InvoiceToAddressID= 2,
                    StatusID= 1,
                    CustomerNumber= "CUS001E",
                    Price= 2500
                            });




            return Ok(Array.Find(orders, o => o.ID.Equals(Id)));
        }
        private DataTable ordersDatatable() {
           
            // Create a DataTable  
            DataTable ordersTable = new DataTable("Orders");
            ordersTable.Columns.Add("Id", typeof(Int32));
            ordersTable.Columns.Add("FirstName", typeof(string));
            ordersTable.Columns.Add("LastName", typeof(string));
            ordersTable.Columns.Add("Email", typeof(string));
            ordersTable.Columns.Add("Telephone", typeof(string));

            ordersTable.Columns.Add("Position", typeof(string));
            ordersTable.Columns.Add("Office", typeof(string));
            ordersTable.Columns.Add("Age", typeof(Int32));
            ordersTable.Columns.Add("Date", typeof(DateTime));
            ordersTable.Columns.Add("Salary", typeof(string));
          

            ordersTable.Rows.Add(1, "Dai", "Rios", "dai@gmail.com","0172220000","P.O Box Malindi", "Personnel Lead", "Edinburgh", 35, "2012/09/26", "$217,500");
            ordersTable.Rows.Add(2, "Bradley", "Greer", "brad@gmail.com", "073338999", "P.O Box Nairobi", "Software Engineer", "London",41, "2012/10/13", "$132,000");
            ordersTable.Rows.Add(3, "Gloria", "Little", "g.little@gmail.com", "789955444", "P.O Box Nakuru", "Systems Administrator", "New York",59, "2009/04/10", "$237,500");

            return ordersTable;

    }
       
    }
}
