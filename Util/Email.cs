using System.Net.Mail;
using System.Net;
using redTaller.Modelo;
using redTaller.Database;
using static Org.BouncyCastle.Math.EC.ECCurve;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System;

namespace redTaller.Util
{
    public class Email
    {

        Modelo.Config config;

        public Email() {
            ConfigDB configDB = new ConfigDB();
            config = configDB.Carga();
        }

        public bool EnviarEmail(string toEmailAddress, string subject, string body)
        {
            try
            {
                var fromAddress = new MailAddress(config.EmailCuenta, "redTaller");
                var toAddress = new MailAddress(toEmailAddress);
                string fromPassword = config.EmailPassword;
                System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

                var smtp = new SmtpClient
                {
                    Host = config.EmailSmtpServer,
                    Port = config.EmailSmtpPort, 
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };

                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                    return true;
                }
            }
            catch (SmtpException ex)
            {
                Console.WriteLine($"Error al enviar correo: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
                return false;
            }
        }

    }

}

