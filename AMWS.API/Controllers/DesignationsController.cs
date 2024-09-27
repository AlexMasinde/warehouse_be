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
    public class DesignationsController : BaseController
    {
      
        public DesignationsController(AWMSAPIDBContext context, IConfiguration configuration)
             : base(context, configuration)
        {
          
        }

        //GET: api/Designations
       [HttpGet]
        public async Task<ActionResult<IEnumerable<Designation>>> GetDesignation()
        {
            return await _context.Designation
                //.Include(c => c.Customer)
                //.Include(e => e.AuthorizedBy)
                //.Include(c=> c.InvoiceToAddress)
                //.Include(c => c.ShipToAddress)
                //.Include(c => c.DesignationStatus)
                .Include(c => c.ModifiedBy)
                .ToListAsync();
        }

     
        // GET: api/Designations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Designation>> GetDesignation(int id)
        {
            if (id == 0) {
                return new Designation();
            }
            var designation = await _context.Designation.Include(c => c.ModifiedBy).Include(e=>e.CreatedBy).FirstOrDefaultAsync(o => o.ID==id);

            if (designation == null)
            {
                return NotFound();
            }

            return designation;
        }

        // PUT: api/Designations/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDesignation(int id, Designation designation)
        {
            if (id != designation.ID)
            {
                return BadRequest();
            }

            SetAuditData(designation.ID, designation);

            _context.Entry(designation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DesignationExists(id))
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

        // POST: api/Designations
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Designation>> PostDesignation(Designation designation)
        {
            SetAuditData(designation.ID, designation);
            _context.Designation.Add(designation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDesignation", new { id = designation.ID }, designation);
        }

        // DELETE: api/Designations/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Designation>> DeleteDesignation(int id)
        {
            var designation = await _context.Designation.FindAsync(id);
            if (designation == null)
            {
                return NotFound();
            }

            _context.Designation.Remove(designation);
            await _context.SaveChangesAsync();

            return designation;
        }

        private bool DesignationExists(int id)
        {
            return _context.Designation.Any(e => e.ID == id);
        }
    }
}
