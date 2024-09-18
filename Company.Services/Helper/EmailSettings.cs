using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Company.Services.Helper
{
    public static class EmailSettings
    {
        public static void SendEmail(Email input)
        {
            var Client = new SmtpClient("smtp.gmail.com" ,587);
            Client.EnableSsl = true;
            Client.Credentials = new NetworkCredential("mosaleh.work@gmail.com", "rlkztbypqipxeira");
            Client.Send("mosaleh.work@gmail.com", input.To, input.Subject,input.Body); 
        }
    }
}
