using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
	public class InMemoryProductDal : IProductDal
	{
		List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
			{
				new Product{ProductId=1, ProductName="Bardak", CategoryId=1,UnitPrice=50,UnitsInStock=4},
				new Product{ProductId=2, ProductName="Kalem", CategoryId=1,UnitPrice=100,UnitsInStock=58 },
				new Product{ProductId=3, ProductName="Kağıt", CategoryId=2,UnitPrice=200,UnitsInStock=6},
				new Product{ProductId=4, ProductName="Elma", CategoryId=4,UnitPrice=50,UnitsInStock=5},
				new Product{ProductId=5, ProductName="Mouse", CategoryId=3,UnitPrice=20,UnitsInStock=12},
				new Product{ProductId=6, ProductName="Bilgisayar", CategoryId=1,UnitPrice=10,UnitsInStock=12}
			};
        }
        public void Add(Product product)
		{
			throw new NotImplementedException();
		}

		public void Delete(Product product)
		{
			Product productToDelete = _products.SingleOrDefault(a => a.ProductId.Equals(product.ProductId));
			_products.Remove(productToDelete);
		}

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
		{
			return _products.ToList();
		}

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
		{
			return _products.Where(p => p.CategoryId.Equals(categoryId)).ToList();
		}

		public void Update(Product product)
		{
			Product productToUpdate= _products.SingleOrDefault(a => a.ProductId.Equals(product.ProductId));
			productToUpdate.UnitPrice = 10;
			productToUpdate.UnitsInStock = 20;
			productToUpdate.ProductName = "Klavye";

		}
	}
}
