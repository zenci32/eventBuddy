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
        Task<IResult> Add(EventRequest eventRequest);
        Task<IResult> Update(EventRequest eventRequest);
        Task<IResult> Delete(int eventId);

    }
}
