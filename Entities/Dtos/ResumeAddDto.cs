using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class ResumeAddDto
    {
        public string FullName { get; set; } // Ad Soyad
        public string Email { get; set; } // E-posta
        public string Phone { get; set; } // Telefon
        public string Summary { get; set; } // Kısa tanıtım
        public IFormFile? FileUrl { get; set; } // Kullanıcının yüklediği CV dosyasının URL’si
    }
}
