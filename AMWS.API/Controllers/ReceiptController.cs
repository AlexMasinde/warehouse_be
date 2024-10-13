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
    public class ReceiptController : BaseController
    {
        public ReceiptController(AWMSAPIDBContext context, IConfiguration configuration)
             : base(context, configuration)
        {
        }

        // GET: api/Receipts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Receipt>>> GetReceipts()
        {
            var receipts = await _context.Receipt.ToListAsync();
            return Ok(receipts);
        }

        // GET: api/Receipts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Receipt>> GetReceipt(int id)
        {
            if (id == 0)
            {
                return new Receipt();
            }

            var receipt = await _context.Receipt.FindAsync(id);

            if (receipt == null)
            {
                return NotFound();
            }

            return Ok(receipt);
        }

        // PUT: api/Receipts/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReceipt(int id, Receipt receipt)
        {
            if (id != receipt.ID)
            {
                return BadRequest();
            }

            SetAuditData(receipt.ID, receipt);

            _context.Entry(receipt).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReceiptExists(id))
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

        // POST: api/Receipts
        [HttpPost]
        public async Task<ActionResult<Receipt>> PostReceipt(Receipt receipt)
        {
            SetAuditData(receipt.ID, receipt);

            _context.Receipt.Add(receipt);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReceipt", new { id = receipt.ID }, receipt);
        }

        // DELETE: api/Receipts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Receipt>> DeleteReceipt(int id)
        {
            var receipt = await _context.Receipt.FindAsync(id);
            if (receipt == null)
            {
                return NotFound();
            }

            _context.Receipt.Remove(receipt);
            await _context.SaveChangesAsync();

            return receipt;
        }

        private bool ReceiptExists(int id)
        {
            return _context.Receipt.Any(e => e.ID == id);
        }
    }
}
