using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tester
{
    internal class SMTP_Mail
    {
        public void SendMail(string smtpServer, string port, string userName, string password, string mailSender,
            string senderName, string mailSubject, string mailBody, string mailReciver, bool useSsl = true, string attachmentName = "")
        {
            var client = new SmtpClient(smtpServer, Convert.ToInt32(port))
            {
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(userName, password),
                EnableSsl = useSsl
            };
            var message = new MailMessage();
            message.From = new MailAddress(mailSender, senderName);
            message.Subject = mailSubject;
            message.Body = mailBody;
            if (mailBody.Contains("<html>") || mailBody.Contains("<tr") || mailBody.Contains("<table"))
                message.IsBodyHtml = true;
            message.To.Add(mailReciver);
            if (!string.IsNullOrEmpty(attachmentName))
            {
                string[] attachmentArr = attachmentName.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var attach in attachmentArr)
                {
                    var data = new Attachment(attach, MediaTypeNames.Application.Octet);
                    ContentDisposition disposition = data.ContentDisposition;
                    disposition.CreationDate = File.GetCreationTime(attach);
                    disposition.ModificationDate = File.GetLastWriteTime(attach);
                    disposition.ReadDate = File.GetLastAccessTime(attach);
                    message.Attachments.Add(data);
                }
            }
            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                string err = DateTime.Now.ToString() + " : " + ex + "\r\n";
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
