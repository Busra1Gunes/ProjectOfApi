using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
	public class CreateCategoryDto
	{
		public string Name { get; set; } = string.Empty;
		public string? Description { get; set; }
		public int? ParentCategoryId { get; set; }
	}
}
