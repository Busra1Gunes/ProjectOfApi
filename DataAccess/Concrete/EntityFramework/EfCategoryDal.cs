using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
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
	public class EfCategoryDal : EfEntityRepositoryBase<Category, Context>, ICategoryDal
	{
		public async Task<List<Category>> GetActiveCategoriesAsync()
		{
			using (Context _context = new())
			{
				return await _context.Categories.Where(c => c.IsActive).ToListAsync();
			}
		}

		public async Task<Category?> GetCategoryWithSubcategoriesAsync(int categoryId)
		{
			using (Context _context = new())
			{
				return await _context.Categories
								 .Include(c => c.SubCategories)
								 .FirstOrDefaultAsync(c => c.CategoryId == categoryId);
			}
		}
	}
}
