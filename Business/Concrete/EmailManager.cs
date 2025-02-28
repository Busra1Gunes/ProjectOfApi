using AutoMapper;
using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using DataAccess.Concrete.EntityFramework;

namespace Business.Concrete
{
    public class EmailManager : IEmailService
    {
        IEmailDal _emailDal;
        IMapper _mapper;
        public EmailManager(IEmailDal emailDal, IMapper mapper)
        {
            _emailDal = emailDal;
            _mapper = mapper;

        }
        public IResult CreateAsync(EmailRequest emailRequest)
        {
            throw new NotImplementedException();
        }

        public IResult SendEmailAsync(EmailRequest emailRequest)
        {

            string smtpServer = "smtp.gmail.com";
            int smtpPort = 587;
            string smtpUser = "";
            string smtpPass = "";
            MailMessage mail = new MailMessage();
            SmtpClient smtpClient = new SmtpClient(smtpServer);

            mail.From = new MailAddress(smtpUser);
            mail.To.Add(emailRequest.To);
            mail.Subject = emailRequest.Subject; 
            mail.Body = emailRequest.Body;
            smtpClient.Port = smtpPort;
            smtpClient.Credentials = new NetworkCredential(smtpUser, smtpPass);
            smtpClient.EnableSsl = true;
            smtpClient.Send(mail); var 
            email = _mapper.Map<Email>(emailRequest);
            email.From = smtpUser;
            email.SentDate = DateTime.Now;
            email.AttachmentPaths = "";
            email.SenderName = "";
            email.ReceiverName = "";    
            _emailDal.Add(email);
            return new SuccessResult(Messages.MailSended);
           

        }


    }
}

