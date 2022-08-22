using System;
using System.Net.Mail;

namespace SingleResponsabilityPrinciple.ImplementedPrincipleExemple
{
    class Order
    {
        public long Amount { get; set; }
        public DateTime Date { get; set; }
        private ILogger _infoLogger;
        private SendEmail _sendEmail;

        public Order(ILogger infoLogger, SendEmail sendEmail)
        {
            _infoLogger = infoLogger;
            _sendEmail = sendEmail;
        }

        public void IncludeOrder()
        {
            try
            {
                _infoLogger.Info($"Include a order");
                _sendEmail.EmailFrom = "emailfrom@xyz.com";
                _sendEmail.EmailTo = "mayardesoliveira@xyz.com";
                _sendEmail.EmailSubject = "emailto@xyz.com";
                _sendEmail.EmailBody = "message";
                _sendEmail.Send();
            }
            catch (Exception ex)
            {
                _infoLogger.Info(@"c:\data\Errorlog.txt", ex.ToString());
            }
        }

        public void DeleteOrder()
        {
            try
            {
            }
            catch (Exception ex)
            {
                _infoLogger.Info(@"c:\data\Errorlog.txt", ex.ToString());
            }
        }
        public void SendEmailOrder(MailMessage mailMessage)
        {

            try
            {
            }
            catch (Exception ex)
            {
                _infoLogger.Info(@"c:\data\Errorlog.txt", ex.ToString());
            }
        }
    }
}
