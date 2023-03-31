using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories.EventRequestRepository
{
    internal class EventRequestManager : IEventRequestService
    {
        public Task<IResult> Add(EventRequest eventRequest)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Delete(int eventId)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Update(EventRequest eventRequest)
        {
            throw new NotImplementedException();
        }
    }
}
