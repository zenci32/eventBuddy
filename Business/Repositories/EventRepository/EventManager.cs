﻿using Business.Abstract;
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
                EventStatus = "starting"
            };
            await _eventDal.Add(eventt);
            return new SuccessResult("Event başarıyla oluşturulmuştur", 200);
        }

        public Task<IResult> Delete(int eventId)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<List<Event>>> GetAllEvent()
        {
           var getAllEvent = await _eventDal.GetAll(x=>x.IsDeleted == false);

            return new SuccessDataResult<List<Event>>(getAllEvent,"Eventler listelenmiştir",200);
        }

        public Task<IDataResult<List<Event>>> GetPersonalEvent()
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Update(Event eventt)
        {
            throw new NotImplementedException();
        }
    }
}
