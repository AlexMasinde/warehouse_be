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
    public class WarehousesController : BaseController
    {
      

        public WarehousesController(AWMSAPIDBContext context, IConfiguration configuration)
             : base(context, configuration)
        {
           
        }

        //GET: api/Warehouses
       [HttpGet]
        public async Task<ActionResult<IEnumerable<Warehouse>>> GetWarehouse()
        {
            return await _context.Warehouse
                //.Include(c => c.Customer)
                //.Include(e => e.AuthorizedBy)
                //.Include(c=> c.InvoiceToAddress)
                //.Include(c => c.ShipToAddress)
                .Include(c => c.Location)
                .Include(c => c.ModifiedBy)
                .ToListAsync();
        }

     
        // GET: api/Warehouses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Warehouse>> GetWarehouse(int id)
        {
            if (id == 0)
            {
                return new Warehouse();
            }

            var warehouse = await _context.Warehouse.Include(c => c.ModifiedBy).Include(e=>e.Location).FirstOrDefaultAsync(o => o.ID==id);

            if (warehouse == null)
            {
                return NotFound();
            }

            return warehouse;
        }

        // PUT: api/Warehouses/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWarehouse(int id, Warehouse warehouse)
        {
            if (id != warehouse.ID)
            {
                return BadRequest();
            }
            SetAuditData(warehouse.ID, warehouse);

            _context.Entry(warehouse).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WarehouseExists(id))
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

        // POST: api/Warehouses
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Warehouse>> PostWarehouse(Warehouse warehouse)
        {
            SetAuditData(warehouse.ID, warehouse);

            _context.Warehouse.Add(warehouse);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWarehouse", new { id = warehouse.ID }, warehouse);
        }

        // DELETE: api/Warehouses/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Warehouse>> DeleteWarehouse(int id)
        {
            var warehouse = await _context.Warehouse.FindAsync(id);
            if (warehouse == null)
            {
                return NotFound();
            }

            _context.Warehouse.Remove(warehouse);
            await _context.SaveChangesAsync();

            return warehouse;
        }

        private bool WarehouseExists(int id)
        {
            return _context.Warehouse.Any(e => e.ID == id);
        }
    }
}
