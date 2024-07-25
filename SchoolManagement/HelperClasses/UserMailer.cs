using Mvc.Mailer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace SchoolManagement.HelperClasses
{
    public class UserMailer:MailerBase
    {
        public UserMailer()
        {
            MasterName = null;
        }

        public static void SendEmailByMaster(string to, string subject, string body, string from = "", string password = "", string attachmentUrl = "", bool isBodyHtml = true, int sendEmailBy = 0)
        {
            SendEmailByMaster(new List<string> { to }, subject, body, from, password, new List<string> { attachmentUrl }, isBodyHtml, sendEmailBy: sendEmailBy);
        }

        public static void SendEmailByMaster(List<string> to, string subject, string body, string from = "", string password = "", List<string> attachmentUrls = null, bool isBodyHtml = true, List<string> cc = null, int sendEmailBy = 0)
        {
            SendEmailByGmail(to, subject, body, from, password, attachmentUrls, isBodyHtml);
            //if (sendEmailBy == (int)Globals.SendEmailByOption.WebConfigSetting)
            //{
            //    sendEmailBy = int.Parse(ConfigurationManager.AppSettings["SendEmailBy"]);
            //}

            //switch (sendEmailBy)
            //{
            //    case (int)Globals.SendEmailByOption.ByAWS:
            //        {
            //            SendEmailByAWS(to, subject, body, from, password, attachmentUrls, isBodyHtml);
            //        }
            //        break;
            //    case (int)Globals.SendEmailByOption.ByMailGun:
            //        {
            //            SendEmailByMailGun(to, subject, body, from, password, attachmentUrls, isBodyHtml);
            //        }
            //        break;
            //    case (int)Globals.SendEmailByOption.ByMailSinghtek:
            //        {
            //            SendEmail(to, subject, body, from, password, attachmentUrls, isBodyHtml);
            //        }
            //        break;
            //    case (int)Globals.SendEmailByOption.SendMailByGmailAccount:
            //        {
            //            SendEmailByGmail(to, subject, body, from, password, attachmentUrls, isBodyHtml);
            //        }
            //        break;
            //    default:
            //        SendEmailByAWS(to, subject, body, from, password, attachmentUrls, isBodyHtml);
            //        break;
            //}
        }

        private static void SendEmailByGmail(List<string> to, string subject, string body, string from = "", string password = "", List<string> attachmentUrls = null, bool isBodyHtml = true, List<string> cc = null)
        {
            try
            {
                if (string.IsNullOrEmpty(from))
                    from = "amansharma271996@gmail.com";
                if (string.IsNullOrEmpty(password))
                    password = "mtzcaraeakkcyjkt";

                var msg = new MailMessage
                {
                    From = new MailAddress(from),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = isBodyHtml
                };
                foreach (var item in to)
                {
                    msg.To.Add(new MailAddress(item));
                }

                if (cc != null) cc.ForEach(x => { msg.CC.Add(x); });

                if (attachmentUrls != null)
                {
                    foreach (var attachmentUrl in attachmentUrls)
                    {
                        if (!string.IsNullOrEmpty(attachmentUrl))
                        {
                            var attachment = new Attachment(attachmentUrl);
                            msg.Attachments.Add(attachment);
                        }
                    }
                }
                // your remote SMTP server IP.
                using (var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    //UseDefaultCredentials = false,
                    Credentials = new System.Net.NetworkCredential(from, password),
                    EnableSsl = true
                })
                {
                    smtp.Send(msg);
                }
            }
            catch (Exception ex)
            {
                throw;
                // Throw exception or Log exception and error emails.
            }
        }


    }
}
