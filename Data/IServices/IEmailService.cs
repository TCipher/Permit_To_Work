using PermitToWorkSystem.Utility;
using System.Net.Mail;

namespace PermitToWorkSystem.Data.Service
{
   
        public interface IEmailService
        {
            Task SendEmailAsync(EmailMessage message);
        }
  
}
