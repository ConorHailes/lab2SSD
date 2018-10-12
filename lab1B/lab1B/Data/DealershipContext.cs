using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using lab1B.Models;

namespace lab1B.Models
{
    public class DealershipContext : DbContext
    {
        public DealershipContext (DbContextOptions<DealershipContext> options)
            : base(options)
        {
        }

        public DbSet<lab1B.Models.Car> Car { get; set; }

        public DbSet<lab1B.Models.Member> Member { get; set; }

        public DbSet<lab1B.Models.Dealership> Dealership { get; set; }
    }
}
