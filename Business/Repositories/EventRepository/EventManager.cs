using Business.Abstract;
using Business.Repositories.EmailRepository;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Repositories.EventRepository;
using DataAccess.Repositories.UserRepository;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories.EventRepository
{
    internal class EventManager : IEventService
    {
        private readonly IEventDal _eventDal;

        public EventManager(IEventDal eventDal)
        {
            _eventDal = eventDal;
        }
        public async Task<IResult> Add(EventDto eventDto)
        {
            var eventt = new Event
            {
                ActiveCount = 0,
                EventCategory = eventDto.EventCategory,
                EventDate = eventDto.EventDate,
                EventCount = eventDto.EventCount,
                EventCreateDate = DateTime.Now,
                EventDescription = eventDto.EventDescription,
                EventLastUpdateDate = DateTime.Now,
                EventName = eventDto.EventName,
                EventLatitude = eventDto.EventLatitude,
                EventLongitude = eventDto.EventLongitude,
                IsDeleted = false,
                Phone = eventDto.Phone,
                EventStatus = "active"
            };
            await _eventDal.Add(eventt);
            return new SuccessResult("Event başarıyla oluşturulmuştur", 200);
        }

        public async Task<IResult> Delete(int eventId)
        {
            var getEvent = _eventDal.Get(x=>x.EventId== eventId).Result;
            getEvent.IsDeleted= true;
            await _eventDal.Update(getEvent);
            return new SuccessResult("Event başarıyla silinmiştir", 200);
        }

        public async Task<IDataResult<List<Event>>> GetAllEvent()
        {
           var getAllEvent = await _eventDal.GetAll(x=>x.IsDeleted == false);

            return new SuccessDataResult<List<Event>>(getAllEvent,"Eventler listelenmiştir",200);
        }

        public async Task<IDataResult<List<Event>>> GetPersonalEvent(string phone)
        {
            var getPersonAllEvent = await _eventDal.GetAll(x => x.Phone==phone);
            return new SuccessDataResult<List<Event>>(getPersonAllEvent, "Eventler başarılı bir şekilde listelenmiştir", 200);
        }

        public async Task<IResult> Update(Event eventt)
        {
            await _eventDal.Update(eventt);
            return new SuccessResult("Event başarıyla güncellenmiştir", 200);
        }
    }
}
