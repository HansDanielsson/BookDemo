using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookDemo.Models;

namespace BookDemo.Data
{
    public class BookDemoContext : DbContext
    {
        public BookDemoContext (DbContextOptions<BookDemoContext> options)
            : base(options)
        {
        }

        public DbSet<BookDemo.Models.Book> Book { get; set; } = default!;
    }
}
