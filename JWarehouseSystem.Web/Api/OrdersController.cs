using JWarehouseSystem.BackEnd.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JWarehouseSystem.Web.Api
{
    [Route("api/[controller]")]
    public class OrdersController : Controller
    {



        private DataTable ordersDatatable()
        {

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


            ordersTable.Rows.Add(1, "Dai", "Rios", "dai@gmail.com", "0172220000","Personnel Lead", "Edinburgh", 35, "2012/09/26", "$217,500");
            ordersTable.Rows.Add(2, "Bradley", "Greer", "brad@gmail.com", "073338999","Software Engineer", "London", 41, "2012/10/13", "$132,000");
            ordersTable.Rows.Add(3, "Gloria", "Little", "g.little@gmail.com", "789955444","Systems Administrator", "New York", 59, "2009/04/10", "$237,500");

            return ordersTable;

        }
        [HttpGet]
        public ActionResult<DataTable> Get()
        {

            DataTable dt = ordersDatatable();

            return Ok(dt);
        }

       
        // GET: api/Test/5
        [HttpGet("{id}")]
        public ActionResult<Order> Get(int id)
        {
            List<Order> orders = new List<Order>();

            orders.Add(new Order());

            orders.Add(
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
                    //StatusID = 1,
                    CustomerNumber = "CUS001",
                    Price = 1500
                });

            orders.Add(
              new Order
              {
                  ID = 2,
                  Number = "XX001E",
                  OrderType = "Standard",
                  AuthorizedByID = 21,
                  CustomerPO = "POXX001E",
                  CustomerID = 1,
                  SalesPerson = "James Mwaniki E",
                  OrderDate = new DateTime(2019, 12, 8),
                  QuoteNumber = "Quote22334E",
                  CreditCardNumber = "Cred9000E",
                  ShipToAddressID = 1,
                  InvoiceToAddressID = 2,
                  //StatusID = 1,
                  CustomerNumber = "CUS001E",
                  Price = 2500
              });


            return Ok((orders.Find(o => o.ID.Equals(id))));

        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
