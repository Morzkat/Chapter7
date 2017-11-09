using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using Almost.Models;

namespace Almost.Model_Context
{
    public class HistoryLikeOrDislikeContext : DbContext
    {
        public HistoryLikeOrDislikeContext(DbContextOptions<HistoryLikeOrDislikeContext> opt) : base(opt) { }

        public DbSet<HistoryLikeOrDislike>HistoryLikeOrDislike { get; set; }
    }
}
