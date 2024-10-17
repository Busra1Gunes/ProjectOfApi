using Core.Utilities.Results;
using Entities;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface IProductService
	{
		IDataResult<List<Product>> GetAll();

		IDataResult<List<Product>> GetAllByCategoryId(int id);
		
		IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);

		IDataResult<List<ProductDetailDto>> GetProductDetails();

		IDataResult<Product> GetById(int productId);

		IResult Add(ProductDto product, string url);
        IResult Update(Product product);


    }
}
