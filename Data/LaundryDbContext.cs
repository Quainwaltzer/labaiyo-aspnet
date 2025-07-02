using LabaIyo.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LabaIyo.Data
{
    public class LaundryDbContext : DbContext
    {
        

        public LaundryDbContext(DbContextOptions<LaundryDbContext> options) : base(options) { }
        public DbSet<Laundry> laundryDb { get; set; }
    }
}
