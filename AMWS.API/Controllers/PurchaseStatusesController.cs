using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AWMS.API.Data;
using JWarehouseSystem.BackEnd.Domain;
using Microsoft.Extensions.Configuration;

namespace AWMS.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PurchaseStatusesController : BaseController
    {
       public PurchaseStatusesController(AWMSAPIDBContext context, IConfiguration configuration)
             : base(context, configuration)
        {
           
        }

        //GET: api/PurchaseOrderStatusStatuses
       [HttpGet]
        public async Task<ActionResult<IEnumerable<PurchaseOrderStatus>>> GetPurchaseOrderStatus()
        {
            return await _context.PurchaseOrderStatus
                //.Include(c => c.Customer)
                //.Include(e => e.AuthorizedBy)
                //.Include(c=> c.InvoiceToAddress)
                //.Include(c => c.ShipToAddress)
                //.Include(c => c.PurchaseOrderStatusStatus)
                .Include(c => c.ModifiedBy)
                .ToListAsync();
        }

     
        // GET: api/PurchaseOrderStatusStatuses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PurchaseOrderStatus>> GetPurchaseOrderStatus(int id)
        {
            if (id == 0)
            {
                return new PurchaseOrderStatus();
            }
            var purchaseOrderStatus = await _context.PurchaseOrderStatus.Include(c => c.ModifiedBy).Include(e=>e.CreatedBy).FirstOrDefaultAsync(o => o.ID==id);

            if (purchaseOrderStatus == null)
            {
                return NotFound();
            }

            return purchaseOrderStatus;
        }

        // PUT: api/PurchaseOrderStatusStatuses/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPurchaseOrderStatus(int id, PurchaseOrderStatus purchaseOrderStatus)
        {
            if (id != purchaseOrderStatus.ID)
            {
                return BadRequest();
            }

            SetAuditData(purchaseOrderStatus.ID, purchaseOrderStatus);

            _context.Entry(purchaseOrderStatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PurchaseOrderStatusExists(id))
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

        // POST: api/PurchaseOrderStatusStatuses
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<PurchaseOrderStatus>> PostPurchaseOrderStatus(PurchaseOrderStatus purchaseOrderStatus)
        {
            SetAuditData(purchaseOrderStatus.ID, purchaseOrderStatus);

            _context.PurchaseOrderStatus.Add(purchaseOrderStatus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPurchaseOrderStatus", new { id = purchaseOrderStatus.ID }, purchaseOrderStatus);
        }

        // DELETE: api/PurchaseOrderStatusStatuses/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PurchaseOrderStatus>> DeletePurchaseOrderStatus(int id)
        {
            var purchaseOrderStatus = await _context.PurchaseOrderStatus.FindAsync(id);
            if (purchaseOrderStatus == null)
            {
                return NotFound();
            }

            _context.PurchaseOrderStatus.Remove(purchaseOrderStatus);
            await _context.SaveChangesAsync();

            return purchaseOrderStatus;
        }

        private bool PurchaseOrderStatusExists(int id)
        {
            return _context.PurchaseOrderStatus.Any(e => e.ID == id);
        }
    }
}
