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
    public class CarriersController : BaseController
    {
       
        public CarriersController(AWMSAPIDBContext context, IConfiguration configuration)
             : base(context, configuration)
        {
          
        }

        //GET: api/Ships
       [HttpGet]
        public async Task<ActionResult<IEnumerable<Carrier>>> GetCarrier()
        {
            return await _context.Carrier
                //.Include(c => c.Customer)
                //.Include(e => e.AuthorizedBy)
                //.Include(c=> c.InvoiceToAddress)
                //.Include(c => c.CarrierToAddress)
                //.Include(c => c.CarrierStatus)
                .Include(c => c.ModifiedBy)
                .ToListAsync();
        }

        // GET: api/Carriers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Carrier>> GetCarrier(int id)
        {
            if (id == 0)
            {
                return new Carrier();
            }
            var ship = await _context.Carrier.Include(c => c.ModifiedBy).Include(e=>e.CreatedBy).FirstOrDefaultAsync(o => o.ID==id);

            if (ship == null)
            {
                return NotFound();
            }

            return ship;
        }

        // PUT: api/Carriers/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarrier(int id, Carrier ship)
        {
            if (id != ship.ID)
            {
                return BadRequest();
            }

            SetAuditData(ship.ID, ship);

            _context.Entry(ship).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarrierExists(id))
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

        // POST: api/Carriers
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Carrier>> PostCarrier(Carrier ship)
        {
            SetAuditData(ship.ID, ship);

            _context.Carrier.Add(ship);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCarrier", new { id = ship.ID }, ship);
        }

        // DELETE: api/Carriers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Carrier>> DeleteCarrier(int id)
        {
            var ship = await _context.Carrier.FindAsync(id);
            if (ship == null)
            {
                return NotFound();
            }

            _context.Carrier.Remove(ship);
            await _context.SaveChangesAsync();

            return ship;
        }

        private bool CarrierExists(int id)
        {
            return _context.Carrier.Any(e => e.ID == id);
        }
    }
}
