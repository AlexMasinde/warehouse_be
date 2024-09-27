using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AWMS.API.Data;
using JWarehouseSystem.BackEnd.Domain;
using AWMS.API.Models;

namespace AWMS.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly AWMSAPIDBContext _context;

        public OrdersController(AWMSAPIDBContext context)
        {
            _context = context;
        }

        //GET: api/Orders
       [HttpGet]
        public async Task<ActionResult<PagedResult<Order>>> GetOrder()
        {
            var orders = _context.Order
                .Include(c => c.Customer)
                .Include(e => e.AuthorizedBy)
                .Include(c => c.InvoiceToAddress)
                .Include(c => c.ShipToAddress)
                .Include(c => c.OrderStatus)
                .Include(c => c.ModifiedBy);
            // .ToListAsync()

            PagedResult<Order> pagedResult = await orders.GetPagedAsync(1, 10);
            return pagedResult;
        }
        // GET: api/Ordered items/orderid
        [HttpGet("{orderid}")]
        public async Task<ActionResult<IEnumerable<OrderItem>>> GetOrderItems(int orderid)
        {
            if (orderid == 0)
            {
                return new List<OrderItem>();
            }

            List<OrderItem> items = await _context.OrderItem.Include(c => c.ModifiedBy)
                                                            .Include(e => e.CreatedBy)                                                            
                                                            .Where(o => o.ID == orderid && !o.IsRemoved)
                                                            .ToListAsync();

            if (items == null)
            {
                return NotFound();
            }

            return items;
        }


        // GET: api/Orders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrder(int id)
        {
            // var order = await _context.Order.FindAsync(id);
            var order = await _context.Order.Include(c => c.Customer).Include(e=>e.AuthorizedBy).FirstOrDefaultAsync(o => o.ID==id);

            if (order == null)
            {
                return NotFound();
            }

            return order;
        }

        // PUT: api/Orders/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrder(int id, Order order)
        {
            if (id != order.ID)
            {
                return BadRequest();
            }

            _context.Entry(order).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Orders
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Order>> PostOrder(Order order)
        {
            _context.Order.Add(order);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrder", new { id = order.ID }, order);
        }

        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Order>> DeleteOrder(int id)
        {
            var order = await _context.Order.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            _context.Order.Remove(order);
            await _context.SaveChangesAsync();

            return order;
        }

        private bool OrderExists(int id)
        {
            return _context.Order.Any(e => e.ID == id);
        }
    }
}
