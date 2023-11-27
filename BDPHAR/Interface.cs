using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Net;
using System.Net.Mail;
namespace BDPHAR
{
    class Interface
    {
        public static PharmacyEntities Ph = new PharmacyEntities();
        public static int UserId  { get; set; }
        public static int Role { get; set; }
        public static Frame MainFrame { get; set; }
        public static MailAddress mailAddressFrom = new MailAddress("asgard.pharmacy@gmail.com", "asgard.pharmac");
        public static SmtpClient smtp = new SmtpClient
        {
            Host = "smtp.gmail.com",
            Port = 587,
            EnableSsl = true,
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential(new MailAddress("asgard.pharmacy@gmail.com", "asgard.pharmac").Address, "2281488D")
        };
        public static Users user = new Users();
    }
}
