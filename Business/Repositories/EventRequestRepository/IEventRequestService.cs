using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories.EventRequestRepository
{
    public interface IEventRequestService
    {
        Task<IResult> EventRequest(int eventId,string inviterPhone);
        Task<IResult> Update(EventRequest eventRequest);
        Task<IResult> EventRequestCancel(int eventId,string inviterPhone);

        /// <summary>
        /// request tablosundan aldığımız eventIdleri event tablosundan getirip yolluyoruz
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        IDataResult<List<Event>> GetPersonalEventRequest(string phone);

        IDataResult<List<RequestEventNotifyDto>> GetRequestEventNotify(string phone);

        IResult GetAcceptOrReject(string invaterPhone, int eventId,bool status);

    }
}
