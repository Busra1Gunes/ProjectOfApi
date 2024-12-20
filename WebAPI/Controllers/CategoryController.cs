using Business.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoryController : ControllerBase
	{
		private readonly ICategoryService _categoryService;

		public CategoryController(ICategoryService categoryService)
		{
			_categoryService = categoryService;
		}

		[HttpGet]
		public IActionResult GetAll()
		{
			var result =  _categoryService.GetAllAsync();
			return Ok(result);
		}

		[HttpGet("{id}")]
		public IActionResult GetById(int id)
		{
			var result =  _categoryService.GetByIdAsync(id);
			return Ok(result);
		}

		[HttpPost]
		public IActionResult Create(CreateCategoryDto createCategoryDto)
		{
			 _categoryService.CreateAsync(createCategoryDto);
			return Ok();
		}

		[HttpPut]
		public IActionResult Update(UpdateCategoryDto updateCategoryDto)
		{
			 _categoryService.UpdateAsync(updateCategoryDto);
			return Ok();
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			 _categoryService.DeleteAsync(id);
			return Ok();
		}
	}
}
