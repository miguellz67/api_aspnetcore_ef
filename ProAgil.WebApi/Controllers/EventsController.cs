using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ProAgil.Domain;
using ProAgil.Repository;

namespace ProAgil.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IProAgilRepository _repository;
        public EventsController(IProAgilRepository repository)
        {
            this._repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetEvents()
        {
            try
            {
                var events = await _repository.GetEventsAsync(true);
                return Ok(events);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("getByTheme/{theme}")]
        public async Task<IActionResult> GetEventsByTheme(string theme)
        {
            try
            {
                var result = await _repository.GetEventsAsyncByTheme(theme, true);
                return Ok(result);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("{EventId:int}")]
        public async Task<IActionResult> GetEvent(int EventId)
        {
            try
            {
                var result = await _repository.GetEventAsync(EventId, true);
                return Ok(result);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        public async Task<IActionResult> PostEvent(Event model)
        {
            try
            {
                _repository.Add(model);

                if(await _repository.SaveChangesAsync())
                {
                    return Created($"/api/events/{model.Id}", model);
                }
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError);
            }

            return BadRequest();
        }

        [HttpPut("{EventId:int}")]
        public async Task<IActionResult> PutEvent(int EventId, Event model)
        {
            try
            {
                var eve = await _repository.GetEventAsync(EventId, false);
                
                if(eve == null)
                {
                    return NotFound();
                }

                _repository.Update(model);

                return Created($"/api/events/{model.Id}", model);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpDelete("{EventId:int}")]
        public async Task<IActionResult> DeleteEvent(int EventId)
        {
            try
            {
                var eve = await _repository.GetEventAsync(EventId, false);

                if (eve == null) return NotFound();

                _repository.Delete(eve);

                return Ok();
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
