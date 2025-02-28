using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class SendEmailDto
    {
        public string From { get; set; } // Gönderen
        public string To { get; set; }   // Alıcı
        public string ReceiverName { get; set; }   // Alıcı
        public string SenderName { get; set; }
        public string Subject { get; set; } // Konu
        public string Body { get; set; } // E-posta içeriği
        public List<string> Attachments { get; set; } // Ek dosyalar
    }
}
