using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using Almost.Models;

namespace Almost.Model_Context
{
    public class ReplieContext : DbContext
    {
        public ReplieContext(DbContextOptions<ReplieContext> opt) : base(opt) { }

        public DbSet<Replie> Replies { get; set; }
    }
}
