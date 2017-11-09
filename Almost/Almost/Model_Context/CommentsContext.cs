using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using Almost.Models;

namespace Almost.Model_Context
{
    public class CommentsContext : DbContext
    {
        public CommentsContext(DbContextOptions<CommentsContext> opt) : base(opt) { }

        public DbSet<Comments> Comments { get; set; }

    }
}
