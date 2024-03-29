﻿using Microsoft.EntityFrameworkCore;
using ZooCtrlApi.Models;

namespace ZooCtrlApi.Data
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-BKEG8HP;Initial Catalog=ZooCtrlApi;Integrated Security=True");
        }

        public DbSet<Animal> Animal { get; set; }
        public DbSet<Filo> Filo { get; set; }
        public DbSet<Zona> Zona { get; set; }
    }
}
