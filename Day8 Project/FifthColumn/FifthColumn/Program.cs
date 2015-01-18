using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace FifthColumn
{
    class Program
    {
        static void Main(string[] args)
        {

           //GetMenu getMenu = new GetMenu();
           // string CountryCodeReturn = getMenu.GetMyMenu();

            Console.WriteLine("5th Column response team");
            Console.WriteLine("============================-");

            bool value = true;
            while (value)
	        {
	         value = displayMenu();
	        }
        }  

        private static bool displayMenu() 
        {
           // Console.WriteLine("got here");
           // Console.WriteLine("");
            //Console.WriteLine("");
            Console.Clear();
            Console.WriteLine("Menu");
            Console.WriteLine("----------------------------");
            Console.WriteLine("1 - Incidents By Country");
            Console.WriteLine("2 - Report new Incident");
            Console.WriteLine("3 - Exit");
            Console.WriteLine("----------------------------");
                
            string response = Console.ReadLine();

            switch (response) 
            {
                case "1":
                    displayIncidentByCountry();
                    break;
                case "2":
                    displayReportNewIncident() ;
                    break;
                case "3":
                    return false;
                default:
                    Console.WriteLine("Invalid entry 1,2,3");
                    Console.ReadLine();
                    break;
            }

            return true;
        }

        private static void displayIncidentByCountry()
        {
            Console.WriteLine("");
            Console.WriteLine("Type in Country Code");
            string countryCode = Console.ReadLine();

            SqlConnection myConnection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\FifthColumn.mdf;Integrated Security = True;User Instance=True");
             myConnection.Open();

            SqlCommand mycommand = myConnection.CreateCommand();
            SqlDataReader myReader;
            // mycommand.CommandText = "select * from Customer";
            // mycommand.CommandType = System.Data.CommandType.Text;
           
            mycommand.CommandText = "GetIncidenstByCountry";
            mycommand.CommandType = System.Data.CommandType.StoredProcedure;
           // mycommand.Parameters.Add("@Country", SqlDbType.VarChar).Value = countryCode;
            mycommand.Parameters.Add(new SqlParameter ("@Country",countryCode));
            myReader = mycommand.ExecuteReader();


            while (myReader.Read())
            {
                Console.WriteLine("Agent: " + myReader[2] + " " + myReader[3] + " " + "Investigated: " + myReader[4]);
            }


            Console.ReadLine();
            myConnection.Close();

            Console.WriteLine("");
            Console.WriteLine("Press return to continue...");
            Console.ReadLine();

        }
        public static void displayReportNewIncident()
        {
            Console.WriteLine("");
            Console.WriteLine("Type in Country Code");
            string countryCode = Console.ReadLine();

            Console.WriteLine("AgentID 1-100");
            string agentID = Console.ReadLine();

            Console.WriteLine("Type in Country Incident Id  1-4");
            string incidentID = Console.ReadLine();

            // 1. 
            SqlConnection myConnection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\FifthColumn.mdf;Integrated Security = True;User Instance=True");
            myConnection.Open();

            //2. 
            SqlCommand mycommand = myConnection.CreateCommand();

            mycommand.CommandText = "InsertIncident";
            mycommand.CommandType = System.Data.CommandType.StoredProcedure;
            // mycommand.Parameters.Add("@Country", SqlDbType.VarChar).Value = countryCode;
            mycommand.Parameters.Add(new SqlParameter("@Country", countryCode));
            mycommand.Parameters.Add(new SqlParameter("@IncidentTypeID", byte.Parse(incidentID)));
            mycommand.Parameters.Add(new SqlParameter("@agentID", int.Parse(agentID)));
            mycommand.Parameters.Add(new SqlParameter("@incidentDate", DateTime.Now));

            int RecsAffected = mycommand.ExecuteNonQuery();

            if (RecsAffected == 1)
            {
                Console.WriteLine("");
                Console.WriteLine("Insert Successful");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Houstn we had a problem..");
            }


            Console.ReadLine();
            myConnection.Close();

            Console.WriteLine("");
            Console.WriteLine("Press return to continue...");
            Console.ReadLine();
        }

    }
}
