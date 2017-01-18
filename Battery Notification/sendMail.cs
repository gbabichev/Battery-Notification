using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;


namespace Battery_Notification
{
    public class sendMail
    {
        string plainTextPW;
        StringEncryption decryptedPW = new StringEncryption();

        public sendMail()
        {
            // Class Constructor that decrypts the saved password, and stores it as a local variable.
            
            if (Properties.Settings.Default.firstRun != true)
            {
                plainTextPW = decryptedPW.Decrypt(Properties.Settings.Default.Password);
            }
        }

        public bool sendNow(string subject, string mailBody)
        {
            // Defining the SMTP client, that will be sending the email.
            plainTextPW = decryptedPW.Decrypt(Properties.Settings.Default.Password);
            SmtpClient smtp = new SmtpClient
            {
                Host = Properties.Settings.Default.Host,
                Port = Properties.Settings.Default.Port,
                EnableSsl = Properties.Settings.Default.SSL,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(Properties.Settings.Default.Username, plainTextPW)
            };
            MailAddress sentFrom = new MailAddress(Properties.Settings.Default.Username,Properties.Settings.Default.displayName);
            MailMessage message2 = new MailMessage();
            message2.Sender = sentFrom;
            message2.From = sentFrom;
            message2.To.Add(Properties.Settings.Default.sendTo);
            message2.Subject = subject;
            message2.Body = mailBody;
            //MailMessage message = new MailMessage(Properties.Settings.Default.Username,Properties.Settings.Default.sendTo,subject,mailBody);
            smtp.Send(message2);
            return true;
            /*try
            {
                message.Sender = from;
                smtp.Send(message);
                message.Dispose();
                smtp.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                // If there was an error, pass it to the main program so it can do something with it.
                throw new System.ArgumentException(ex.Message);
            }*/
        }
    }
}
