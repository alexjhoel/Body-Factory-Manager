using System;
using System.Net;
using System.Net.Mail;

namespace Body_Factory_Manager
{
    public class Comunicacion
    {
        private MailMessage mailMessage = new MailMessage();
        SmtpClient smtp = new SmtpClient();

        public Comunicacion(string usuario, string contraseña)
        {
            smtp.Host = "smtp-mail.outlook.com";

            smtp.UseDefaultCredentials = false;
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential(usuario, contraseña);
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
        }

        public Comunicacion()
        {

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

        public void Chatear(string numero)
        {
            System.Diagnostics.Process.Start("https://web.whatsapp.com/send/?phone=598" + numero + "&text&type=phone_number&app_absent=0");
        }


    }
}

