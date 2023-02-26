using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendDevIntroAPIWebApp.Models
{
    public class SiriusContext : DbContext
    {
        public SiriusContext(DbContextOptions<SiriusContext> options)
            : base(options)
        {
        }

        public DbSet<Stage> Stages { get; set; }
    }
}
