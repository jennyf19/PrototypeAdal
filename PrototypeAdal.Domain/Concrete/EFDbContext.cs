using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrototypeAdal.Domain.Entities;

namespace PrototypeAdal.Domain.Concrete
{
    public class EfDbContext : DbContext
    {
        public DbSet<ReleaseRequest> ReleaseRequests { get; set; }
    }
}
