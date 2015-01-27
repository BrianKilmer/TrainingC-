using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;
using System.Data;

namespace SendEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new instance of the MailMessage Class
            MailMessage mailMessage = new MailMessage();

            //Create an array to store each email address
            string[] emailTo = { "bkilmer@outreach.com","brianjkilmer@gmail.com" };

            //Loop through the array and add them to the collection of recipients using the mailMessage.To.Add method
            foreach (var m in emailTo)
            {
                mailMessage.To.Add(m);
            }
            
            // set the 'subject',' body' and 'from' : (Addres and DisplayName - 2nd overload)
            mailMessage.Subject = "HELLO";
            mailMessage.Body = "THIs IS A TEST";
            mailMessage.From = new MailAddress("brianjkilmer@gmail.com", "BK");

            //Create a new instance of the class with (host and port) overlaod
            SmtpClient smtpMail = new SmtpClient("smtp.gmail.com",587);

            smtpMail.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpMail.UseDefaultCredentials = true;
            smtpMail.Credentials = new NetworkCredential("brianjkilmer@gmail.com", "*****");
            //Set SSL to true
            smtpMail.EnableSsl = true;

            // this won't send unless i enable in my gmail account... and supply correct password **** above.
            try
            {
                smtpMail.Send(mailMessage);
                Console.WriteLine("Message Sent");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            Console.ReadLine();

            //fill from db
            // using (SqlConnection cnn = new SqlConnection("server=(local);database=pubs;Integrated Security=SSPI"))  {
            // SqlDataAdapter da = new SqlDataAdapter("select email from employee", cnn); 
            // DataSet ds = new DataSet();
            // da.Fill(ds, "employee");

            // MailMessage mailMessage2 = new MailMessage();

            // List<string> emailList = new List<string>();
            // foreach(DataRow row in ds.Tables["employee"].Rows)
            // {
            //    // emailList.Add(row["name"].ToString());
            //     //mailMessage.To.Add(row);

            // }
            //}
 

        }
    }
}
