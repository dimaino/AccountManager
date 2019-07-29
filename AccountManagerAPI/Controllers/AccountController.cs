using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AccountManagerAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AccountManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly Context _Context;
        public AccountController(Context Context)
        {
            _Context = Context;
        }

        // GET api/account
        [HttpGet]
        public async Task<IActionResult> GetAccounts()
        {
            try
            {
                return Ok(await _Context.EmailAccounts.ToListAsync());
            }
            catch(Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex);
            }
        }
    }
}
