﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    
    //Context : Db tabloları ile proje classlarını bağlamak
    public class Context:DbContext
    {
        //Bu metod projenin hangi veritabanı şle ilişkili olduğunu belirler
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=AYZASOFT-0000;Integrated Security=True;Trust Server Certificate=True;Initial Catalog=Context");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
