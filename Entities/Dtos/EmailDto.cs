using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class EmailDto
    {
        public int EmailId { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string ReceiverName { get; set; }   // Alıcı
        public string SenderName { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime SentDate { get; set; }
        public List<string> Attachments { get; set; }
    }
}
