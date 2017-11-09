using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Almost.Models;



namespace Almost.Model_Context
{
    public class CommentLikeOrDislikeContext : DbContext
    {
        public CommentLikeOrDislikeContext(DbContextOptions<CommentLikeOrDislikeContext> opt) : base(opt) { }

        public DbSet<CommentsLikeOrDislike> CommentLikeOrDislike { get; set; }
    }
}