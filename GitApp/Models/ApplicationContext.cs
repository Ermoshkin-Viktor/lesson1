﻿using Microsoft.EntityFrameworkCore;

namespace GitApp.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();//создаем базу данных при первом обращении
        }
        public ApplicationContext()
        {

        }
    }
}
