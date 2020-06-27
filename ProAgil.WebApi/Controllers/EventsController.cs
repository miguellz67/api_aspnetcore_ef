using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProAgil.Repository;


namespace ProAgil.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventsController : ControllerBase
    {
        private readonly DataContext _context;
        public EventsController(DataContext context)
        {
            _context = context;
        }
    

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var eves = await _context.Events.ToListAsync();
                return Ok(eves);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "An error has ocurred on server");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEvent(int? id)
        {
            try
            {
                if (id == null)
                {
                    return this.StatusCode(StatusCodes.Status400BadRequest);
                }
                
                var eve = await _context.Events.FindAsync(id);
                
                if(eve == null)
                {
                    return NotFound();
                }
                
                return Ok(eve);
            }
            catch (Exception)
            {
               return this.StatusCode(StatusCodes.Status500InternalServerError, "An error has ocurred on server");
            }
        }
    }
}
