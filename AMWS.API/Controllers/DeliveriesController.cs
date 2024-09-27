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
    public class DeliveriesController : ControllerBase
    {
        private readonly AWMSAPIDBContext _context;

        public DeliveriesController(AWMSAPIDBContext context)
        {
            _context = context;
        }

        //GET: api/deliveries
       [HttpGet]
        public async Task<ActionResult<PagedResult<Delivery>>> GetDelivery()
        {
            var deliveries = _context.Delivery
                .Include(c => c.Customer)
                .Include(e => e.ReceivedBy)
                .Include(c => c.Customer)
                .Include(c => c.DeliverToAddress)
                .Include(c => c.Supplier)
                .Include(c => c.ModifiedBy);
            // .ToListAsync()

            PagedResult<Delivery> pagedResult = await deliveries.GetPagedAsync(1, 10);
            return pagedResult;
        }
       
        // GET: api/deliveries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Delivery>> GetDelivery(int id)
        {
            // var order = await _context.Delivery.FindAsync(id);
            var order = await _context.Delivery.Include(c => c.Customer).Include(e=>e.ReceivedBy).FirstOrDefaultAsync(o => o.ID==id);

            if (order == null)
            {
                return NotFound();
            }

            return order;
        }

        // PUT: api/Deliveries/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDelivery(int id, Delivery delivery)
        {
            if (id != delivery.ID)
            {
                return BadRequest();
            }

            _context.Entry(delivery).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeliveryExists(id))
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

        // POST: api/Deliveries
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Delivery>> PostDelivery(Delivery delivery)
        {
            _context.Delivery.Add(delivery);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDelivery", new { id = delivery.ID }, delivery);
        }

        // DELETE: api/Deliveries/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Delivery>> DeleteDelivery(int id)
        {
            var order = await _context.Delivery.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            _context.Delivery.Remove(order);
            await _context.SaveChangesAsync();

            return order;
        }

        private bool DeliveryExists(int id)
        {
            return _context.Delivery.Any(e => e.ID == id);
        }
    }
}
