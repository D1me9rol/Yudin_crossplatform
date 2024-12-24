using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Yudin_back.Models;

namespace Yudin_back.Data
{
    public class Yudin_backContext : DbContext
    {
        public Yudin_backContext (DbContextOptions<Yudin_backContext> options)
            : base(options)
        {
        }

        public DbSet<Yudin_back.Models.Member> Member { get; set; } = default!;
        public DbSet<Yudin_back.Models.Book> Book { get; set; } = default!;
        public DbSet<Yudin_back.Models.Borrowing> Borrowing { get; set; } = default!;
    }
}
