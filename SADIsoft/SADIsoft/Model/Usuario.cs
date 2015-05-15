using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Net;

namespace SADI.Model
{
    public class Usuario
    {
        public Usuario(string us, string con)
        {
            Nombre = us;
            Contrasena = con;
        }

        public string Nombre { get; set; }
        public string Contrasena { get; set; }


        //--------------------------------------------------------------------
        // Envia un mensaje al Propietario y retorna una contrasena aleatoria
        //--------------------------------------------------------------------
        public static string EnviarEmailUsuario(string email)
        {
            string randomP = CreateRandomPassword(10);

            MailMessage mail = new MailMessage();
            SmtpClient client = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("franciscogod18@gmail.com");
            mail.To.Add(email);
            mail.Subject = "Validacion de la cuenta de Ventas SADI";
            mail.Body = string.Format(@"Bienvenido a SADI\n\nEste correo es para activar su cuenta para poder ver el estado de sus inmuebles " +
                @"administrados por SADI via Web. Con el codigo enviado en este email entre a http:\\www.SADI.com\Propietarios y siga las " +
                "instrucciones para activar su cuenta:\n\n\n" + randomP);

            client.Port = 587;
            client.Credentials = new NetworkCredential("sadisoftwera@gmail.com", "151819151819");
            client.EnableSsl = true;

            client.Send(mail);

            return randomP;
        }


        //-----------------------------------------------------------
        // Crea una Contraseña aleatoria y la retorna
        //-----------------------------------------------------------
        private static string CreateRandomPassword(int PasswordLength)
        {
            string _allowedChars = "abcdefghijkmnpqrstuvwxyzABCDEFGHJKLMNPQRSTUVWXYZ23456789!@$?";
            Byte[] randomBytes = new Byte[PasswordLength];
            char[] chars = new char[PasswordLength];
            int allowedCharCount = _allowedChars.Length;

            for (int i = 0; i < PasswordLength; i++)
            {
                Random randomObj = new Random();
                randomObj.NextBytes(randomBytes);
                chars[i] = _allowedChars[(int)randomBytes[i] % allowedCharCount];
            }

            return new string(chars);
        }
    }
}