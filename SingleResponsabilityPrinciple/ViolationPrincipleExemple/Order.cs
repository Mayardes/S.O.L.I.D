using System;
using System.IO;
using System.Net.Mail;

namespace SingleResponsabilityPrinciple.ViolationPrincipleExemple
{
    class Order
    {
        public long Amount { get; set; }
        public DateTime Date { get; set; }

        public void IncludeOrder()
        {
            try
            {
                MailMessage mailMessage = new MailMessage("EmailFrom", "EmailTo", "EmailSubject", "EmailBody");
                SendEmailOrder(mailMessage);
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"c:\data\Errorlog.txt", ex.ToString());
            }
        }

        public void DeleteOrder()
        {
            try
            {
                //Code for delete order
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"c:\data\Errorlog.txt", ex.ToString());
            }
        }
        public void SendEmailOrder(MailMessage mailMessage)
        {

            try
            {
                //Code for send email
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"c:\data\Errorlog.txt", ex.ToString());
            }
        }
    }
}
