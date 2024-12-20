using AutoMapper;
using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class CategoryManager : ICategoryService
	{
		ICategoryDal _categoryDal;
		IMapper _mapper;

		public CategoryManager(ICategoryDal categoryDal, IMapper mapper)
		{
			_categoryDal = categoryDal;
			_mapper = mapper;
		}

		public  IResult CreateAsync(CreateCategoryDto createCategoryDto)
		{
			var category = _mapper.Map<Category>(createCategoryDto);
			 _categoryDal.Add(category);

			//_categoryDal.Add(createCategoryDto); // Kategori eklenir.
			return new SuccessResult(Messages.CategoryAdded); // Başarı mesajı döndürülür.
		}


		public IResult DeleteAsync(int categoryId)
		{
			var category = _categoryDal.Get(c => c.CategoryId == categoryId);
			if (category == null)
			{
				return new ErrorResult(Messages.CategoryNotFound); 
			}

			var subCategories = _categoryDal.GetAll(c => c.ParentCategoryId == categoryId);
			if (subCategories.Any())
			{
				return new ErrorResult(Messages.CategoryHasSubCategories); 
			}

			_categoryDal.Delete(category);
			return new SuccessResult(Messages.CategoryDeleted); 
		}

		public  IDataResult<List<CategoryDto>> GetAllAsync()
		{
			var categories = _categoryDal.GetAll(); 
			var categoryDtos = _mapper.Map<List<CategoryDto>>(categories); 
			return new SuccessDataResult<List<CategoryDto>>(categoryDtos, Messages.CategoriesListed); 
		}

		public  IDataResult<CategoryDto> GetByIdAsync(int categoryId)
		{
			var category = _categoryDal.Get(c => c.CategoryId == categoryId);
			if (category == null)
			{
				return new ErrorDataResult<CategoryDto>(Messages.CategoryNotFound);
			}
			var categoryDtos = _mapper.Map<CategoryDto>(category);
			return new SuccessDataResult<CategoryDto>(categoryDtos, Messages.CategoryListed); 
		}


		public IDataResult<List<Category>> GetSubCategories(int parentCategoryId)
		{
			var subCategories = _categoryDal.GetAll(c => c.ParentCategoryId == parentCategoryId); // Alt kategoriler alınır.
			return new SuccessDataResult<List<Category>>(subCategories, Messages.SubCategoriesListed); // Alt kategoriler başarıyla döndürülür.
		}


		public IResult UpdateAsync(UpdateCategoryDto updateCategoryDto)
		{
			var existingCategory = _categoryDal.Get(c => c.CategoryId == updateCategoryDto.CategoryId);
			if (existingCategory == null)
			{
				return new ErrorResult(Messages.CategoryNotFound); // Kategori bulunamazsa hata mesajı döndürülür.
			}

			existingCategory.Name = updateCategoryDto.Name;
			existingCategory.Description = updateCategoryDto.Description;
			existingCategory.ParentCategoryId = updateCategoryDto.ParentCategoryId;

			_categoryDal.Update(existingCategory); // Kategori güncellenir.
			return new SuccessResult(Messages.CategoryUpdated); // Başarı mesajı döndürülür.
		}
	}
}
