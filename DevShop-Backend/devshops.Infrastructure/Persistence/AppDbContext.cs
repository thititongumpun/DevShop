//using devshops.Domain.Entities;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Text;

//namespace devshops.Infrastructure.Persistence
//{
//    public class AppDbContext : DbContext, IAppDbContext
//    {
//        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

//        public DbSet<Developer> Developers { get; set; }
//        public DbSet<Position> positions { get; set; }
//        public DbSet<DeveloperPosition> DeveloperPosition { get; set; }
//    }
//}
