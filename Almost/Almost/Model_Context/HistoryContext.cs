using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Almost.Models;

namespace Almost.Model_Context
{
    public class HistoryContext : DbContext
    {
        public HistoryContext(DbContextOptions<HistoryContext> opt ):base(opt) { }

        public DbSet<History> History { get; set; }
    }
}
