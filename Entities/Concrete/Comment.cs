using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Comment : IEntity
    {
        public int CommentId { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public decimal Score { get; set; }
        public string Comments { get; set; }
        public bool IsPurchased { get; set; } //satın alındı mı
        public bool ApprovalStatus { get; set; } //yorum onaylandı mı 
        public string? fotograf { get; set; }

    }
}
