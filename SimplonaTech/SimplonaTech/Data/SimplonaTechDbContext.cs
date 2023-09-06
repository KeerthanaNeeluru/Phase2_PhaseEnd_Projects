using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimplonaTech.Models;

namespace SimplonaTech.Data
{
    public class SimplonaTechDbContext : DbContext
    {
        public SimplonaTechDbContext (DbContextOptions<SimplonaTechDbContext> options)
            : base(options)
        {
        }

        public DbSet<SimplonaTech.Models.DeptMaster> DeptMaster { get; set; } = default!;

        public DbSet<SimplonaTech.Models.EmpProfile>? EmpProfile { get; set; }
    }
}
