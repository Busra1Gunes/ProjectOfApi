using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Email : IEntity
    {
        public int EmailId { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string? ReceiverName { get; set; }   // Alıcı
        public string? SenderName { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime SentDate { get; set; }
        public string? AttachmentPaths { get; set; } // Dosya yollarını virgülle ayırarak saklayabilirsiniz
    }
}
