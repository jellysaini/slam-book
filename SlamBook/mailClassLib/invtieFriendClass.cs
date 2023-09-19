using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Net;
using System.Net.Mail;

namespace mailClassLib
{
    public class invtieFriendClass
    {
        private string mailMsg;
        private string repMsg;
        public bool sendInvitationtoFriend(string to,Int32 userId,string name)
        {          
            try
            {
                
                mailMsg = "<html><head></head><body><table width=" + "70%" +
                    " bgcolor=" + "#CEE3F6" + "><tr align=" + "left" +
                    "><td><b>Hello...</b><br />Yor are invited to join MySlamBook.com by ##. To join Click on the link provided.<br /><br /></td></tr><tr align=" +
                    "left" + "><td><b>Click Here:--</b>" +
                    "<a href=" + "http://localhost:1289/LogIn/Pages/SignUp.aspx?qvar=$" + ">http://localhost:1289/LogIn/Pages/SignUp.aspx?qvar=$</a>" +
                    "</td></tr></table></body></html>";
                repMsg=mailMsg.Replace("$",userId.ToString());
                repMsg = repMsg.Replace("##", name);
                NetworkCredential loginInfo = new NetworkCredential("yours.slambook@gmail.com", "jatin1981");
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("yours.slambook@gmail.com");
                msg.To.Add(new MailAddress(to));
                msg.Subject = "This is a test Email subject";
                msg.Body = string.Format(repMsg);
                msg.IsBodyHtml = true;
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = loginInfo;
                client.Send(msg);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool sendMailtoConfirm(string to, Int32 userId)
        {
            try
            {
                mailMsg="<html><head></head><body><table width=" + "70%" +
                    " bgcolor=" + "#CEE3F6" + "><tr align=" + "left" +
                    "><td><b>Hello...</b><br />Yor are about to confirm your MySlamBook.com account by,"+
                    " just Click on the link provided.<br /><br /></td></tr><tr align=" +
                    "left" + "><td><b>Click Here --- <a href=" + "http://localhost:1289/LogIn/Pages/confirmMail.aspx?qvar=$" +
                    ">http://localhost:1289/LogIn/Pages/confirmMail.aspx?qvar=$</a></b></td></tr></table></body></html>";
                repMsg = mailMsg.Replace("$", userId.ToString());
                NetworkCredential loginInfo = new NetworkCredential("yours.slambook@gmail.com", "jatin1981");
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("yours.slambook@gmail.com");
                msg.To.Add(new MailAddress(to));
                msg.Subject = "This is a test Email subject";
                msg.Body = string.Format(repMsg);
                msg.IsBodyHtml = true;
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = loginInfo;
                client.Send(msg);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool sendMailtoForgetUser(string to, string password)
        {
            try
            {
                mailMsg = "<html><head></head><body><table width=" + "70%" +
                    " bgcolor=" + "#CEE3F6" + "><tr align=" + "left" +
                    "><td><b>Hello...</b><br />Your Psaaword is:--" +
                    " <br /><br /></td></tr><tr align=" +
                    "left" + "><td><b>"+
                    ">$</a></b></td></tr></table></body></html>";
                repMsg = mailMsg.Replace("$", password);
                NetworkCredential loginInfo = new NetworkCredential("yours.slambook@gmail.com", "jatin1981");
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("yours.slambook@gmail.com");
                msg.To.Add(new MailAddress(to));
                msg.Subject = "This is a test Email subject";
                msg.Body = string.Format(repMsg);
                msg.IsBodyHtml = true;
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = loginInfo;
                client.Send(msg);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool sendFeedBackMail(string from, string name, string address, string rank, string suggestion)
        {
            try
            {
                mailMsg="<html><head><title>Feed Back mail</title></head><body bgcolor="+
                "gray"+"><table width="+"100%"+"><tr><td><h3>New Feed Back Mail for You from :- #1<br />"+
                "Address is :- #2<br />Email Id :- #3<br />Rank Website as :- #4<br />Sugession for you :- #5<br />"+
                "</h3></td></tr></table></body></html>";
                repMsg = mailMsg.Replace("#1", name);
                repMsg = repMsg.Replace("#2", address);
                repMsg = repMsg.Replace("#3", from);
                repMsg = repMsg.Replace("#4", rank);
                repMsg = repMsg.Replace("#5", suggestion);
                NetworkCredential loginInfo = new NetworkCredential("yours.slambook@gmail.com", "jatin1981");
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress(from);
                msg.To.Add(new MailAddress("yours.slambook@gmail.com"));
                msg.Subject = "Feed Back mail";
                msg.Body = string.Format(repMsg);
                msg.IsBodyHtml = true;
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = loginInfo;
                client.Send(msg);
                return true;
            }
            catch (Exception)
            {
                return false;
            }    
        }
        public bool sendThanxForFeedback(string to)
        {
            try
            {
                mailMsg = "<html><head><title>Thanx for Feed Back mail</title></head><body bgcolor=" +
                "gray" + "><table width=" + "100%" + "><tr><td><h3>Thank You for showing intrest in our Website<br>" +
                "And Thanx for your feed back<br> from:- Adminstrative Team</h3></td></tr></table></body></html>";               
                NetworkCredential loginInfo = new NetworkCredential("yours.slambook@gmail.com", "jatin1981");
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("yours.slambook@gmail.com");
                msg.To.Add(new MailAddress(to));
                msg.Subject = "Thanx for Feed Back mail";
                msg.Body = string.Format(mailMsg);
                msg.IsBodyHtml = true;
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = loginInfo;
                client.Send(msg);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
