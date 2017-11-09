using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Almost.Models;

namespace Almost.Model_Context
{
    public class UsersContext : DbContext
    {
        public UsersContext(DbContextOptions<UsersContext> opt) : base(opt) { }

        public DbSet<Users> Users { get; set; }
    }
}
