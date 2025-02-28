using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Seeds
{
	public class CategorySeed : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			builder.HasData(
				  
				// Ana Kategoriler
				new Category { CategoryId = 1, Name = "Elektronik", ParentCategoryId = null, IsActive = true, CreatedAt = DateTime.UtcNow },
				new Category { CategoryId = 2, Name = "Ev ve Yaşam", ParentCategoryId = null, IsActive = true, CreatedAt = DateTime.UtcNow },
				new Category { CategoryId = 3, Name = "Moda", ParentCategoryId = null, IsActive = true, CreatedAt = DateTime.UtcNow },
				new Category { CategoryId = 4, Name = "Spor ve Outdoor", ParentCategoryId = null, IsActive = true, CreatedAt = DateTime.UtcNow },
				new Category { CategoryId = 5, Name = "Kitap, Müzik, Film", ParentCategoryId = null, IsActive = true, CreatedAt = DateTime.UtcNow },
				new Category { CategoryId = 6, Name = "Anne ve Bebek", ParentCategoryId = null, IsActive = true, CreatedAt = DateTime.UtcNow },
				new Category { CategoryId = 7, Name = "Sağlık ve Kişisel Bakım", ParentCategoryId = null, IsActive = true, CreatedAt = DateTime.UtcNow },
				new Category { CategoryId = 8, Name = "Oyun ve Hobi", ParentCategoryId = null, IsActive = true, CreatedAt = DateTime.UtcNow },
				new Category { CategoryId = 9, Name = "Otomobil ve Motosiklet", ParentCategoryId = null, IsActive = true, CreatedAt = DateTime.UtcNow },
				new Category { CategoryId = 10, Name = "Ofis ve Kırtasiye", ParentCategoryId = null, IsActive = true, CreatedAt = DateTime.UtcNow },

				// Elektronik Alt Kategorileri
				new Category { CategoryId = 11, Name = "Telefonlar", ParentCategoryId = 1, IsActive = true, CreatedAt = DateTime.UtcNow },
				new Category { CategoryId = 12, Name = "Bilgisayarlar", ParentCategoryId = 1, IsActive = true, CreatedAt = DateTime.UtcNow },
				new Category { CategoryId = 13, Name = "Televizyon ve Ses Sistemleri", ParentCategoryId = 1, IsActive = true, CreatedAt = DateTime.UtcNow },
				new Category { CategoryId = 14, Name = "Aksesuarlar", ParentCategoryId = 1, IsActive = true, CreatedAt = DateTime.UtcNow },
				new Category { CategoryId = 15, Name = "Fotoğraf ve Kamera", ParentCategoryId = 1, IsActive = true, CreatedAt = DateTime.UtcNow },
				new Category { CategoryId = 16, Name = "Akıllı Ev Ürünleri", ParentCategoryId = 1, IsActive = true, CreatedAt = DateTime.UtcNow },
				new Category { CategoryId = 17, Name = "Tabletler", ParentCategoryId = 1, IsActive = true, CreatedAt = DateTime.UtcNow },

				// Ev ve Yaşam Alt Kategorileri
				new Category { CategoryId = 18, Name = "Mobilya", ParentCategoryId = 2, IsActive = true, CreatedAt = DateTime.UtcNow },
				new Category { CategoryId = 19, Name = "Dekorasyon", ParentCategoryId = 2, IsActive = true, CreatedAt = DateTime.UtcNow },
				new Category { CategoryId = 20, Name = "Mutfak Gereçleri", ParentCategoryId = 2, IsActive = true, CreatedAt = DateTime.UtcNow },
				new Category { CategoryId = 21, Name = "Temizlik Ürünleri", ParentCategoryId = 2, IsActive = true, CreatedAt = DateTime.UtcNow },
				new Category { CategoryId = 22, Name = "Aydınlatma", ParentCategoryId = 2, IsActive = true, CreatedAt = DateTime.UtcNow },
				new Category { CategoryId = 23, Name = "Beyaz Eşya", ParentCategoryId = 2, IsActive = true, CreatedAt = DateTime.UtcNow },
				new Category { CategoryId = 24, Name = "Halı ve Tekstil", ParentCategoryId = 2, IsActive = true, CreatedAt = DateTime.UtcNow },
				new Category { CategoryId = 25, Name = "Bahçe Ürünleri", ParentCategoryId = 2, IsActive = true, CreatedAt = DateTime.UtcNow },

				// Moda Alt Kategorileri
				new Category { CategoryId = 26, Name = "Kadın Giyim", ParentCategoryId = 3, IsActive = true, CreatedAt = DateTime.UtcNow },
				new Category { CategoryId = 27, Name = "Erkek Giyim", ParentCategoryId = 3, IsActive = true, CreatedAt = DateTime.UtcNow },
				new Category { CategoryId = 28, Name = "Ayakkabı ve Çanta", ParentCategoryId = 3, IsActive = true, CreatedAt = DateTime.UtcNow },
				new Category { CategoryId = 29, Name = "Aksesuarlar", ParentCategoryId = 3, IsActive = true, CreatedAt = DateTime.UtcNow },
				new Category { CategoryId = 30, Name = "İç Giyim", ParentCategoryId = 3, IsActive = true, CreatedAt = DateTime.UtcNow },

				// Spor ve Outdoor Alt Kategorileri
				new Category { CategoryId = 31, Name = "Koşu ve Yürüyüş", ParentCategoryId = 4, IsActive = true, CreatedAt = DateTime.UtcNow },
				new Category { CategoryId = 32, Name = "Fitness", ParentCategoryId = 4, IsActive = true, CreatedAt = DateTime.UtcNow },
				new Category { CategoryId = 33, Name = "Outdoor", ParentCategoryId = 4, IsActive = true, CreatedAt = DateTime.UtcNow },
				new Category { CategoryId = 34, Name = "Yüzme", ParentCategoryId = 4, IsActive = true, CreatedAt = DateTime.UtcNow },
				new Category { CategoryId = 35, Name = "Bicycles", ParentCategoryId = 4, IsActive = true, CreatedAt = DateTime.UtcNow },

				// Kitap, Müzik, Film Alt Kategorileri
				new Category { CategoryId = 36, Name = "Kitaplar", ParentCategoryId = 5, IsActive = true, CreatedAt = DateTime.UtcNow },
				new Category { CategoryId = 37, Name = "Müzik CD'leri", ParentCategoryId = 5, IsActive = true, CreatedAt = DateTime.UtcNow },
				new Category { CategoryId = 38, Name = "Film DVD'leri", ParentCategoryId = 5, IsActive = true, CreatedAt = DateTime.UtcNow },

				// Anne ve Bebek Alt Kategorileri
				new Category { CategoryId = 39, Name = "Bebek Giyim", ParentCategoryId = 6, IsActive = true, CreatedAt = DateTime.UtcNow },
				new Category { CategoryId = 40, Name = "Bebek Oyuncakları", ParentCategoryId = 6, IsActive = true, CreatedAt = DateTime.UtcNow },
				new Category { CategoryId = 41, Name = "Bebek Bakım Ürünleri", ParentCategoryId = 6, IsActive = true, CreatedAt = DateTime.UtcNow },

				// Sağlık ve Kişisel Bakım Alt Kategorileri
				new Category { CategoryId = 42, Name = "Cilt Bakımı", ParentCategoryId = 7, IsActive = true, CreatedAt = DateTime.UtcNow },
				new Category { CategoryId = 43, Name = "Saç Bakımı", ParentCategoryId = 7, IsActive = true, CreatedAt = DateTime.UtcNow },
				new Category { CategoryId = 44, Name = "Parfümler", ParentCategoryId = 7, IsActive = true, CreatedAt = DateTime.UtcNow },

				// Oyun ve Hobi Alt Kategorileri
				new Category { CategoryId = 45, Name = "Video Oyunları", ParentCategoryId = 8, IsActive = true, CreatedAt = DateTime.UtcNow },
				new Category { CategoryId = 46, Name = "Masa Oyunları", ParentCategoryId = 8, IsActive = true, CreatedAt = DateTime.UtcNow },

				// Otomobil ve Motosiklet Alt Kategorileri
				new Category { CategoryId = 47, Name = "Otomobil Yedek Parçaları", ParentCategoryId = 9, IsActive = true, CreatedAt = DateTime.UtcNow },
				new Category { CategoryId = 48, Name = "Motosiklet Aksesuarları", ParentCategoryId = 9, IsActive = true, CreatedAt = DateTime.UtcNow },

				// Ofis ve Kırtasiye Alt Kategorileri
				new Category { CategoryId = 49, Name = "Ofis Mobilyaları", ParentCategoryId = 10, IsActive = true, CreatedAt = DateTime.UtcNow },
				new Category { CategoryId = 50, Name = "Kırtasiye Ürünleri", ParentCategoryId = 10, IsActive = true, CreatedAt = DateTime.UtcNow }
			);
		}
	}
}
