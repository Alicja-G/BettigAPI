using AutoMapper;
using BettingAPI.Dtos;
using BettingAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BettingAPI.Controllers
{
    [Route("api/event")]
    public class EventController : ControllerBase
    {
        private readonly BettingDbContext dbContext;
        private readonly IMapper mapper;

        public EventController(BettingDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<EventDto>> GetAll()
        {
            var events = dbContext.Events
                .Include(d => d.EventAdress)
                .Include(e => e.Confrontations)
                .ToList();

            var mappedEvents = mapper.Map<List<EventDto>>(events);
            return Ok(mappedEvents);
        }

        [HttpGet("{id}")]
        public ActionResult<EventDto> Get([FromRoute] int id)
        {
            var selectedEvent = dbContext.Events
                .Include(d => d.EventAdress)
                .Include(e => e.Confrontations)
                .FirstOrDefault(e => e.Id == id);

            if (selectedEvent is null) return NotFound();

            return Ok(mapper.Map<EventDto>(selectedEvent));
        }

        [HttpPost]
        public ActionResult CreateEvent([FromBody] CreateEventDto dto)
        {
            var newEvent = mapper.Map<Event>(dto);
            dbContext.Events.Add(newEvent);
            dbContext.SaveChanges();

            return Created($"/api/event/{newEvent.Id}", null);
        }
    }
}
