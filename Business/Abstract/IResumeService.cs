using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IResumeService
    {
        IDataResult<List<ResumeAddDto>> GetAll(); 
        IDataResult<ResumeAddDto> GetById(int resumeId);
        IResult Add(ResumeAddDto resume, string url, int kullanici_id);
        IResult Update(Resume resume);
    }
}
