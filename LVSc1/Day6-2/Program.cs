using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

using System.Data.SqlClient;


namespace Day6_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //step 1 handshake with the db
            SqlConnection myConnection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\DB2.mdf;Integrated Security = True;User Instance=True");
            //var conn = new OdbcConnection("Data Source=DB2.mdf");
            myConnection.Open();

            //step 2 specify the cmomand
            SqlCommand mycommand = myConnection.CreateCommand();
            mycommand.CommandText = "select * from Customer";
            mycommand.CommandType = System.Data.CommandType.Text;

            //mycommand.CommandText = "pr_GetCustomers";
            //mycommand.CommandType = System.Data.CommandType.StoredProcedure;
            
            SqlDataReader myReader;
            myReader = mycommand.ExecuteReader();

            // step 3 use the data
            while (myReader.Read())
            {
                Console.WriteLine(myReader[1] + "" + myReader[2]);
            }

         
            Console.ReadLine();
            myConnection.Close();
        }
    }
}
