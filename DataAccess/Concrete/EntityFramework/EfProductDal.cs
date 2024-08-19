using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            //using içindeki yazılan nesneler using işlemi bitince bellekten atılır
            using (NorthwindContext context = new())
            {
                var addedEntity = context.Entry(entity); //referansı yakala
                addedEntity.State = EntityState.Added;//eklenecek bir nesne
                context.SaveChanges(); //ekle
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new())
            {
                var deletedEntity = context.Entry(entity); //referansı yakala
                deletedEntity.State = EntityState.Deleted;//silinecek bir nesne
                context.SaveChanges(); //sil
            }
        }
         
        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using(NorthwindContext context = new())
            {
                return context.Set<Product>().SingleOrDefault(filter );
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new())
            {

                return filter == null
                    ? context.Set<Product>().ToList()
                    : context.Set<Product>().Where(filter).ToList();
            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new())
            {
                var updatedEntity = context.Entry(entity); //referansı yakala
                updatedEntity.State = EntityState.Modified;//güncellenecek bir nesne
                context.SaveChanges(); //güncelle
            }
        }
    }
}
