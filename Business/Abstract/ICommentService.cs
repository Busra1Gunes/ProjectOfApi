using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dto;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Dtos;

namespace Business.Abstract
{
    public interface ICommentService
    {
        IDataResult<List<Comment>> GetAll();

        IDataResult<List<Comment>> GetAllByCommenttId(int id);

        IDataResult<List<Comment>> GetByUnitScore(decimal min, decimal max);

        IDataResult<List<CommentAddDto>> GetCommentDetails();

        IDataResult<Comment> GetById(int commentId);

        IResult Add(CommentAddDto comment, string url,int kullanici_id);
        IResult Update(Comment  comment);
    }
}
