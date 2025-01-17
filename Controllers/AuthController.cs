using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using requitools_be.Context;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Collections.Generic;
using requitools_be.Entities;

namespace requitools_be.Controllers
{
    [ApiController]
    [Route("api/autores")]
    public class AuthController:ControllerBase
    {
        private readonly RequiToolsDbContext RequiToolsCtx;
        public AuthController(RequiToolsDbContext ctx)
        {
            RequiToolsCtx = ctx;
        }
        [HttpGet("/getUsers")]
        public async Task<IActionResult> Get()
        {
            FormattableString sqlQuery=$"select*from View_1";
            List<View2> affectedRows = await RequiToolsCtx.Database.SqlQuery<View2>($"select name from View_1").AsNoTracking().ToListAsync(); 
            return Ok(affectedRows);
        }
    }
}
