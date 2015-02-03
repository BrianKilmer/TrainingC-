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
                        if (!(rdr["DateOfBirth"] is DBNull)) 
                        {
                            employee.DateOfBirth = Convert.ToDateTime(rdr["DateOfBirth"]);
                        }
                        

                        employees.Add(employee);
                    }
                }

                return employees;
            }
        }

        public void AddEmployee(Employee employee)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EmployeeContext"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramNameF = new SqlParameter();
                paramNameF.ParameterName = "@NameFirst";
                paramNameF.Value = employee.NameFirst;
                cmd.Parameters.Add(paramNameF);

                SqlParameter paramNameL = new SqlParameter();
                paramNameL.ParameterName = "@NameLast";
                paramNameL.Value = employee.NameLast;
                cmd.Parameters.Add(paramNameL);

                SqlParameter paramGender = new SqlParameter();
                paramGender.ParameterName = "@gender";
                paramGender.Value = employee.gender;
                cmd.Parameters.Add(paramGender);

                SqlParameter paramcity = new SqlParameter();
                paramcity.ParameterName = "@city";
                paramcity.Value = employee.city;
                cmd.Parameters.Add(paramcity);

                SqlParameter paramage = new SqlParameter();
                paramage.ParameterName = "@age";
                paramage.Value = employee.age;
                cmd.Parameters.Add(paramage);

                SqlParameter paramDeptID = new SqlParameter();
                paramDeptID.ParameterName = "@DepartmentID";
                paramDeptID.Value = employee.DepartmentID;
                cmd.Parameters.Add(paramDeptID);

                SqlParameter paramDOB = new SqlParameter();
                paramDOB.ParameterName = "@DateOfBirth";
                paramDOB.Value = employee.DateOfBirth;
                cmd.Parameters.Add(paramDOB);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
