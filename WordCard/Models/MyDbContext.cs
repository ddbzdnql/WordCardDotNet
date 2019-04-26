using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace WordCard.Models
{
    public class MyDbContext : DbContext{

        public MyDbContext(DbContextOptions<MyDbContext> opt) 
            : base(opt){}

        //public MyDbContext() { }

        public DbSet<Word> Words { get; set; }
    }
}
