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
    public interface IEmailService
    {
        IResult SendEmailAsync(SendEmailDto sendEmailDto);
        IDataResult<List<EmailDto>> GetAllEmailsAsync();
        IDataResult<EmailDto> GetEmailByIdAsync(int emailId);
    }
}
