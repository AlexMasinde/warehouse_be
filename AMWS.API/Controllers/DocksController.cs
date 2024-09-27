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
    public class DocksController : BaseController
    {
        

        public DocksController(AWMSAPIDBContext context, IConfiguration configuration)
             : base(context, configuration)
        {
            
        }

        //GET: api/Docks
       [HttpGet]
        public async Task<ActionResult<IEnumerable<Dock>>> GetDock()
        {
            return await _context.Dock
                //.Include(c => c.Customer)
                //.Include(e => e.AuthorizedBy)
                //.Include(c=> c.InvoiceToAddress)
                //.Include(c => c.ShipToAddress)
                .Include(c => c.Warehouse)
                .Include(c => c.ModifiedBy)
                .ToListAsync();
        }

     
        // GET: api/Docks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Dock>> GetDock(int id)
        {
            // var dock = await _context.Dock.FindAsync(id);
            var dock = await _context.Dock.Include(c => c.ModifiedBy).FirstOrDefaultAsync(o => o.ID==id);
            if (id == 0)
            {
                return new Dock();
            }

            if (dock == null)
            {
                return NotFound();
            }

            return dock;
        }

        // PUT: api/Docks/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDock(int id, Dock dock)
        {
            if (id != dock.ID)
            {
                return BadRequest();
            }

            SetAuditData(dock.ID, dock);

            _context.Entry(dock).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DockExists(id))
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

        // POST: api/Docks
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Dock>> PostDock(Dock dock)
        {
            SetAuditData(dock.ID, dock);

            _context.Dock.Add(dock);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDock", new { id = dock.ID }, dock);
        }

        // DELETE: api/Docks/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Dock>> DeleteDock(int id)
        {
            var dock = await _context.Dock.FindAsync(id);
            if (dock == null)
            {
                return NotFound();
            }

            _context.Dock.Remove(dock);
            await _context.SaveChangesAsync();

            return dock;
        }

        private bool DockExists(int id)
        {
            return _context.Dock.Any(e => e.ID == id);
        }
    }
}
