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
    public class OrderItemsController : ControllerBase
    {
        private readonly AWMSAPIDBContext _context;

        public OrderItemsController(AWMSAPIDBContext context)
        {
            _context = context;
        }

        //GET: api/Orders
       [HttpGet]
        public async Task<ActionResult<PagedResult<OrderItem>>> GetOrderItem()
        {
            var orders = _context.OrderItem
                .Include(c => c.Product)
               .Include(c => c.Order)
              
                .Include(c => c.ModifiedBy);
            // .ToListAsync()

            PagedResult<OrderItem> pagedResult = await orders.GetPagedAsync(1, 10);
            return pagedResult;
        }
        // GET: api/Ordered items/orderid
        [HttpGet("{orderitems}")]
        public async Task<ActionResult<IEnumerable<OrderItem>>> GetOrderItems(int orderid)
        {
            if (orderid == 0)
            {
                return new List<OrderItem>();
            }

            List<OrderItem> items = await _context.OrderItem.Include(c => c.ModifiedBy)
                                                            .Include(e => e.CreatedBy)                                                            
                                                            .Where(o => o.OrderID == orderid && !o.IsRemoved)
                                                            .ToListAsync();

            if (items == null)
            {
                return NotFound();
            }

            return items;
        }


        // GET: api/Orders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderItem>> GetOrderItem(int id)
        {
            // var OrderItem = await _context.OrderItem.FindAsync(id);
            var OrderItem = await _context.OrderItem.Include(c => c.Product).Include(e=>e.ModifiedBy).FirstOrDefaultAsync(o => o.ID==id);

            if (OrderItem == null)
            {
                return NotFound();
            }

            return OrderItem;
        }

        // PUT: api/Orders/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderItem(int id, OrderItem OrderItem)
        {
            if (id != OrderItem.ID)
            {
                return BadRequest();
            }

            _context.Entry(OrderItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderItemExists(OrderItem.OrderID, OrderItem.ProductID))
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
        public async Task<ActionResult<OrderItem>> PostOrder(OrderItem OrderItem)
        {
            _context.OrderItem.Add(OrderItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrder", new { id = OrderItem.ID }, OrderItem);
        }

        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<OrderItem>> DeleteOrderItem(int id)
        {
            var OrderItem = await _context.OrderItem.FindAsync(id);
            if (OrderItem == null)
            {
                return NotFound();
            }

            _context.OrderItem.Remove(OrderItem);
            await _context.SaveChangesAsync();

            return OrderItem;
        }

        private bool OrderItemExists(int orderid , int productid)
        {
            return _context.OrderItem.Any(e => e.OrderID == orderid && e.ProductID==productid);
        }
    }
}
