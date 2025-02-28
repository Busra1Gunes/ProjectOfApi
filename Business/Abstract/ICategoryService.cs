using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface ICategoryService
	{
		IDataResult<List<CategoryDto>> GetAllAsync();
		IDataResult<CategoryDto> GetByIdAsync(int categoryId);
		IResult CreateAsync(CreateCategoryDto createCategoryDto);
		IResult UpdateAsync(UpdateCategoryDto updateCategoryDto);
		IResult DeleteAsync(int id);

	}
}
