using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
//using DomainClasses;
using System.IO;

namespace loading_screen
{
    /// <summary>
    /// Class for Email Methods
    /// </summary>
    public static class EmailHelper
    {
        public static string SendMessage1(string strServer, int nPort, string strUsername, string strPwd, string strTo, string strFrom, string strTitle, string strBody)
        {
            MailAddress from = new MailAddress(strFrom);
            MailAddress to = new MailAddress(strTo);
            MailMessage message = new MailMessage(from, to);

            //System.Net.Mail.Attachment attachment = new System.Net.Mail.Attachment(Environment.CurrentDirectory + "/file.pdf");

            var smtp = new SmtpClient
            {
                Host = strServer,
                Port = nPort,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(strUsername, strPwd)
            };

            message.Subject = strTitle;
            message.Body = strBody;

            SmtpClient client = smtp;

            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in SendMessage(): {0}",
                            ex.ToString());
                return ex.Message;
            }
            return "ok";
        }
    }
}
