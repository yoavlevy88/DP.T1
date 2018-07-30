namespace C18_Ex01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Mail;
    using System.Text;
    using Facebook;
    using FacebookWrapper;
    using FacebookWrapper.ObjectModel;
    
    internal class MatchUtils
    {
        private string m_sendingMailAddress;
        private string m_mailPassword;

        internal MatchUtils()
        {
            this.m_sendingMailAddress = "design.patterns18c@gmail.com";
            this.m_mailPassword = "design.patternspp2018";
        }

        private void sendMatchMessage(string i_userMail, string i_message, string i_subject)
        {
            MailMessage matchMail = new MailMessage(this.m_sendingMailAddress, i_userMail);
            SmtpClient client = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(this.m_sendingMailAddress, this.m_mailPassword),
                Timeout = 20000
            };
            matchMail.Subject = i_subject;
            matchMail.Body = i_message;

            try
            {
                client.Send(matchMail);
            }
            catch(Exception mailException)
            {
                throw mailException;
            }
        }

        internal void generateMatchMessages(User i_loggedInUser, User[] i_friendsToMatch, string i_personalMessage)
        {
            string messageBody = string.Empty;
            int index = 1;
            string messageSubject = "You have a match!";

            foreach (User friend in i_friendsToMatch)
            {
                messageBody += string.Format(
                    @"Hi {0}!
{1} thinks that you and {2} would be a great match!",
                    friend.Name,
                    i_loggedInUser.Name,
                    i_friendsToMatch[index].Name);

                if (!string.IsNullOrEmpty(i_personalMessage))
                {
                    messageBody += string.Format(
                        @" Here are a few of the reasons why:
{0}",
                        i_personalMessage);
                }

                messageBody += string.Format(
                    @"
Look them out on Facebook, and see if {0} is right about you two!",
                    i_loggedInUser);
                index = 0;
                sendMatchMessage(friend.Email, messageBody, messageSubject);
                messageBody = string.Empty;
            }
        }
    }
}
