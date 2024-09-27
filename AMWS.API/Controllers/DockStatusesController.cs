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
    public class DockStatusesController : BaseController
    {
      

        public DockStatusesController(AWMSAPIDBContext context, IConfiguration configuration)
             : base(context, configuration)
        {
          
        }

        //GET: api/DockStatuses
       [HttpGet]
        public async Task<ActionResult<IEnumerable<DockStatus>>> GetDockStatus()
        {
            return await _context.DockStatus
                //.Include(c => c.Customer)
                //.Include(e => e.AuthorizedBy)
                //.Include(c=> c.InvoiceToAddress)
                //.Include(c => c.ShipToAddress)
                //.Include(c => c.DockStatusStatus)
                .Include(c => c.ModifiedBy)
                .ToListAsync();
        }

     
        // GET: api/DockStatus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DockStatus>> GetDockStatus(int id)
        {
            if (id == 0)
            {
                return new DockStatus();
            }

            var dockStatus = await _context.DockStatus.Include(c => c.ModifiedBy).Include(e=>e.CreatedBy).FirstOrDefaultAsync(o => o.ID==id);

            if (dockStatus == null)
            {
                return NotFound();
            }

            return dockStatus;
        }

        // PUT: api/DockStatusStatuses/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDockStatus(int id, DockStatus dockStatus)
        {
            if (id != dockStatus.ID)
            {
                return BadRequest();
            }

            SetAuditData(dockStatus.ID, dockStatus);

            _context.Entry(dockStatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DockStatusExists(id))
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

        // POST: api/DockStatusStatuses
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<DockStatus>> PostDockStatus(DockStatus dockStatus)
        {
            SetAuditData(dockStatus.ID, dockStatus);
            _context.DockStatus.Add(dockStatus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDockStatus", new { id = dockStatus.ID }, dockStatus);
        }

        // DELETE: api/DockStatusStatuses/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DockStatus>> DeleteDockStatus(int id)
        {
            var dockStatus = await _context.DockStatus.FindAsync(id);
            if (dockStatus == null)
            {
                return NotFound();
            }

            _context.DockStatus.Remove(dockStatus);
            await _context.SaveChangesAsync();

            return dockStatus;
        }

        private bool DockStatusExists(int id)
        {
            return _context.DockStatus.Any(e => e.ID == id);
        }
    }
}
