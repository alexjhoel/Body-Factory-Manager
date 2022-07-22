using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;

namespace Body_Factory_Manager
{
    public class Email
    {
        private MailMessage mailMessage = new MailMessage();
        SmtpClient smtp = new SmtpClient();

        public Email(string usuario, string contraseña)
        {
            smtp.Host = "smtp-mail.outlook.com";

            smtp.UseDefaultCredentials = false;
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential(usuario, contraseña);
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
        }

        public void Mensaje(string remitente, string destinatario, string asunto, string cuerpo, bool esHtml = false)
        {
            mailMessage.To.Clear();
            mailMessage.From = new MailAddress(remitente);
            mailMessage.To.Add(new MailAddress(destinatario));
            mailMessage.Subject = asunto;
            mailMessage.IsBodyHtml = esHtml;
            mailMessage.Body = cuerpo;

        }

        public bool Enviar()
        {
            try
            {
                smtp.Send(mailMessage);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }


    }
}

