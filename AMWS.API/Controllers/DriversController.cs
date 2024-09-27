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
    public class DriversController : BaseController
    {
       

        public DriversController(AWMSAPIDBContext context, IConfiguration configuration)
             : base(context, configuration)
        {
           
        }

        //GET: api/DriverStatuses
       [HttpGet]
        public async Task<ActionResult<IEnumerable<Driver>>> GetDriver()
        {
            return await _context.Driver
                //.Include(c => c.Driver)
                //.Include(e => e.AuthorizedBy)
                //.Include(c=> c.InvoiceToAddress)
                //.Include(c => c.ShipToAddress)
                //.Include(c => c.DriverStatus)
                .Include(c => c.ModifiedBy)
                .ToListAsync();
        }

     
        // GET: api/Driver/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Driver>> GetDriver(int id)
        {
            if (id == 0)
            {
                return new Driver();
            }

            var driver = await _context.Driver.Include(c => c.ModifiedBy).Include(e=>e.CreatedBy).FirstOrDefaultAsync(o => o.ID==id);

            if (driver == null)
            {
                return NotFound();
            }

            return driver;
        }

        // PUT: api/Drivers/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDriver(int id, Driver driver)
        {
            if (id != driver.ID)
            {
                return BadRequest();
            }

            SetAuditData(driver.ID, driver);

            _context.Entry(driver).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DriverExists(id))
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

        // POST: api/DriverStatuses
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Driver>> PostDriver(Driver driver)
        {

            SetAuditData(driver.ID, driver);

            _context.Driver.Add(driver);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDriver", new { id = driver.ID }, driver);
        }

        // DELETE: api/DriverStatuses/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Driver>> DeleteDriver(int id)
        {
            var driver = await _context.Driver.FindAsync(id);
            if (driver == null)
            {
                return NotFound();
            }

            _context.Driver.Remove(driver);
            await _context.SaveChangesAsync();

            return driver;
        }

        private bool DriverExists(int id)
        {
            return _context.Driver.Any(e => e.ID == id);
        }
    }
}
