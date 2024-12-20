using Core.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public class Category:IEntity
	{
		//tree-like
		public int CategoryId { get; set; } 
		public string Name { get; set; } = string.Empty; 
		public string? Description { get; set; } 
		public int? ParentCategoryId { get; set; }
		public bool IsActive { get; set; } = true; 
		public DateTime CreatedAt { get; set; } = DateTime.UtcNow; 
		public DateTime UpdatedAt { get; set; } = DateTime.UtcNow; 

		public virtual ICollection<Category>? SubCategories { get; set; }
		public virtual Category? ParentCategory { get; set; }
	}
}
