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
    public class InventoryController : ControllerBase
    {
        private readonly AWMSAPIDBContext _context;

        public InventoryController(AWMSAPIDBContext context)
        {
            _context = context;
        }

        // GET: api/inventories
        [HttpGet]
        public async Task<ActionResult<PagedResult<Inventory>>> GetInventories()
        {
            var inventories = _context.Inventory;

            PagedResult<Inventory> pagedResult = await inventories.GetPagedAsync(1, 10);
            return pagedResult;
        }

        // GET: api/inventories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Inventory>> GetInventory(int id)
        {
            var inventory = await _context.Inventory
                .FirstOrDefaultAsync(i => i.ID == id);

            if (inventory == null)
            {
                return NotFound();
            }

            return inventory;
        }

        // PUT: api/inventories/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInventory(int id, Inventory inventory)
        {
            if (id != inventory.ID)
            {
                return BadRequest();
            }

            _context.Entry(inventory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InventoryExists(id))
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

        // POST: api/inventories
        [HttpPost]
        public async Task<ActionResult<Inventory>> PostInventory(Inventory inventory)
        {
            _context.Inventory.Add(inventory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInventory", new { id = inventory.ID }, inventory);
        }

        // DELETE: api/inventories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Inventory>> DeleteInventory(int id)
        {
            var inventory = await _context.Inventory.FindAsync(id);
            if (inventory == null)
            {
                return NotFound();
            }

            _context.Inventory.Remove(inventory);
            await _context.SaveChangesAsync();

            return inventory;
        }

        private bool InventoryExists(int id)
        {
            return _context.Inventory.Any(e => e.ID == id);
        }
    }
}
