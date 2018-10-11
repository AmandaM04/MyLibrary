using System;
using System.Collections.Generic;
using System.Text;
using MyLibrary.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MyLibrary.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Library> Library { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<MyLibrary.Models.Patron> Patron { get; set; }
    }
}