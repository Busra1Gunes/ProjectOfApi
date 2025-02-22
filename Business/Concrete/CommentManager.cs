using AutoMapper;
using Business.Abstract;
using Business.Constans;
using Core.Utilities.Business;
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
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;      //Bir manager içinde kendi dal'ı hariç dal enjeksiyonu yapılamaz!!!
        readonly IMapper _mapper;
        public CommentManager(ICommentDal commentDal, IMapper mapper)
        {
            _commentDal = commentDal;
            _mapper = mapper;
        }

        public IResult Add(CommentAddDto comment, string url, int kullanici_id)
        {
            // Fotoğraf yolu kaydetme işlemi
            string? sqlResimYolu = null;

            if (comment.fotograf != null)
            {
                // Fotoğraf uzantısını kontrol ediyoruz
                var uzanti = Path.GetExtension(comment.fotograf.FileName).ToLower();
                var allowedExtensions = new[] { ".jpg", ".jpeg", ".png" };

                if (!allowedExtensions.Contains(uzanti))
                {
                    return new ErrorResult("Geçersiz dosya formatı. Sadece JPG ve PNG kabul edilmektedir.");
                }

                // Klasör var mı kontrol ediyoruz, yoksa oluşturuyoruz
                var klasorYolu = "wwwroot/CommentFoto";
                if (!Directory.Exists(klasorYolu))
                {
                    Directory.CreateDirectory(klasorYolu);
                }

                // Benzersiz dosya adı oluşturuluyor
                var tarihSaatDakikaSaniyeSalise = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                var resimYolu = Path.Combine(klasorYolu, $"{tarihSaatDakikaSaniyeSalise}{uzanti}");
                sqlResimYolu = $"{url}CommentFoto/{tarihSaatDakikaSaniyeSalise}{uzanti}";

                try
                {
                    using (var stream = new FileStream(resimYolu, FileMode.Create))
                    {
                        comment.fotograf.CopyTo(stream);
                    }
                }
                catch (Exception ex)
                {
                    return new ErrorResult($"Fotoğraf kaydedilirken bir hata oluştu: {ex.Message}");
                }
            }

            Comment comment1 = _mapper.Map<Comment>(comment);
            comment1.fotograf = sqlResimYolu;
            comment1.UserId = kullanici_id;

            _commentDal.Add(comment1);

            return new SuccessResult(Messages.CommentAddes);
        }

        public IDataResult<List<Comment>> GetAll()
        {
            List<Comment> comments = _commentDal.GetAll();
            if( comments.Count>= 0 )
                return new SuccessDataResult<List<Comment>>( comments );  
            return new ErrorDataResult<List<Comment>>( comments );
        }

        public IDataResult<List<Comment>> GetAllByCommenttId(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Comment> GetById(int commentId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Comment>> GetByUnitScore(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CommentAddDto>> GetCommentDetails()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}
