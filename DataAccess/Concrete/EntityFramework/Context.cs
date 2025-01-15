using Core.Concrete;
using Entities.Concrete;
using Entities.Seeds;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
            optionsBuilder.UseSqlServer("Data Source=DESKOP123;Initial Catalog=SocialBelieve;Integrated Security=True;Trust Server Certificate=True");
			
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			
			modelBuilder.ApplyConfiguration(new CategorySeed());
			
		}
		public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Email> Emails { get; set; }
    }
}
