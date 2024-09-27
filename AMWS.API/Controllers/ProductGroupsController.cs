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
    public class ProductGroupsController : BaseController
    {
    

        public ProductGroupsController(AWMSAPIDBContext context, IConfiguration configuration)
             : base(context, configuration)
        {
           
        }

        //GET: api/ProductCategorys
       [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductCategory>>> GetProductGroup()
        {
            return await _context.ProductCategory
                //.Include(c => c.Customer)
                //.Include(e => e.AuthorizedBy)
                //.Include(c=> c.InvoiceToAddress)
                //.Include(c => c.ShipToAddress)
                //.Include(c => c.ProductCategoryStatus)
                .Include(c => c.ModifiedBy)
                .ToListAsync();
        }

     
        // GET: api/ProductCategorys/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductCategory>> GetProductGroup(int id)
        {
            if (id == 0)
            {
                return new ProductCategory();
            }

            var productCategory = await _context.ProductCategory.Include(c => c.ModifiedBy).Include(e=>e.CreatedBy).FirstOrDefaultAsync(o => o.ID==id);

            if (productCategory == null)
            {
                return NotFound();
            }

            return productCategory;
        }

        // PUT: api/ProductCategorys/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductGroup(int id, ProductCategory productCategory)
        {
            if (id != productCategory.ID)
            {
                return BadRequest();
            }

            SetAuditData(productCategory.ID, productCategory);

            _context.Entry(productCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductCategoryExists(id))
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

        // POST: api/ProductCategorys
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<ProductCategory>> PostProductGroup(ProductCategory productCategory)
        {
            SetAuditData(productCategory.ID, productCategory);

            _context.ProductCategory.Add(productCategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductCategory", new { id = productCategory.ID }, productCategory);
        }

        // DELETE: api/ProductCategorys/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ProductCategory>> DeleteProductGroup(int id)
        {
            var productCategory = await _context.ProductCategory.FindAsync(id);
            if (productCategory == null)
            {
                return NotFound();
            }

            _context.ProductCategory.Remove(productCategory);
            await _context.SaveChangesAsync();

            return productCategory;
        }

        private bool ProductCategoryExists(int id)
        {
            return _context.ProductCategory.Any(e => e.ID == id);
        }
    }
}
