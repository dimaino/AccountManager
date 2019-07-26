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
    public class TestController : ControllerBase
    {
        private readonly Context _Context;
        public TestController(Context Context)
        {
            _Context = Context;
        }

        // GET api/test
        [HttpGet]
        public async Task<IActionResult> GetEmailAccounts()
        {
            try
            {
                return Ok(await _Context.EmailAccounts.Include(ea => ea.Platforms).ToListAsync());
            }
            catch(Exception ex)
            {
                return StatusCode(500, "Internal Server Error.");
            }
        }

        // GET api/test/games
        [HttpGet("games")]
        public async Task<IActionResult> GetGames()
        {
            try
            {
                return Ok(await _Context.Games.Include(g => g.Platform).Include(g => g.Codes).ThenInclude(c => c.Account).Select(g => new {
                    Id = g.GameId,
                    GameTitle = g.Name.ToUpper(),
                    Platform = g.Platform.Name,
                    NumberOfAccounts = g.Codes.Count()
                }).ToArrayAsync());
            }
            catch(Exception ex)
            {
                return StatusCode(500, "Internal Server Error.");
            }
        }

        // GET api/test/listgames
        [HttpGet("listgames")]
        public async Task<IActionResult> ListGames()
        {
                return Ok(await _Context.Games.Include(g => g.Platform).Select(g => new {
                    Id = g.GameId,
                    Title = g.Name,
                    Platform = g.Platform.Name,
                    NumberOfAccounts = g.Codes.Count()
                }).ToListAsync());

        }

        // GET api/test/games/1
        [HttpGet("games/{id}")]
        public async Task<IActionResult> GetGameWithID(int id)
        {
            return Ok(await _Context.Games.Include(g => g.Codes).ThenInclude(c => c.Account).ThenInclude(a => a.EmailAccount).Select(g => new {
                g.GameId,
                Title = g.Name,
                Accounts = g.Codes.Select(c => new {
                    Code = c.CodeString,
                    AccountId = c.Account.AccountId,
                    Username = c.Account.Username,
                    Password = c.Account.Password,
                    Email = c.Account.EmailAccount.Email,
                    EmailPassword = c.Account.EmailAccount.EmailPassword
                })
            }).FirstOrDefaultAsync(g => g.GameId == id));
        }

        // GET api/test/platforms
        [HttpGet("platforms")]
        public async Task<IActionResult> GetPlatforms()
        {
            try
            {
                return Ok(await _Context.Platforms.Include(p => p.Accounts).ToListAsync());
            }
            catch(Exception ex)
            {
                return StatusCode(500, "Internal Server Error.");
            }
        }

        // GET api/test/codes
        [HttpGet("codes")]
        public async Task<IActionResult> GetCodes()
        {
            try
            {
                return Ok(await _Context.Codes.Select(c => new{
                    c.CodeId,
                    c.Account.Username,
                    c.Game.Name
                }).ToListAsync());
            }
            catch(Exception ex)
            {
                return StatusCode(500, "Internal Server Error.");
            }
        }

        // GET api/test/events
        [HttpGet("events")]
        public async Task<IActionResult> GetEvents()
        {
            try
            {
                return Ok(await _Context.Events.Include(e => e.Accounts).Select(e => new {
                    EventId = e.EventId,
                    Name = e.Name,
                    Location = e.Location,
                    StartDate = e.CreatedAt.ToString("MM-dd-yyyy"),
                    EndDate = e.UpdatedAt.ToString("MM-dd-yyyy"),
                    AccountsConfirmed = e.Accounts.Count()
                }).ToListAsync());
            }
            catch(Exception ex)
            {
                return StatusCode(500, "Internal Server Error.");
            }
        }

        // GET api/test/accounts
        [HttpGet("accounts")]
        public async Task<IActionResult> GetAccounts()
        {
            try
            {
                return Ok(await _Context.Accounts.Include(a => a.Codes).Select(a => new{
                    Id = a.AccountId,
                    Username = a.Username,
                    a.Platform.Name,
                    Codes = a.Codes.Select(c => new {
                        Game = c.Game.Name
                    })
                }).ToListAsync());
            }
            catch(Exception ex)
            {
                return StatusCode(500, "Internal Server Error.");
            }
        }

        // Get api/test/accountslist
        [HttpGet("accountslist")]
        public async Task<IActionResult> GetAccountList()
        {
            return Ok(await _Context.Accounts.Include(a => a.Event).Include(a => a.Platform).Select(a => new {
                AccountId = a.AccountId,
                Username = a.Username,
                Password = a.Password,
                Platform = a.Platform.Name,
                Event = a.Event.Name,
                Location = a.Event.Location
            }).ToListAsync());
        }

        // GET api/test/gameplatforms
        [HttpGet("gameplatforms")]
        public async Task<IActionResult> GetGamePlatforms()
        {
            try
            {
                return Ok(await _Context.GamePlatforms.ToListAsync());
            }
            catch(Exception ex)
            {
                return StatusCode(500, "Internal Server Error.");
            }
        }
    }
}
