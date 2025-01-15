using AutoMapper;
using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using MimeKit;  // MimeMessage sınıfı için
using MailKit.Net.Smtp;  // SmtpClient sınıfı için
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class EmailManager : IEmailService
    {
        private readonly IEmailDal _emailDal;
        private readonly IMapper _mapper;


        public EmailManager(IEmailDal emailDal, IMapper mapper)
        {
            _emailDal = emailDal;
            _mapper = mapper;
        }

        public   IResult SendEmailAsync(SendEmailDto sendEmailDto)
        {
            // Map DTO to Entity
            var emailEntity = _mapper.Map<Email>(sendEmailDto);
            emailEntity.SentDate = DateTime.UtcNow;

            // Send Email using a real email sending service
            var emailResult =  SendEmail(sendEmailDto);
            if (!emailResult.IsCompletedSuccessfully)
            {
                return new ErrorResult("");
            }

            // Save Email to Database
            _emailDal.Add(emailEntity);

            return new SuccessResult("Email sent successfully.");
        }

        private async Task<IResult> SendEmail(SendEmailDto sendEmailDto)
        {
            try
            {
                // Here you can implement the real email sending logic using a library or API.
                // For example, using SMTP or any other service.

                var emailMessage = new MimeMessage();
                emailMessage.From.Add(new MailboxAddress(sendEmailDto.SenderName, sendEmailDto.From));
                emailMessage.To.Add(new MailboxAddress(sendEmailDto.ReceiverName, sendEmailDto.To));
                emailMessage.Subject = sendEmailDto.Subject;
                emailMessage.Body = new TextPart("plain")
                {
                    Text = sendEmailDto.Body
                };

                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.Connect("smtp.yourmailserver.com", 587, false); // Example SMTP configuration
                    client.Authenticate("busragns1999@hotmail.com", "Genbencildir1.");   // Your SMTP credentials
                    await client.SendAsync(emailMessage);
                    client.Disconnect(true);
                }

                return new SuccessResult("Email sent successfully.");
            }
            catch (Exception ex)
            {
                return new ErrorResult($"Error sending email: {ex.Message}");
            }
        }

        public IDataResult<List<EmailDto>> GetAllEmailsAsync()
        {
            var emails = _emailDal.GetAll();
            var emailDtos = _mapper.Map<List<EmailDto>>(emails);

            return new SuccessDataResult<List<EmailDto>>(emailDtos, "");
        }

        public IDataResult<EmailDto> GetEmailByIdAsync(int emailId)
        {
            var email = _emailDal.Get(e => e.EmailId == emailId);
            if (email == null)
            {
                return new ErrorDataResult<EmailDto>("1");
            }

            var emailDto = _mapper.Map<EmailDto>(email);
            return new SuccessDataResult<EmailDto>(emailDto, "");
        }

        #region Private Helper Methods

        private IResult Success(string message)
        {
            return new SuccessResult(message);
        }

        private IDataResult<T> Success<T>(T data, string message)
        {
            return new SuccessDataResult<T>(data, message);
        }

        private IResult Error(string message)
        {
            return new ErrorResult(message);
        }

        private IDataResult<T> Error<T>(string message)
        {
            return new ErrorDataResult<T>(message);
        }

        #endregion
    }
}

