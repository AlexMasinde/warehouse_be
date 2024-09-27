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
    public class DeliveryItemsController : ControllerBase
    {
        private readonly AWMSAPIDBContext _context;

        public DeliveryItemsController(AWMSAPIDBContext context)
        {
            _context = context;
        }

        //GET: api/DeliveryItems
       [HttpGet]
        public async Task<ActionResult<PagedResult<DeliveryItem>>> GetDeliveryItem()
        {
            var items = _context.DeliveryItem
                .Include(c => c.Product)
               .Include(c => c.Delivery)
                   .Include(c => c.ModifiedBy);
            // .ToListAsync()

            PagedResult<DeliveryItem> pagedResult = await items.GetPagedAsync(1, 10);
            return pagedResult;
        }
        // GET: api/deliveryitems/deliveryitemid
        [HttpGet("{deliveryitems}")]
        public async Task<ActionResult<IEnumerable<DeliveryItem>>> GetDeliveryItems(int deliveryid)
        {
            if (deliveryid == 0)
            {
                return new List<DeliveryItem>();
            }

            List<DeliveryItem> items = await _context.DeliveryItem.Include(c => c.ModifiedBy)
                                                            .Include(e => e.CreatedBy)                                                            
                                                            .Where(o => o.DeliveryID == deliveryid && !o.IsRemoved)
                                                            .ToListAsync();

            if (items == null)
            {
                return NotFound();
            }

            return items;
        }


        // GET: api/DeliveryItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DeliveryItem>> GetDeliveryItem(int id)
        {
            // var DeliveryItem = await _context.DeliveryItem.FindAsync(id);
            var DeliveryItem = await _context.DeliveryItem.Include(c => c.Product).Include(e=>e.ModifiedBy).FirstOrDefaultAsync(o => o.ID==id);

            if (DeliveryItem == null)
            {
                return NotFound();
            }

            return DeliveryItem;
        }

        // PUT: api/DeliveryItems/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDeliveryItem(int id, DeliveryItem DeliveryItem)
        {
            if (id != DeliveryItem.ID)
            {
                return BadRequest();
            }

            _context.Entry(DeliveryItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeliveryItemExists(DeliveryItem.DeliveryID, DeliveryItem.ProductID))
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

        // POST: api/DeliveryItems
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<DeliveryItem>> PostDeliveryItem(DeliveryItem DeliveryItem)
        {
            _context.DeliveryItem.Add(DeliveryItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDelivery", new { id = DeliveryItem.ID }, DeliveryItem);
        }

        // DELETE: api/DeliveryItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DeliveryItem>> DeleteDeliveryItem(int id)
        {
            var DeliveryItem = await _context.DeliveryItem.FindAsync(id);
            if (DeliveryItem == null)
            {
                return NotFound();
            }

            _context.DeliveryItem.Remove(DeliveryItem);
            await _context.SaveChangesAsync();

            return DeliveryItem;
        }

        private bool DeliveryItemExists(int Deliveryid , int productid)
        {
            return _context.DeliveryItem.Any(e => e.DeliveryID == Deliveryid && e.ProductID==productid);
        }
    }
}
