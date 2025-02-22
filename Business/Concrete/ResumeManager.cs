using AutoMapper;
using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ResumeManager:IResumeService
    {
        IResumeDal _resumeDal;
        IMapper _mapper;
        public ResumeManager(IResumeDal resumeDal,IMapper mapper)
        {
            _resumeDal = resumeDal;
            _mapper = mapper;
        }

        public IResult Add(ResumeAddDto resume, string url, int kullanici_id)
        {
            // Fotoğraf yolu kaydetme işlemi
            string? sqlResimYolu = null;

            if (resume.FileUrl != null)
            {
                // Fotoğraf uzantısını kontrol ediyoruz
                var uzanti = Path.GetExtension(resume.FileUrl.FileName).ToLower();
                var allowedExtensions = new[] { ".jpg", ".jpeg", ".png",".docx",".pdf",".xlsx" };

                if (!allowedExtensions.Contains(uzanti))
                {
                    return new ErrorResult("Geçersiz dosya formatı. Sadece JPG, PNG,PDF,DOCX,XLSX kabul edilmektedir.");
                }

                // Klasör var mı kontrol ediyoruz, yoksa oluşturuyoruz
                var klasorYolu = "wwwroot/ResumeDocumets";
                if (!Directory.Exists(klasorYolu))
                {
                    Directory.CreateDirectory(klasorYolu);
                }

                // Benzersiz dosya adı oluşturuluyor
                var tarihSaatDakikaSaniyeSalise = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                var resimYolu = Path.Combine(klasorYolu, $"{tarihSaatDakikaSaniyeSalise}{uzanti}");
                sqlResimYolu = $"{url}ResumeDocumets/{tarihSaatDakikaSaniyeSalise}{uzanti}";

                try
                {
                    using (var stream = new FileStream(resimYolu, FileMode.Create))
                    {
                        resume.FileUrl.CopyTo(stream);
                    }
                }
                catch (Exception ex)
                {
                    return new ErrorResult($"Dosya kaydedilirken bir hata oluştu: {ex.Message}");
                }
            }

            Resume resume1 = _mapper.Map<Resume>(resume);
            resume1.FileUrl = sqlResimYolu;
            resume1.UserId = kullanici_id;

            _resumeDal.Add(resume1);

            return new SuccessResult(Messages.ResumeAddes);
        }

        public IDataResult<List<ResumeAddDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<ResumeAddDto> GetById(int resumeId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Resume resume)
        {
            throw new NotImplementedException();
        }
    }
}
