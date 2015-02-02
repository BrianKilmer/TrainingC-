using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BusinessLayer
{
    public class EmployeeBusinessLayer
    {
        public IEnumerable<Employee> Employees
        {
            //only need to return, so no 'set' accessor is needed.
            get
            {
                string connectionString = ConfigurationManager.ConnectionStrings["EmployeeContext"].ConnectionString;

                List<Employee> employees = new List<Employee>();

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spGetAllEmployees", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Employee employee = new Employee();
                        employee.id = Convert.ToInt32(rdr["Id"]);
                        employee.DepartmentID = Convert.ToInt32(rdr["DepartmentID"]);
                        employee.age = Convert.ToInt32(rdr["age"]);
                        employee.NameFirst = rdr["NameFirst"].ToString();
                        employee.NameLast = rdr["NameLast"].ToString();
                        employee.gender = rdr["Gender"].ToString();
                        employee.city = rdr["City"].ToString();
                        employee.DateOfBirth = Convert.ToDateTime(rdr["DateOfBirth"]);

                        employees.Add(employee);
                    }
                }

                return employees;
            }
        }
    }
}
