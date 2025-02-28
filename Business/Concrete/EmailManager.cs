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
using SmtpClient = System.Net.Mail.SmtpClient;
using System.Net;

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


            string smtpServer = "smtp.gmail.com";
            int smtpPort = 587;
            string smtpUser = "";
            string smtpPass = "";
            MailMessage mail = new MailMessage();
            SmtpClient smtpClient = new SmtpClient(smtpServer);

            mail.From = new MailAddress(smtpUser);
            mail.To.Add(sendEmailDto.To);
            mail.Subject = sendEmailDto.Subject; 
            mail.Body = sendEmailDto.Body;
            smtpClient.Port = smtpPort;
            smtpClient.Credentials = new NetworkCredential(smtpUser, smtpPass);
            smtpClient.EnableSsl = true;
            smtpClient.Send(mail); var 
            email = _mapper.Map<Email>(sendEmailDto);

            email.From = smtpUser;
            email.SentDate = DateTime.Now;
            email.AttachmentPaths = "";
            email.SenderName = "";
            email.ReceiverName = "";    
            _emailDal.Add(email);
            return new SuccessResult(Messages.MailSended);

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

