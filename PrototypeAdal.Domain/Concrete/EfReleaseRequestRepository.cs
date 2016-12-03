using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrototypeAdal.Domain.Entities;
using PrototypeAdal.Domain.Abstract;

namespace PrototypeAdal.Domain.Concrete
{
    public class EfReleaseRequestRepository : IReleaseRequestRepository
    {
        private EfDbContext context = new EfDbContext();

        public IEnumerable<ReleaseRequest> ReleaseRequests
        {
            get { return context.ReleaseRequests; }
        }
    }
}
