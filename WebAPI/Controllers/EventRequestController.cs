using Business.Repositories.EventRepository;
using Business.Repositories.EventRequestRepository;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventRequestController : ControllerBase
    {
        private readonly IEventRequestService _eventRequestService;

        public EventRequestController(IEventRequestService eventRequestService)
        {
            _eventRequestService = eventRequestService;
        }

        //[HttpPost("[action]")]
        //public async Task<IActionResult> AddEvent(EventDto eventDto)
        //{
        //    var result = await _eventRequestService.Add(eventDto);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}


    }
}
