using Microsoft.EntityFrameworkCore;
using my_books.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// The Entity Framework Core DbContext class represents a session with a database and provides an API for communicating with the database

namespace my_books.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        // public DbSet<ModelClassName> DBTableName { get; set; }
        // The object used to read or write data into the Books Table
        public DbSet<Book> Books { get; set; }
    }
}
