using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class ProductManager : IProductService
	{
		IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
				_productDal = productDal;
        }

        public IResult Add(Product product)
        {
            if(product.ProductName.Length<2)
            {
                //magic string : stringleri ayrı ayrı yazmak
                return new ErrorResult(Messages.ProdutNameInvalid);
            }
            //business codes 
           _productDal.Add(product);
            return new SuccessResult(Messages.ProductAddes);
        }

        public IDataResult<List<Product>> GetAll()
		{
            if(DateTime.Now.Hour==22) return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
           
			 return new SuccessDataResult<List<Product>>(_productDal.GetAll(p=>p.CategoryId==3),Messages.ProductsListed);
		}

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
          return  new DataResult<List<Product>>( _productDal.GetAll(p=>p.CategoryId.Equals(id)),true,"Ürünler listelendi");
        }

        public  IDataResult<Product>GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId.Equals(productId)), Messages.ProductsListed);
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {

            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.UnitPrice > min && p.UnitPrice <= max), Messages.ProductsListed);  
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails(), Messages.ProductsListed);
        }


    }
}
