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
using Microsoft.AspNetCore.Http.HttpResults;

namespace AWMS.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : BaseController
    {


        public ProductsController(AWMSAPIDBContext context, IConfiguration configuration)
             : base(context, configuration)
        {

        }

        //GET: api/ProductStatuses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProduct()
        {
            var products = await _context.Product
                            .Select(p => new
                            {
                                p.ID,
                                p.Name,
                                p.GUID,
                                p.Price,
                                p.Brand,
                                p.Description,
                                p.SKU,
                                p.CreateOn,
                                p.ModifiedOn,
                                p.ModifiedBy,
                                p.ProductCategory,
                                p.ProductCodes
                            })
                            .ToListAsync();

            return Ok(products);
        }


        // GET: api/ProductStatuses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            if (id == 0)
            {
                return new Product();
            }
            // var product = await _context.Product.Include(c => c.ModifiedBy).Include(e => e.ProductCategory).FirstOrDefaultAsync(o => o.ID == id);

            var product = await _context.Product.Select(p => new
            {
                p.ID,
                p.Name,
                p.GUID,
                p.Price,
                p.Brand,
                p.Description,
                p.SKU,
                p.CreateOn,
                p.ModifiedOn,
                p.ProductCategory,
                p.ProductCodes
            }).FirstOrDefaultAsync(o => o.ID == id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // PUT: api/ProductStatuses/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, Product product)
        {
            if (id != product.ID)
            {
                return BadRequest();
            }

            SetAuditData(product.ID, product);

            _context.Entry(product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
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

        // POST: api/ProductStatuses
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            SetAuditData(product.ID, product);

            _context.Product.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProduct", new { id = product.ID }, product);
        }

        // DELETE: api/ProductStatuses/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Product>> DeleteProduct(int id)
        {
            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.Product.Remove(product);
            await _context.SaveChangesAsync();

            return product;
        }

        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.ID == id);
        }
    }
}
