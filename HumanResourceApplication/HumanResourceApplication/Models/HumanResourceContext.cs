using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResourceApplication.Models
{
    public class HumanResourceContext : DbContext
    {
        public HumanResourceContext(DbContextOptions<HumanResourceContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

    }
}
