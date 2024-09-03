using Business.Abstract;
using Business.Constans;
using Business.DependencyResolvers.ValidationRules.FluentValidation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        // [LogAspect] --> AOP, Autofac ,AOP imkanı sunar
        public IResult Add(Product product)
        {
            var context=new ValidationContext<Product>(product);
            ProductValidator productValidator=new ();
            var result=productValidator.Validate (context);
            if(!result.IsValid)
            {
                throw new FluentValidation.ValidationException(result.Errors);
            }

            //business codes 
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAddes);
        }

        public IDataResult<List<Product>> GetAll()
        {
            if (DateTime.Now.Hour == 11) return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);

            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == 3), Messages.ProductsListed);
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new DataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId.Equals(id)), true, "Ürünler listelendi");
        }

        public IDataResult<Product> GetById(int productId)
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
