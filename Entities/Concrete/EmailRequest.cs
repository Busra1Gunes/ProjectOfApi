using Core.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class EmailRequest:IEntity
    {
        public string From { get; set; } // Gönderen e-posta adresi
        public string To { get; set; }   // Alıcı e-posta adresi
        public string ReceiverName { get; set; }   // Alıcı
        public string SenderName { get; set; }
        public string Subject { get; set; } // E-posta konusu
        public string Body { get; set; }    // E-posta içeriği
        public List<IFormFile> Attachments { get; set; } // Eklentiler
    }
}
