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
using Microsoft.Extensions.Configuration;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.AspNetCore.Html;
using JWarehouseSystem.BackEnd.Interfaces;
using System.IO;
using Microsoft.Extensions.Hosting.Internal;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting.Server;

namespace AWMS.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LookupController : BaseController
    {
        IConfiguration _config; 
        IWebHostEnvironment _environment;
        public LookupController(AWMSAPIDBContext context, IConfiguration configuration)
             : base(context, configuration)
        {
          //  _context = context;
          _config = configuration;
          
        }

        //GET: api/Regions
       [HttpGet]
       [Route("regions")]
        public async Task<ActionResult<IEnumerable<Region>>> GetRegions()
        {

            ActionResult<IEnumerable<Region>> result = await _context.Region.AsNoTracking().OrderBy(e => e.Name).ToListAsync();

            return result;

        }
        //GET: api/Locations
        [HttpGet]
        [Route("locations")]
        public async Task<ActionResult<IEnumerable<Location>>> GetLocations()
        {

            ActionResult<IEnumerable<Location>> result = await _context.Location.AsNoTracking().OrderBy(e => e.Name).ToListAsync();

            return result;

        }
        //GET: api/Warehouses
        [HttpGet]
        [Route("warehouses")]
        public async Task<ActionResult<IEnumerable<Warehouse>>> GetWarehouses()
        {

            ActionResult<IEnumerable<Warehouse>> result = await _context.Warehouse.AsNoTracking().OrderBy(e => e.Name).ToListAsync();

            return result;


        }

        //GET: api/Warehouses
        [HttpGet]
        [Route("departments")]
        public async Task<ActionResult<IEnumerable<Department>>> GetDepartments()
        {

            ActionResult<IEnumerable<Department>> result = await _context.Department.AsNoTracking().OrderBy(e => e.Name).ToListAsync();

            return result;

        }
        //GET: api/Warehouses
        [HttpGet]
        [Route("designations")]
        public async Task<ActionResult<IEnumerable<Designation>>> GetDesignations()
        {

            ActionResult<IEnumerable<Designation>> result = await _context.Designation.AsNoTracking().OrderBy(e => e.Name).ToListAsync();

            return result;

        }
        //GET: api/Area Purposes
        [HttpGet]
        [Route("areapurposes")]
        public async Task<ActionResult<IEnumerable<AreaPurpose>>> GetAreaPurposes()
        {

            ActionResult<IEnumerable<AreaPurpose>> result = await _context.AreaPurpose.AsNoTracking().OrderBy(e => e.Purpose).ToListAsync();

            return result;

        }
        //GET: api/Area Purposes
        [HttpGet]
        [Route("widgets")]
        public IActionResult GetWidgets()
        {
            var widgetpath = @"D:\\";
            var path=Path.Combine(widgetpath,"widget.html");
            //var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Hello.html");

            FileStream fileStream = System.IO.File.OpenRead(path);


            return File(fileStream, "text/html");



            //return new ContentResult
            //{
            //    ContentType = "text/html",
            //    Content = htmlContent
            //};



        }

    }
}
