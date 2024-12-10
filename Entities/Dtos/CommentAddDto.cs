using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class CommentAddDto
    {
        public int ProductId { get; set; }
        public decimal Score { get; set; }
        public string Comments { get; set; }
        public bool IsPurchased { get; set; } //satın alındı mı
        public IFormFile? fotograf { get; set; }
    }
}
