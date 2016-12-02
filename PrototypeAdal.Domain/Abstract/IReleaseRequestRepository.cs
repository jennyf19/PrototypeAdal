using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrototypeAdal.Domain.Entities;

namespace PrototypeAdal.Domain.Abstract
{
    public interface IReleaseRequestRepository
    {
        //Allow a user to obtain a sequence of Request without knowing
        //where they are coming from or how the implemnetations class will
        //deliver them
        IEnumerable<ReleaseRequest> ReleaseRequests { get; }
    }
}
