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
           List<string> emailList = new List<string>();
            
            using (SqlConnection myConnection = new SqlConnection("data source=db-dev;initial catalog=print;integrated security=True;User ID=iusr_print_sq;Password=Dasesa809"))
            {
                SqlCommand command = new SqlCommand("select email from employee where email = 'bkilmer@outreach.com'", myConnection);
                myConnection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("email: {0}", reader.GetString(0));
                        emailList.Add(reader.GetString(0).ToString());
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                
                //---------------------------------------------

                // Create a new instance of the MailMessage Class
                MailMessage mailMessage = new MailMessage();

                foreach (var emailTo in emailList)
                {
                    //Console.WriteLine("Email from list {0}", emailTo);
                    //Add email to collection
                    mailMessage.To.Add(emailTo);
                }

                // set the 'subject',' body' and 'from' : (Address and DisplayName - 2nd overload)
                mailMessage.Subject = "HELLO";
                mailMessage.Body = "THIs IS A TEST";
                mailMessage.From = new MailAddress("brianjkilmer@gmail.com", "BK");

                //Create a new instance of the SmtpClient class with (host and port) overlaod
                SmtpClient smtpMail = new SmtpClient("192.168.131.45", 25);

                smtpMail.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpMail.UseDefaultCredentials = true;
                smtpMail.EnableSsl = false;

                try
                {
                    smtpMail.Send(mailMessage);
                    Console.WriteLine("Messages Sent");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                }
                Console.ReadLine();


                
            }




        }
    }
}
