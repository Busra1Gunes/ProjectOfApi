using AutoMapper;
using Business.Abstract;
using Business.CCS;
using Business.Constans;
using Business.DependencyResolvers.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
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
        //Bir manager içinde kendi dal'ı hariç dal enjeksiyonu yapılamaz!!!
        ICategoryService _categoryService;
        readonly IMapper _mapper;
        ILogger _logger;
        public ProductManager(IProductDal productDal,ICategoryService categoryService, ILogger logger,IMapper mapper)
        {
            _productDal = productDal;
            _logger = logger;
            _mapper = mapper;
            _categoryService = categoryService;
        }
        // [LogAspect] --> AOP, Autofac ,AOP imkanı sunar
        //Validation nesnenin yapısal olarak uygun olup olmadığını kontrol eder
        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(ProductDto product, string url)
        {

            //business codes 
            IResult result = BusinessRules.Run(
                  CheckIfProductCountCategoryCorrect(product.CategoryId),
                  CheckIfProductNameExists(product.ProductName),
                  CheckIfCategoryLimitExceded());
            if (result != null)
            {
                return result;
               
            }
            string? sqlResimYolu = null;
            if (product.fotograf != null)
            {
                var uzanti = Path.GetExtension(product.fotograf.FileName);

                var tarihSaatDakikaSaniyeSalise = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                var resimYolu = $"wwwroot/ProductFoto/{tarihSaatDakikaSaniyeSalise}{uzanti}";
                sqlResimYolu = $"{url}/ProductFoto/{tarihSaatDakikaSaniyeSalise}{uzanti}";

                using (var stream = new FileStream(resimYolu, FileMode.Create))
                {
                    product.fotograf.CopyTo(stream);
                }
            }
            Product product1 = _mapper.Map<Product>(product);
            _productDal.Add(product1);
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
        [ValidationAspect(typeof(ProductValidator))]
        public IResult Update(Product product)
        {
            if (CheckIfProductCountCategoryCorrect(product.CategoryId).Success)
            {
                throw new NotImplementedException();
            }
            return new ErrorResult();

        }
        private IResult CheckIfProductCountCategoryCorrect(int categoryId)
        {
            var result = _productDal.GetAll(p => p.CategoryId == categoryId).Count();
            if (result > 15)
            {
                return new ErrorResult(Messages.ProductCountOfCategoryError);
            }
            return new SuccessResult();

        }
        private IResult CheckIfProductNameExists(string productName)
        {
            var result = _productDal.GetAll(p => p.ProductName == productName).Any(); //var mı?
            if (result)
            {
                return new ErrorResult(Messages.ProductNameAlreadyExists);
            }
            return new SuccessResult();

        }
        private IResult CheckIfCategoryLimitExceded()
        {
            var result = _categoryService.GetAll().Data.Count; //var mı?
            if (result>15)
            {
                return new ErrorResult(Messages.CategoryLimitExceded);
            }
            return new SuccessResult();

        }
    }
}
