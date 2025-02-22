using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Resume:IEntity
    {
        public int ResumeId{ get; set; }
        public int UserId { get; set; } // Kullanıcı ID'si
        public string FullName { get; set; } // Ad Soyad
        public string Email { get; set; } // E-posta
        public string Phone { get; set; } // Telefon
        public string Summary { get; set; } // Kısa tanıtım
        public string FileUrl { get; set; } // Kullanıcının yüklediği CV dosyasının URL’si
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
