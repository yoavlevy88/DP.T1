using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System.Net.Mail;
using System.Net;

namespace C18_Ex01
{
    internal class AppUtils
    {
        private FacebookFriendsUtils m_fbFriendsUtils;
        private string m_sendingMailAddress;
        private string m_mailPassword;

        internal AppUtils()
        {
            this.m_fbFriendsUtils = new FacebookFriendsUtils();
            this.m_sendingMailAddress = "design.patterns18c@gmail.com";
            this.m_mailPassword = "design.patternspp2018";

        }

        public FacebookFriendsUtils fbFriendsUtils
        {
            get
            {
                return this.m_fbFriendsUtils;
            }
        }

        internal void sendMatchMessage(string userMail, string message, string subject)
        {
            MailMessage matchMail = new MailMessage(this.m_sendingMailAddress, userMail);
            SmtpClient client = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(this.m_sendingMailAddress, this.m_mailPassword),
                Timeout = 20000
            };
            matchMail.Subject = subject;
            matchMail.Body = message;

            try
            {
                client.Send(matchMail);
            }
            catch(Exception mailException)
            {
                throw (mailException);
            }
        }
    }
}
