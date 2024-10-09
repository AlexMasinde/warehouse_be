using AWMS.API.Data;
using JWarehouseSystem.Common.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace AWMS.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        private readonly AWMSAPIDBContext context;
        public IConfiguration Configuration { get; }

        public BaseController(AWMSAPIDBContext context, IConfiguration configuration)
        {
            this.context = context;
            Configuration = configuration;
        }

        public AWMSAPIDBContext _context => this.context;

        // Add explicit HTTP method binding for Swagger to recognize
        [HttpPost("logout")]
        public async Task<IActionResult> LogOut()
        {
            HttpContext.Session.Clear();
            await HttpContext.SignOutAsync();
            return NoContent();
        }

        [NonAction]
        public virtual void SetAuditData(int id, IUserAudit audit)
        {
            if (id == 0)
            {
                audit.CreatedByID = 1;
                audit.CreateOn = DateTime.Now;
            }
            audit.ModifiedByID = 1;
            audit.ModifiedOn = DateTime.Now;
        }
    }
}
